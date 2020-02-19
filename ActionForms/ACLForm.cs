using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerShellACLDocuments.ActionForms
{
    public partial class ACLForm : Form
    {
        public DataModeling.ACLSetting aclSetting;
        public bool executed = false;
        public bool delete = false;

        public ACLForm()
        {
            InitializeComponent();
        }

        public void initialize(DataModeling.ACLSetting aclSetting)
        {
            executed = false;
            delete = false;
            if (aclSetting == null)
            {
                this.clearForm();
                this.btnDelete.Hide();
                return;
            }
            this.btnDelete.Show();
            this.aclSetting = aclSetting;
            this.txtPath.Text = aclSetting.Path;
            this.txtWho.Text = aclSetting.ForWho;
            cbbLevel.SelectedItem = aclSetting.PermissionLevel;

            if (aclSetting.PermissionType)
            {
                this.rdbAllow.Checked = true;
            }
            else
            {
                this.rdbDeny.Checked = true;
            }

            this.chkChangePermissions.Checked = aclSetting.ChangePermissions;
            this.chkCreateFilesWriteData.Checked = aclSetting.CreateFilesWriteData;
            this.chkCreateFoldersAppendData.Checked = aclSetting.CreateFoldersAppendData;
            this.chkDelete.Checked = aclSetting.Delete;
            this.chkDeleteSubfoldersAndFiles.Checked = aclSetting.DeleteSubfoldersAndFiles;
            this.chkFullControl.Checked = aclSetting.FullControl;
            this.chkListFolderReadData.Checked = aclSetting.ListFolderReadData;
            this.chkReadAttributes.Checked = aclSetting.ReadAttributes;
            this.chkReadExtendedAttributes.Checked = aclSetting.ReadExtendedAttributes;
            this.chkReadPermissions.Checked = aclSetting.ReadPermissions;
            this.chkTakeOwnership.Checked = aclSetting.TakeOwnership;
            this.chkTraverseFolderExecuteFile.Checked = aclSetting.TraverseFolderExecuteFile;
            this.chkWriteAttributes.Checked = aclSetting.WriteAttributes;
            this.chkWriteExtendedAttributes.Checked = aclSetting.WriteExtendedAttributes;
        }

        public void clearForm()
        {
            this.aclSetting = new DataModeling.ACLSetting();
            this.txtPath.Text = "";
            this.txtWho.Text = "";
            cbbLevel.SelectedItem = "Select";

            this.rdbAllow.Checked = this.rdbDeny.Checked = false;

            this.chkChangePermissions.Checked = false;
            this.chkCreateFilesWriteData.Checked = false;
            this.chkCreateFoldersAppendData.Checked = false;
            this.chkDelete.Checked = false;
            this.chkDeleteSubfoldersAndFiles.Checked = false;
            this.chkFullControl.Checked = false;
            this.chkListFolderReadData.Checked = false;
            this.chkReadAttributes.Checked = false;
            this.chkReadExtendedAttributes.Checked = false;
            this.chkReadPermissions.Checked = false;
            this.chkTakeOwnership.Checked = false;
            this.chkTraverseFolderExecuteFile.Checked = false;
            this.chkWriteAttributes.Checked = false;
            this.chkWriteExtendedAttributes.Checked = false;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            #region validations
            if(txtPath.Text == "")
            {
                errorMessage("Define path");
                return;
            }
            if (txtWho.Text == "")
            {
                errorMessage("Define who");
                return;
            }
            if (rdbAllow.Checked == false && rdbDeny.Checked == false)
            {
                errorMessage("Define type");
                return;
            }
            if (cbbLevel.Text == "" || cbbLevel.Text == "Select")
            {
                errorMessage("Define level");
                return;
            }
            #endregion  

            executed = true;

            aclSetting.ForWho = this.txtWho.Text;
            aclSetting.PermissionType = this.rdbAllow.Checked;
            aclSetting.Path = this.txtPath.Text;
            aclSetting.PermissionLevel = this.cbbLevel.SelectedItem.ToString();

            aclSetting.ChangePermissions = this.chkChangePermissions.Checked;
            aclSetting.CreateFilesWriteData = this.chkCreateFilesWriteData.Checked;
            aclSetting.CreateFoldersAppendData = this.chkCreateFoldersAppendData.Checked;
            aclSetting.Delete = this.chkDelete.Checked;
            aclSetting.DeleteSubfoldersAndFiles = this.chkDeleteSubfoldersAndFiles.Checked;
            aclSetting.FullControl = this.chkFullControl.Checked;
            aclSetting.ListFolderReadData = this.chkListFolderReadData.Checked;
            aclSetting.ReadAttributes = this.chkReadAttributes.Checked;
            aclSetting.ReadExtendedAttributes = this.chkReadExtendedAttributes.Checked;
            aclSetting.ReadPermissions = this.chkReadPermissions.Checked;
            aclSetting.TakeOwnership = this.chkTakeOwnership.Checked;
            aclSetting.TraverseFolderExecuteFile = this.chkTraverseFolderExecuteFile.Checked;
            aclSetting.WriteAttributes = this.chkWriteAttributes.Checked;
            aclSetting.WriteExtendedAttributes = this.chkWriteExtendedAttributes.Checked;

            this.Close();
        }

        private void errorMessage(string text)
        {
            MessageBox.Show(text, "Validation Error");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Sure?", "Deleting...", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            delete = true;
            executed = true;
            this.Close();
        }
    }
}
