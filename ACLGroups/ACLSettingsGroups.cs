﻿using PowerShellACLDocuments.ActionForms;
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
            lblAclName.Text = "";
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
            lblAclName.Text = aclGroup.Name;
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

            if (aclGroupForm.deleted)
            {
                this.package.ACLSettingsGroups.RemoveAt(latestUpdated);
                renderGroups();
                return;
            }

            this.package.ACLSettingsGroups[latestUpdated] = aclGroupForm.aclGroup;
            renderGroups();
        }


        #endregion

        #region actions

        public void renderActions()
        {
            clearAllExcept(pnlExistingActions, new string[] { "btnActionBase", "aclButtons" });

            foreach (var item in latestACLGroup.Settings)
            {
                Button newBtn = btnCopier.copyModelObject(item.ToString(), btnActionBase, pnlExistingActions);
                // missing: handler
                newBtn.Click += (sender, e) => editAction_Click(sender, e, item);
                pnlExistingActions.Controls.Add(newBtn);
            }
        }

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
                return;
            }
            if (aclForm.delete)
            {
                this.latestACLGroup.Settings.RemoveAt(latestACL);
                renderActions();
                return;
            }

            latestACLGroup.Settings[latestACL] = aclForm.aclSetting;

            if (aclForm.moveToPosition.HasValue)
            {
                latestACLGroup.Settings.RemoveAt(latestACL);
                latestACLGroup.Settings.Insert(aclForm.moveToPosition.Value, aclForm.aclSetting);
            }
            renderActions();
        }

        private void aclButtonNewACL_Click(object sender, EventArgs e)
        {
            this.latestACL = -1;
            aclForm.initialize(null, latestACLGroup.Settings.Count, latestACL);
            aclForm.Show();
            this.Hide();
        }

        private void editAction_Click(object sender, EventArgs e, ACLSetting action)
        {
            this.latestACL = latestACLGroup.Settings.IndexOf(action);

            if (action is ACLSetting)
            {
                this.aclForm.initialize(action as ACLSetting, latestACLGroup.Settings != null ? latestACLGroup.Settings.Count : 0, latestACL);
                this.aclForm.Show();
                this.Hide();
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
