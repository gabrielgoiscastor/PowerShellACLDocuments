using PowerShellACLDocuments.ActionForms;
using PowerShellACLDocuments.DataModeling;
using PowerShellACLDocuments.FormSharedCode;
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
    public partial class ACLSettingsGroups : Form
    {
        ButtonCopier btnCopier = new ButtonCopier();
        public DataModeling.Package package;
        ACLGroups.ACLGroup aclGroupForm = new ACLGroups.ACLGroup();

        int latestUpdated = -1;
        ACLSettingsGroup latestACLGroup;

        int latestACL = -1;
        ACLForm aclForm = new ACLForm();

        public ACLSettingsGroups()
        {
            InitializeComponent();
            btnBaseACLGroup.Hide();
            btnActionBase.Hide();
            aclGroupForm.FormClosing += AclGroupForm_FormClosing;
            aclForm.FormClosing += AclForm_FormClosing;
        }

        private void ACLSettingsGroups_VisibleChanged(object sender, EventArgs e)
        {
            if(package != null)
            {
                renderGroups();
            }
        }

        #region groups
        private void renderGroups()
        {
            clearAllExcept(pnlGroupACL, new string[] { "btnBaseACLGroup" });
            if(package.ACLSettingsGroups == null || package.ACLSettingsGroups.Count == 0)
            {
                return;
            }

            foreach (var item in package.ACLSettingsGroups)
            {
                Button newBtn = this.btnCopier.copyModelObject(item.Name, btnBaseACLGroup, pnlGroupACL);
                newBtn.BackColor = item.Color;
                newBtn.Click += (sender, e) => aclGroup_Click(sender, e, item);
                this.pnlGroupACL.Controls.Add(newBtn);
            }
        }

        private void btnNewAclGroup_Click(object sender, EventArgs e)
        {
            latestUpdated = -1;
            aclGroupForm.initialize(null);
            this.Hide();
            aclGroupForm.Show();
        }

        private void aclGroup_Click(object sender, EventArgs e, ACLSettingsGroup aclGroup)
        {
            this.latestUpdated = package.ACLSettingsGroups.IndexOf(aclGroup);
            latestACLGroup = aclGroup;
            renderActions();
            pnlActions.Enabled = true;
        }

        private void aclGroupEdit_Click(object sender, EventArgs e)
        {
            this.aclGroupForm.initialize(latestACLGroup);
            this.aclGroupForm.Show();
            this.Hide();
        }

        private void AclGroupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Show();
            aclGroupForm.Hide();

            if(aclGroupForm.executed == false)
            {
                return;
            }

            // if executed and new
            if(latestUpdated == -1)
            {
                this.package.ACLSettingsGroups.Add(this.aclGroupForm.aclGroup);
                renderGroups();
                return;
            }
        }


        #endregion

        #region actions

        private void AclForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            aclForm.Hide();
            this.Show();
            this.Focus();

            if (aclForm.executed == false)
                return;

            if(latestACL == -1)
            {
                this.latestACLGroup.Settings.Add(aclForm.aclSetting);
                renderActions();
            }
        }

        private void aclButtonNewACL_Click(object sender, EventArgs e)
        {
            this.latestACL = -1;
            aclForm.initialize(null, latestACLGroup.Settings.Count, latestACL);
            aclForm.Show();
            this.Hide();
        }

        public void renderActions()
        {
            clearAllExcept(pnlExistingActions, new string[] { "btnActionBase", "aclButtons" });

            foreach (var item in latestACLGroup.Settings)
            {
                Button newBtn = btnCopier.copyModelObject(item.ToString(), btnActionBase, pnlExistingActions);
                // missing: handler
                pnlExistingActions.Controls.Add(newBtn);
            }
        }

        #endregion

        private void clearAllExcept(Panel panel, string[] except)
        {
            int countControls = panel.Controls.Count;
            for (int i = countControls-1; i >= 0; i--)
            {
                Control ctrl = panel.Controls[i];

                if(except.Contains(ctrl.Name))
                {
                    continue;
                }

                panel.Controls.Remove(ctrl);
            }
        }
    }
}
