namespace PowerShellACLDocuments
{
    partial class ACLSettingsGroups
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACLSettingsGroups));
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnActionBase = new System.Windows.Forms.Button();
            this.aclButtons = new System.Windows.Forms.ToolStrip();
            this.aclButtonNewACL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aclButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.pnlGroupACL = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBaseACLGroup = new System.Windows.Forms.Button();
            this.btnNewAclGroup = new System.Windows.Forms.Button();
            this.lblAclName = new System.Windows.Forms.Label();
            this.pnlExistingActions = new System.Windows.Forms.Panel();
            this.pnlActions.SuspendLayout();
            this.aclButtons.SuspendLayout();
            this.pnlGroupACL.SuspendLayout();
            this.pnlExistingActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlActions
            // 
            this.pnlActions.AutoScroll = true;
            this.pnlActions.Controls.Add(this.pnlExistingActions);
            this.pnlActions.Controls.Add(this.aclButtons);
            this.pnlActions.Enabled = false;
            this.pnlActions.Location = new System.Drawing.Point(218, 41);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(504, 317);
            this.pnlActions.TabIndex = 0;
            // 
            // btnActionBase
            // 
            this.btnActionBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActionBase.BackColor = System.Drawing.SystemColors.Control;
            this.btnActionBase.Location = new System.Drawing.Point(3, 3);
            this.btnActionBase.Name = "btnActionBase";
            this.btnActionBase.Size = new System.Drawing.Size(491, 41);
            this.btnActionBase.TabIndex = 1;
            this.btnActionBase.Text = "Action";
            this.btnActionBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActionBase.UseVisualStyleBackColor = false;
            // 
            // aclButtons
            // 
            this.aclButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aclButtonNewACL,
            this.toolStripSeparator1,
            this.aclButtonEdit});
            this.aclButtons.Location = new System.Drawing.Point(0, 0);
            this.aclButtons.Name = "aclButtons";
            this.aclButtons.Size = new System.Drawing.Size(504, 25);
            this.aclButtons.TabIndex = 0;
            this.aclButtons.Text = "toolStrip1";
            // 
            // aclButtonNewACL
            // 
            this.aclButtonNewACL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aclButtonNewACL.Image = ((System.Drawing.Image)(resources.GetObject("aclButtonNewACL.Image")));
            this.aclButtonNewACL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aclButtonNewACL.Name = "aclButtonNewACL";
            this.aclButtonNewACL.Size = new System.Drawing.Size(60, 22);
            this.aclButtonNewACL.Text = "New ACL";
            this.aclButtonNewACL.Click += new System.EventHandler(this.aclButtonNewACL_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // aclButtonEdit
            // 
            this.aclButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aclButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("aclButtonEdit.Image")));
            this.aclButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aclButtonEdit.Name = "aclButtonEdit";
            this.aclButtonEdit.Size = new System.Drawing.Size(92, 22);
            this.aclButtonEdit.Text = "Edit ACL Group";
            this.aclButtonEdit.Click += new System.EventHandler(this.aclGroupEdit_Click);
            // 
            // pnlGroupACL
            // 
            this.pnlGroupACL.Controls.Add(this.btnBaseACLGroup);
            this.pnlGroupACL.Location = new System.Drawing.Point(12, 41);
            this.pnlGroupACL.Name = "pnlGroupACL";
            this.pnlGroupACL.Size = new System.Drawing.Size(200, 317);
            this.pnlGroupACL.TabIndex = 1;
            // 
            // btnBaseACLGroup
            // 
            this.btnBaseACLGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaseACLGroup.BackColor = System.Drawing.SystemColors.Control;
            this.btnBaseACLGroup.Location = new System.Drawing.Point(3, 3);
            this.btnBaseACLGroup.Name = "btnBaseACLGroup";
            this.btnBaseACLGroup.Size = new System.Drawing.Size(195, 41);
            this.btnBaseACLGroup.TabIndex = 2;
            this.btnBaseACLGroup.Text = "Group Name";
            this.btnBaseACLGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaseACLGroup.UseVisualStyleBackColor = false;
            // 
            // btnNewAclGroup
            // 
            this.btnNewAclGroup.Location = new System.Drawing.Point(12, 12);
            this.btnNewAclGroup.Name = "btnNewAclGroup";
            this.btnNewAclGroup.Size = new System.Drawing.Size(200, 23);
            this.btnNewAclGroup.TabIndex = 1;
            this.btnNewAclGroup.Text = "New ACL Group";
            this.btnNewAclGroup.UseVisualStyleBackColor = true;
            this.btnNewAclGroup.Click += new System.EventHandler(this.btnNewAclGroup_Click);
            // 
            // lblAclName
            // 
            this.lblAclName.AutoSize = true;
            this.lblAclName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblAclName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAclName.Location = new System.Drawing.Point(224, 12);
            this.lblAclName.Name = "lblAclName";
            this.lblAclName.Size = new System.Drawing.Size(40, 20);
            this.lblAclName.TabIndex = 2;
            this.lblAclName.Text = "ACL";
            // 
            // pnlExistingActions
            // 
            this.pnlExistingActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlExistingActions.Controls.Add(this.btnActionBase);
            this.pnlExistingActions.Location = new System.Drawing.Point(4, 28);
            this.pnlExistingActions.Name = "pnlExistingActions";
            this.pnlExistingActions.Size = new System.Drawing.Size(497, 286);
            this.pnlExistingActions.TabIndex = 2;
            // 
            // ACLSettingsGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 370);
            this.Controls.Add(this.lblAclName);
            this.Controls.Add(this.btnNewAclGroup);
            this.Controls.Add(this.pnlGroupACL);
            this.Controls.Add(this.pnlActions);
            this.Name = "ACLSettingsGroups";
            this.Text = "ACLSettingsGroups";
            this.VisibleChanged += new System.EventHandler(this.ACLSettingsGroups_VisibleChanged);
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.aclButtons.ResumeLayout(false);
            this.aclButtons.PerformLayout();
            this.pnlGroupACL.ResumeLayout(false);
            this.pnlExistingActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.ToolStrip aclButtons;
        private System.Windows.Forms.FlowLayoutPanel pnlGroupACL;
        private System.Windows.Forms.ToolStripButton aclButtonNewACL;
        private System.Windows.Forms.Button btnNewAclGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton aclButtonEdit;
        private System.Windows.Forms.Label lblAclName;
        private System.Windows.Forms.Button btnActionBase;
        private System.Windows.Forms.Button btnBaseACLGroup;
        private System.Windows.Forms.Panel pnlExistingActions;
    }
}