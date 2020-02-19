using Newtonsoft.Json;
using PowerShellACLDocuments.DataModeling;
using PowerShellACLDocuments.JsonMapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerShellACLDocuments
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            this.clearableInterfaces = new List<Control>()
            {
                this.txtName,
                this.txtPath
            };

            this.baseTitle = this.Text;

            //temp code

            //for (int i = 0; i < 20; i++)
            //{
            //    this.newParameter(new Parameter() { IsInput = i % 2 == 0, Name = "Parameter " + i, Value = "" });
            //    this.newAction(new BaseAction("TestAction"));
            //}

            this.btnActionBase.Hide();
            this.btnInputBase.Hide();

            this.aclForm.FormClosing += AclForm_FormClosing;
            this.aclForm.VisibleChanged += AuxForm_VisibleChanged;

            if(this.saveFileDialog.FileName != "")
            {
                this.openFile(saveFileDialog.FileName);
            }
        }

        string baseTitle = "";
        string filePath = "";
        bool savePending = false;
        List<Control> clearableInterfaces = new List<Control>();

        int latestUpdated = -1;
        Package package = new Package();
        ActionForms.ACLForm aclForm = new ActionForms.ACLForm();

        #region mainMenu

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(progressLostOk() == false) { return; }
            this.clearInterface();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            this.openFile(openFileDialog.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(filePath == "")
            {
                saveFileDialog.ShowDialog();
                filePath = saveFileDialog.FileName;
            }

            if(filePath == "")
            {
                return;
            }

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(this.package);

            File.WriteAllText(filePath, json);

            this.somethingChange(true);
        }

        private void openFile(string path)
        {
            try
            {
                this.filePath = path;
                string fileContent = File.ReadAllText(this.filePath);
                JsonConverter[] converters = { new ActionContract() };
                Package pack = JsonConvert.DeserializeObject<Package>(fileContent, new JsonSerializerSettings() { Converters = converters });
                this.package = pack;
                this.renderEverything();
            }
            catch (Exception err)
            {
                MessageBox.Show("Impossible to read file", err.Message);
            }
            
        }

        private void renderEverything()
        {
            txtName.Text = package.Name;
            txtPath.Text = package.BasePath;
            this.renderActions();
        }

        #endregion

        #region tools menu actions

        private void toolBtnNewFileCopy_Click(object sender, EventArgs e)
        {

        }

        private void toolBtnNewInput_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region controls

        private bool progressLostOk()
        {
            if (this.savePending)
            {
                if (MessageBox.Show("Sure? All unsaved work will be lost", "Sure?", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return false;
                }
            }
            return true;
        }

        private void clearInterface()
        {
            foreach(var control in this.clearableInterfaces)
            {
                if(control is TextBox)
                {
                    (control as TextBox).Text = "";
                }
            }
        }

        private void somethingChange(bool? clear)
        {
            if(clear.HasValue && clear.Value)
            {
                this.savePending = false;
                this.Text = this.baseTitle;
                return;
            }
            this.savePending = true;
            this.Text = this.baseTitle + "*";
        }

        #endregion

        #region event handlers

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            this.somethingChange(false);
            this.package.Name = txtName.Text;
            this.package.BasePath = txtPath.Text;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.progressLostOk() == false)
            {
                e.Cancel = true;
                return;
            }
        }

        private void AuxForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.Hide();
                return;
            }
            this.Show();
        }

        #endregion

        #region BLL

        public void newParameter(Parameter parameter)
        {
            this.btnInputBase.Hide();

            Button newBtn = copyModelObject(parameter.Name + " | " + parameter.IsInput.ToString(), this.btnInputBase, splitContainer.Panel1);

            splitContainer.Panel1.Controls.Add(newBtn);
        }

        private Button copyModelObject(string text, Button baseButton, Panel container)
        {
            Button newBtn = new Button()
            {
                Text = text,
                Size = baseButton.Size,
                Location = new Point()
                {
                    X = baseButton.Location.X,
                    Y = (baseButton.Location.Y + baseButton.Size.Height) * (container.Controls.Count - 1) + 3
                },
                BackColor = baseButton.BackColor,
                Anchor = baseButton.Anchor
            };

            return newBtn;
        }

        #endregion

        #region actions methods

        private void toolBtnNewACL_Click(object sender, EventArgs e)
        {
            this.latestUpdated = -1;
            this.aclForm.initialize(null);
            this.aclForm.Show();
        }

        private void editAction_Click(object sender, EventArgs e, BaseAction action)
        {
            this.latestUpdated = this.package.Actions.IndexOf(action);

            if(action is ACLSetting)
            {
                this.aclForm.initialize(action as ACLSetting);
                this.aclForm.Show();
            }
        }

        private void AclForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.aclForm.Hide();
            this.Show();
            this.Focus();

            if (this.aclForm.executed == false)
            {
                return;
            }

            if (latestUpdated == -1)
            {
                this.package.Actions.Add(this.aclForm.aclSetting);
            }
            else if (this.aclForm.delete)
            {
                this.package.Actions.RemoveAt(latestUpdated);
            }
            else
            {
                this.package.Actions[latestUpdated] = this.aclForm.aclSetting;
            }
            this.renderActions();
        }

        public void renderActions()
        {
            this.btnActionBase.Hide();

            for (int i = splitContainer.Panel2.Controls.Count - 1; i >=0 ; i--)
            {
                Control control = splitContainer.Panel2.Controls[i];
                if ((control as Button).Name == "btnActionBase")
                {
                    continue;
                }
                splitContainer.Panel2.Controls.Remove(control);
            }

            for (int i = 0; i < package.Actions.Count; i++)
            {
                BaseAction action = this.package.Actions[i];
                Button newBtn = copyModelObject(action.ToString(), this.btnActionBase, splitContainer.Panel2);
                newBtn.Click += (sender, e) => editAction_Click(sender, e, action);
                splitContainer.Panel2.Controls.Add(newBtn);
            }
        }

        #endregion
    }
}
