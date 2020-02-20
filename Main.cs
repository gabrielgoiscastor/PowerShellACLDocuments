using Newtonsoft.Json;
using PowerShellACLDocuments.DataModeling;
using PowerShellACLDocuments.JsonMapping;
using PowerShellACLDocuments.Scripting;
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
            baseConfigFor = lblConfigsFor.Text;
            lblConfigsFor.Text = "";
            btnClearSelection.Hide();

            btnInputBase.Hide();
            btnActionBase.Hide();
            btnDeleteFolder.Hide();

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
        string baseConfigFor = "";
        string invalidCharsForFolderName = "\\*!@#$%^&*()ãàéèóòõíìúùÃÀÉÈÓÒÕÍÌÚÙ";
        List<Control> clearableInterfaces = new List<Control>();

        int latestUpdated = -1;
        Package package = new Package();
        Folder workingFolder = null;
        ActionForms.ACLForm aclForm = new ActionForms.ACLForm();

        #region mainMenu

        private void txtPath_Leave(object sender, EventArgs e)
        {
            if (txtPath.Text.EndsWith("\\") == false)
            {
                txtPath.Text += @"\";
            }
        }

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

            addFolders(package.Folders, foldersTree.Nodes);
        }

        private void addFolders(List<Folder> folders, TreeNodeCollection collection)
        {
            folders.ForEach(folder =>
            {
                var newFolder = collection.Add(folder.Name);
                addFolders(folder.Folders, newFolder.Nodes);
            });
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
            this.btnActionBase.Hide();

            Button newBtn = copyModelObject(parameter.Name + " | " + parameter.IsInput.ToString(), this.btnActionBase, splitContainer.Panel1);

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
            this.latestUpdated = workingFolder.Actions.IndexOf(action);

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
                workingFolder.Actions.Add(this.aclForm.aclSetting);
            }
            else if (this.aclForm.delete)
            {
                workingFolder.Actions.RemoveAt(latestUpdated);
            }
            else
            {
                workingFolder.Actions[latestUpdated] = this.aclForm.aclSetting;
            }
            this.renderActions();
        }

        public void renderActions()
        {
            this.btnInputBase.Hide();

            Panel targetPanel = splitContainer.Panel1;

            for (int i = targetPanel.Controls.Count - 1; i >=0 ; i--)
            {
                Control control = targetPanel.Controls[i];
                if ((control as Button).Name == "btnActionBase")
                {
                    continue;
                }
                targetPanel.Controls.Remove(control);
            }

            for (int i = 0; i < workingFolder.Actions.Count; i++)
            {
                BaseAction action = workingFolder.Actions[i];
                Button newBtn = copyModelObject(action.ToString(), this.btnActionBase, splitContainer.Panel1);
                newBtn.Click += (sender, e) => editAction_Click(sender, e, action);
                targetPanel.Controls.Add(newBtn);
            }
        }

        #endregion

        #region generate powershell script
        private void btnGeneratePS_Click(object sender, EventArgs e)
        {
            ScriptGenerator generator = new ScriptGenerator();

            string newScript = generator.generateScript(this.package);

            saveFileDialog.DefaultExt = "ps1";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                File.WriteAllText(saveFileDialog.FileName, newScript);
            }

            saveFileDialog.DefaultExt = "json";
        }

        #endregion

        #region folders actions
        private void toolStripNewFolder_Click(object sender, EventArgs e)
        {
            string folderName = null;

            while(folderName == null || validFolderName(folderName) == false)
            {
                if(folderName != null)
                {
                    MessageBox.Show("Invalid folder name");
                }
                folderName = Microsoft.VisualBasic.Interaction.InputBox("Create a new folder", "New Folder", folderName);
            }

            if (string.IsNullOrEmpty(folderName))
            {
                return;
            }

            if (foldersTree.SelectedNode != null)
            {
                foldersTree.SelectedNode.Nodes.Add(folderName);
                workingFolder.Folders.Add(new Folder() { Name = folderName });
            }
            else
            {
                foldersTree.Nodes.Add(folderName);
                package.Folders.Add(new Folder() { Name = folderName });
            }

            foldersTree.Sort();
        }

        private bool validFolderName(string folderName)
        {
            if(folderName == null)
            {
                return true;
            }

            char[] arr = invalidCharsForFolderName.ToArray();

            foreach (var item in arr)
            {
                if (folderName.Contains(item)) return false;
            }

            return true;
        }

        private void foldersTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (foldersTree.SelectedNode == null)
            {
                this.lblConfigsFor.Text = "";
                return;
            }
            this.lblConfigsFor.Text = this.baseConfigFor + ": " + foldersTree.SelectedNode.FullPath;
            btnClearSelection.Show();
            btnDeleteFolder.Show();
            workingFolder = package.FindFolder(foldersTree.SelectedNode.FullPath);
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            lblConfigsFor.Text = "";
            foldersTree.SelectedNode = null;
            btnClearSelection.Hide();
        }

        private void deleteFolder()
        {
            Folder parentFolder = package.FindParent(foldersTree.SelectedNode.FullPath);

            Folder target = parentFolder.Folders.Where(x => x.Name == foldersTree.SelectedNode.Text).First();

            parentFolder.Folders.Remove(target);

            //selected from root, remove object
            if(foldersTree.SelectedNode.FullPath.Contains(foldersTree.PathSeparator) == false)
            {
                this.package.Folders = parentFolder.Folders;
            }

            foldersTree.SelectedNode.Remove();
        }

        #endregion

        private void btnDeleteFolder_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Sure?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            this.deleteFolder();
        }
    }
}
