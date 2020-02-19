using PowerShellACLDocuments.DataModeling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        string baseTitle = "";
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

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region tools menu actions

        private void toolBtnNewACL_Click(object sender, EventArgs e)
        {
            this.aclForm.initialize(null);
            this.aclForm.Show();
            this.Hide();
        }

        private void AclForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.aclForm.Hide();
            this.Show();

            if(this.aclForm.executed == false)
            {
                return;
            }

            if(latestUpdated == -1) {
                this.newAction(this.aclForm.aclSetting);
            }
        }

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

        private void somethingChange()
        {
            this.savePending = true;
            this.Text = this.baseTitle + "*";
        }

        #endregion

        #region event handlers

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            this.somethingChange();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.progressLostOk() == false)
            {
                e.Cancel = true;
                return;
            }
        }

        #endregion

        #region BLL

        public void newParameter(Parameter parameter)
        {
            this.btnInputBase.Hide();

            Button newBtn = copyModelObject(parameter.Name + " | " + parameter.IsInput.ToString(), this.btnInputBase, splitContainer.Panel1);

            splitContainer.Panel1.Controls.Add(newBtn);
        }

        public void newAction(BaseAction action)
        {
            this.btnActionBase.Hide();

            Button newBtn = copyModelObject(action.ActionType + " | " + action.ToString(), this.btnActionBase, splitContainer.Panel2);

            splitContainer.Panel2.Controls.Add(newBtn);
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
    }
}
