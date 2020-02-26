using Newtonsoft.Json;
using PowerShellACLDocuments.Automators;
using PowerShellACLDocuments.DataModeling;
using PowerShellACLDocuments.FormSharedCode;
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

            this.baseTitle = this.Text;
            baseConfigFor = lblConfigsFor.Text;
            lblConfigsFor.Text = "";
            btnInputBase.Hide();
            btnActionBase.Hide();
            folderActions(false);

            this.aclForm.FormClosing += AclForm_FormClosing;
            this.aclForm.VisibleChanged += AuxForm_VisibleChanged;
            this.inputForm.FormClosing += InputForm_FormClosing;
            aclGroupManageForms.FormClosing += AclGroupManageForms_FormClosing;
            aclAddGroup.FormClosing += AclAddGroup_FormClosing;

            getSettings();

            if(settings.LatestFile != "")
            {
                this.saveFileDialog.FileName = settings.LatestFile;
                this.openFile(saveFileDialog.FileName);
                this.somethingChange(true);

                //if (MessageBox.Show("Should I load the latest file?", "Load latest", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //{
                //}
            }
        }

        private void getSettings()
        {
            FileInfo info = new FileInfo(this.settingsFileName);
            if (info.Exists == false)
            {
                setSettings();
                return;
            }

            try
            {
                this.settings = Newtonsoft.Json.JsonConvert.DeserializeObject<psACLSettings>(File.ReadAllText(this.settingsFileName));
            }catch(Exception err)
            {
                setSettings();
            }
        }

        private void setSettings()
        {
            if(this.settings == null)
            {
                this.settings = new psACLSettings() { LatestFile = "" };
            }
            string serializedSettings = JsonConvert.SerializeObject(this.settings);
            File.WriteAllText(this.settingsFileName, serializedSettings);

            this.somethingChange(true);
        }

        string baseTitle = "";
        string filePath = "";
        bool savePending = false;
        string settingsFileName = AppDomain.CurrentDomain.BaseDirectory + "\\settings.json";
        psACLSettings settings = null;
        string baseConfigFor = "";
        string invalidCharsForFolderName = "\\*!@#$%^&*()ãàéèêóòõíìúùçÃÀÉÈÊÓÒÕÔÍÌÚÙÇ`~;',{}[]/?<>|+=";

        int latestUpdated = -1;
        Package package = new Package();
        Folder workingFolder = null;
        ButtonCopier btnCopier = new ButtonCopier();
        ActionForms.ACLForm aclForm = new ActionForms.ACLForm();
        InputParameters.InputParameterForm inputForm = new InputParameters.InputParameterForm();
        ACLSettingsGroups aclGroupManageForms = new ACLSettingsGroups();
        ACLGroups.ACLGroupSelectToAdd aclAddGroup = new ACLGroups.ACLGroupSelectToAdd();

        #region mainMenu

        private void txtPath_Leave(object sender, EventArgs e)
        {
            if (txtPath.Text.EndsWith("\\") == false)
            {
                txtPath.Text += @"\";
            }
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (progressLostOk() == false) { return; }
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

            settings.LatestFile = filePath;
            this.setSettings();
        }

        private void openFile(string path)
        {
            try
            {
                this.filePath = path;
                string fileContent = File.ReadAllText(this.filePath);
                JsonConverter[] converters = { new ActionContract() };
                Package pack = JsonConvert.DeserializeObject<Package>(fileContent, new JsonSerializerSettings() { Converters = converters, MissingMemberHandling = MissingMemberHandling.Ignore });
                workingFolder = null;
                this.package = pack;
                this.clearInterface();
                this.renderEverything();
                this.saveFileDialog.FileName = filePath;
                this.somethingChange(true);
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
            txtDefaultFolderManual.Text = package.FolderInstructionsDefaultFileName;

            addFolders(package.Folders, foldersTree.Nodes);
            renderParameters();
        }

        private void addFolders(List<Folder> folders, TreeNodeCollection collection)
        {
            folders.ForEach(folder =>
            {
                var newFolder = collection.Add(folder.Name);
                addFolders(folder.Folders, newFolder.Nodes);
            });
        }

        private void newFromExistingFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.folderDialog.ShowDialog();
            string path = this.folderDialog.FileName;

            path = path.Replace("Select a folder", "");

            ConvertDirectoryStructure converter = new ConvertDirectoryStructure();

            this.package.Folders = converter.readFolder(path);

            this.renderEverything();
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
            foreach(var control in this.Controls)
            {
                if(control is TextBox)
                {
                    (control as TextBox).Text = "";
                }
                if(control is TreeView)
                {
                    (control as TreeView).Nodes.Clear();
                }
            }

            this.renderActions();

            settings.LatestFile = "";
            setSettings();
        }

        private void somethingChange(bool? clear)
        {
            this.Text = this.baseTitle;
            if (saveFileDialog.FileName != "")
            {
                this.Text += " " + saveFileDialog.FileName;
            }

            if (clear.HasValue && clear.Value)
            {
                this.savePending = false;
                return;
            }
            this.savePending = true;
            this.Text += " *";
        }

        #endregion

        #region event handlers

        private void txtBox_KeyUp(object sender, KeyEventArgs e)
        {
            this.somethingChange(false);
            this.package.Name = txtName.Text;
            this.package.BasePath = txtPath.Text;
            this.package.FolderInstructionsDefaultFileName = txtDefaultFolderManual.Text;
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

            Button newBtn = btnCopier.copyModelObject(parameter.Name + " | " + parameter.IsInput.ToString(), this.btnActionBase, splitContainer.Panel1);

            splitContainer.Panel1.Controls.Add(newBtn);
        }

        #endregion

        #region actions methods

        private void toolBtnNewACL_Click(object sender, EventArgs e)
        {
            this.latestUpdated = -1;
            this.aclForm.initialize(null, this.workingFolder.Actions.Count, -1);
            this.aclForm.Show();
        }

        private void editAction_Click(object sender, EventArgs e, BaseAction action)
        {
            this.latestUpdated = workingFolder.Actions.IndexOf(action);

            if(action is ACLSetting)
            {
                this.aclForm.initialize(action as ACLSetting, workingFolder.Actions.Count, latestUpdated);
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

            if(workingFolder.Actions == null)
            {
                workingFolder.Actions = new List<BaseAction>();
            }

            if (latestUpdated == -1)
            {
                workingFolder.Actions.Insert(aclForm.moveToPosition.Value, this.aclForm.aclSetting);
            }
            else if (this.aclForm.delete)
            {
                workingFolder.Actions.RemoveAt(latestUpdated);
            }
            else
            {
                workingFolder.Actions[latestUpdated] = this.aclForm.aclSetting;
                if(this.aclForm.moveToPosition != latestUpdated)
                {
                    workingFolder.Actions.RemoveAt(latestUpdated);
                    workingFolder.Actions.Insert(this.aclForm.moveToPosition.Value, this.aclForm.aclSetting);
                }
            }
            this.somethingChange(null);
            this.renderActions();
        }

        public void renderActions()
        {
            this.btnActionBase.Hide();

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

            if(workingFolder == null || workingFolder.Actions == null || workingFolder.Actions.Count == 0)
            {
                return;
            }

            for (int i = 0; i < workingFolder.Actions.Count; i++)
            {
                BaseAction action = workingFolder.Actions[i];
                Button newBtn = btnCopier.copyModelObject(action.ToString(), this.btnActionBase, targetPanel);
                newBtn.Click += (sender, e) => editAction_Click(sender, e, action);

                if(action is ACLSetting)
                {
                    var a = (action as ACLSetting);
                    if (a.BgColor.IsEmpty == false)
                    {
                        newBtn.BackColor = a.BgColor;
                    }
                }

                targetPanel.Controls.Add(newBtn);
            }
        }

        private void toolAddActionFromGroups_Click(object sender, EventArgs e)
        {
            aclAddGroup.initialize(package.ACLSettingsGroups);
            aclAddGroup.Show();
            this.Hide();
        }

        #endregion

        #region input actions

        private void toolBtnNewInput_Click(object sender, EventArgs e)
        {
            latestUpdated = -1;
            inputForm.initialize(null);
            inputForm.Show();
            this.Hide();
        }

        private void InputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            if (inputForm.executed == false)
            {
                inputForm.Hide();
                this.Show();
                this.Focus();
                return;
            }

            if (inputForm.deleted)
            {
                this.inputForm.Hide();
                this.Show();
                this.Focus();
                package.Parameters.RemoveAt(latestUpdated);
                renderParameters();
                return;
            }

            // check parameter name
            for (int i = 0; i < package.Parameters.Count; i++)
            {
                if(i == latestUpdated)
                {
                    continue;
                }
                Parameter p = package.Parameters[i];

                if(p.Name == inputForm.parameter.Name)
                {
                    MessageBox.Show("Parameter with name " + inputForm.parameter.Name + " already exists");
                    this.inputForm.Show();
                    return;
                }
            }

            this.inputForm.Hide();
            this.Show();
            this.Focus();

            if (latestUpdated == -1)
            {
                if(this.package.Parameters == null) { this.package.Parameters = new List<Parameter>(); }
                this.package.Parameters.Add(this.inputForm.parameter);
                renderParameters();
                return;
            }

            this.package.Parameters[latestUpdated] = inputForm.parameter;
            renderParameters();
        }

        public void renderParameters()
        {
            this.btnInputBase.Hide();

            Panel targetPanel = splitContainer.Panel2;

            for (int i = targetPanel.Controls.Count - 1; i >= 0; i--)
            {
                Control control = targetPanel.Controls[i];
                if ((control as Button).Name == "btnInputBase")
                {
                    continue;
                }
                targetPanel.Controls.Remove(control);
            }

            if (package == null || package.Parameters == null || package.Parameters.Count == 0)
            {
                return;
            }

            for (int i = 0; i < package.Parameters.Count; i++)
            {
                DataModeling.Parameter parameter = package.Parameters[i];
                Button newBtn = btnCopier.copyModelObject(parameter.ToString(), btnInputBase, targetPanel);
                newBtn.Click += (sender, e) => editInput_Click(sender, e, parameter);
                targetPanel.Controls.Add(newBtn);
            }
        }

        private void editInput_Click(object sender, EventArgs e, Parameter parameter)
        {
            this.latestUpdated = package.Parameters.IndexOf(parameter);

            this.inputForm.initialize(parameter);
            this.inputForm.Show();
            this.Hide();
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

        private void btnNewFolder_Click(object sender, EventArgs e)
        {
            string folderName = null;

            while (folderName == null || validFolderName(folderName) == false)
            {
                if (folderName != null)
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
            folderActions(true);
            workingFolder = package.FindFolder(foldersTree.SelectedNode.FullPath);
            txtFolderInstructions.Text = workingFolder.FolderInstructions != null ? workingFolder.FolderInstructions : "";
            renderActions();
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            folderActions(false);
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
            foldersTree.SelectedNode = null;
            folderActions(false);
        }

        private void btnRenameFolder_Click(object sender, EventArgs e)
        {
            string folderName = null;

            while (folderName == null || validFolderName(folderName) == false)
            {
                if (folderName != null)
                {
                    MessageBox.Show("Invalid folder name");
                }
                folderName = Microsoft.VisualBasic.Interaction.InputBox("Rename folder", "", workingFolder.Name);
            }

            if (string.IsNullOrEmpty(folderName))
            {
                return;
            }

            this.workingFolder.Name = folderName;
            foldersTree.SelectedNode.Text = folderName;
            foldersTree.Sort();
            workingFolder = null;
            somethingChange(false);
            folderActions(false);
        }

        private void folderActions(bool show)
        {
            renderActions();

            if (show)
            {
                btnRenameFolder.Show();
                btnDeleteFolder.Show();
                btnClearSelection.Show();
                txtFolderInstructions.Enabled = true;
                toolBtnNewACL.Enabled = true;
                toolAddActionFromGroups.Enabled = true;
                return;
            }

            lblConfigsFor.Text = "";
            foldersTree.SelectedNode = null;
            toolBtnNewACL.Enabled = false;
            toolAddActionFromGroups.Enabled = false;
            btnRenameFolder.Hide();
            btnDeleteFolder.Hide();
            btnClearSelection.Hide();
            txtFolderInstructions.Enabled = false;
        }

        private void txtFolderInstructions_TextChanged(object sender, EventArgs e)
        {
            if(workingFolder == null)
            {
                return;
            }

            workingFolder.FolderInstructions = txtFolderInstructions.Text;
        }

        private void btnDeleteFolder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            this.deleteFolder();
        }

        private void foldersTree_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2 && workingFolder != null)
            {
                btnRenameFolder_Click(sender, e);
            }
        }

        bool expanded = false;

        private void btnExpandCollapse_Click(object sender, EventArgs e)
        {
            if (!expanded)
            {
                foldersTree.ExpandAll();
            }
            else
            {
                foldersTree.CollapseAll();
            }
            expanded = !expanded;
        }

        #endregion

        #region ACL Groups
        private void menuACLGroupManage_Click(object sender, EventArgs e)
        {
            aclGroupManageForms.package = package;
            aclGroupManageForms.Show();
            this.Hide();
        }

        private void AclGroupManageForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            aclGroupManageForms.Hide();
            this.package.ACLSettingsGroups = aclGroupManageForms.package.ACLSettingsGroups;

            // update all groups within folders
            foreach(var folder in this.package.Folders)
            {
                folder.UpdateIfAnyInherited(package.ACLSettingsGroups);
            }

            if(workingFolder != null)
            {
                this.renderActions();
            }

            somethingChange(false);

            this.Show();
            this.Focus();
        }

        private void AclAddGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Show();
            aclAddGroup.Hide();

            if(aclAddGroup.SelectedGroup == null)
            {
                return;
            }

            workingFolder.Actions.AddRange(aclAddGroup.SelectedGroup.CopySettings());
            if (workingFolder.AppliedACLGroup.Contains(aclAddGroup.SelectedGroup.Id) == false)
            {
                workingFolder.AppliedACLGroup.Add(aclAddGroup.SelectedGroup.Id);
            }
            renderActions();
        }

        #endregion
    }
}
