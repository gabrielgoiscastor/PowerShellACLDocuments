namespace PowerShellACLDocuments.ActionForms
{
    partial class ACLForm
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
            this.chkFullControl = new System.Windows.Forms.CheckBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.lblPermissionLevel = new System.Windows.Forms.Label();
            this.cbbLevel = new System.Windows.Forms.ComboBox();
            this.rdbAllow = new System.Windows.Forms.RadioButton();
            this.rdbDeny = new System.Windows.Forms.RadioButton();
            this.chkTraverseFolderExecuteFile = new System.Windows.Forms.CheckBox();
            this.chkListFolderReadData = new System.Windows.Forms.CheckBox();
            this.chkReadAttributes = new System.Windows.Forms.CheckBox();
            this.chkReadExtendedAttributes = new System.Windows.Forms.CheckBox();
            this.chkCreateFilesWriteData = new System.Windows.Forms.CheckBox();
            this.chkCreateFoldersAppendData = new System.Windows.Forms.CheckBox();
            this.chkWriteAttributes = new System.Windows.Forms.CheckBox();
            this.chkWriteExtendedAttributes = new System.Windows.Forms.CheckBox();
            this.chkDeleteSubfoldersAndFiles = new System.Windows.Forms.CheckBox();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.chkReadPermissions = new System.Windows.Forms.CheckBox();
            this.chkChangePermissions = new System.Windows.Forms.CheckBox();
            this.chkTakeOwnership = new System.Windows.Forms.CheckBox();
            this.txtWho = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPermissions = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblRealPath = new System.Windows.Forms.Label();
            this.lblMovePosition = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.pnlPermissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkFullControl
            // 
            this.chkFullControl.AutoSize = true;
            this.chkFullControl.Location = new System.Drawing.Point(15, 28);
            this.chkFullControl.Name = "chkFullControl";
            this.chkFullControl.Size = new System.Drawing.Size(78, 17);
            this.chkFullControl.TabIndex = 6;
            this.chkFullControl.Text = "Full Control";
            this.chkFullControl.UseVisualStyleBackColor = true;
            this.chkFullControl.Click += new System.EventHandler(this.chkFullControl_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnComplete.Location = new System.Drawing.Point(264, 414);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(141, 43);
            this.btnComplete.TabIndex = 20;
            this.btnComplete.Text = "Apply and Close";
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // lblPermissionLevel
            // 
            this.lblPermissionLevel.AutoSize = true;
            this.lblPermissionLevel.Location = new System.Drawing.Point(12, 102);
            this.lblPermissionLevel.Name = "lblPermissionLevel";
            this.lblPermissionLevel.Size = new System.Drawing.Size(33, 13);
            this.lblPermissionLevel.TabIndex = 4;
            this.lblPermissionLevel.Text = "Level";
            // 
            // cbbLevel
            // 
            this.cbbLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLevel.FormattingEnabled = true;
            this.cbbLevel.ItemHeight = 13;
            this.cbbLevel.Items.AddRange(new object[] {
            "Select",
            "This folder only",
            "This folder, subfolder and files",
            "This folder and subfolders",
            "This folder and files",
            "Subfolders and files only",
            "Subfolders only",
            "Files only"});
            this.cbbLevel.Location = new System.Drawing.Point(88, 99);
            this.cbbLevel.Name = "cbbLevel";
            this.cbbLevel.Size = new System.Drawing.Size(317, 21);
            this.cbbLevel.TabIndex = 4;
            // 
            // rdbAllow
            // 
            this.rdbAllow.AutoSize = true;
            this.rdbAllow.Location = new System.Drawing.Point(4, 3);
            this.rdbAllow.Name = "rdbAllow";
            this.rdbAllow.Size = new System.Drawing.Size(50, 17);
            this.rdbAllow.TabIndex = 3;
            this.rdbAllow.TabStop = true;
            this.rdbAllow.Text = "Allow";
            this.rdbAllow.UseVisualStyleBackColor = true;
            // 
            // rdbDeny
            // 
            this.rdbDeny.AutoSize = true;
            this.rdbDeny.Location = new System.Drawing.Point(60, 3);
            this.rdbDeny.Name = "rdbDeny";
            this.rdbDeny.Size = new System.Drawing.Size(50, 17);
            this.rdbDeny.TabIndex = 4;
            this.rdbDeny.TabStop = true;
            this.rdbDeny.Text = "Deny";
            this.rdbDeny.UseVisualStyleBackColor = true;
            // 
            // chkTraverseFolderExecuteFile
            // 
            this.chkTraverseFolderExecuteFile.AutoSize = true;
            this.chkTraverseFolderExecuteFile.Location = new System.Drawing.Point(15, 51);
            this.chkTraverseFolderExecuteFile.Name = "chkTraverseFolderExecuteFile";
            this.chkTraverseFolderExecuteFile.Size = new System.Drawing.Size(169, 17);
            this.chkTraverseFolderExecuteFile.TabIndex = 7;
            this.chkTraverseFolderExecuteFile.Text = "Traverse Folder / Execute File";
            this.chkTraverseFolderExecuteFile.UseVisualStyleBackColor = true;
            this.chkTraverseFolderExecuteFile.Click += new System.EventHandler(this.chkOthers_Click);
            // 
            // chkListFolderReadData
            // 
            this.chkListFolderReadData.AutoSize = true;
            this.chkListFolderReadData.Location = new System.Drawing.Point(15, 74);
            this.chkListFolderReadData.Name = "chkListFolderReadData";
            this.chkListFolderReadData.Size = new System.Drawing.Size(137, 17);
            this.chkListFolderReadData.TabIndex = 8;
            this.chkListFolderReadData.Text = "List Folder / Read Data";
            this.chkListFolderReadData.UseVisualStyleBackColor = true;
            this.chkListFolderReadData.Click += new System.EventHandler(this.chkOthers_Click);
            // 
            // chkReadAttributes
            // 
            this.chkReadAttributes.AutoSize = true;
            this.chkReadAttributes.Location = new System.Drawing.Point(15, 97);
            this.chkReadAttributes.Name = "chkReadAttributes";
            this.chkReadAttributes.Size = new System.Drawing.Size(99, 17);
            this.chkReadAttributes.TabIndex = 9;
            this.chkReadAttributes.Text = "Read Attributes";
            this.chkReadAttributes.UseVisualStyleBackColor = true;
            this.chkReadAttributes.Click += new System.EventHandler(this.chkOthers_Click);
            // 
            // chkReadExtendedAttributes
            // 
            this.chkReadExtendedAttributes.AutoSize = true;
            this.chkReadExtendedAttributes.Location = new System.Drawing.Point(15, 120);
            this.chkReadExtendedAttributes.Name = "chkReadExtendedAttributes";
            this.chkReadExtendedAttributes.Size = new System.Drawing.Size(147, 17);
            this.chkReadExtendedAttributes.TabIndex = 10;
            this.chkReadExtendedAttributes.Text = "Read Extended Attributes";
            this.chkReadExtendedAttributes.UseVisualStyleBackColor = true;
            this.chkReadExtendedAttributes.Click += new System.EventHandler(this.chkOthers_Click);
            // 
            // chkCreateFilesWriteData
            // 
            this.chkCreateFilesWriteData.AutoSize = true;
            this.chkCreateFilesWriteData.Location = new System.Drawing.Point(15, 143);
            this.chkCreateFilesWriteData.Name = "chkCreateFilesWriteData";
            this.chkCreateFilesWriteData.Size = new System.Drawing.Size(143, 17);
            this.chkCreateFilesWriteData.TabIndex = 11;
            this.chkCreateFilesWriteData.Text = "Create Files / Write Data";
            this.chkCreateFilesWriteData.UseVisualStyleBackColor = true;
            this.chkCreateFilesWriteData.Click += new System.EventHandler(this.chkOthers_Click);
            // 
            // chkCreateFoldersAppendData
            // 
            this.chkCreateFoldersAppendData.AutoSize = true;
            this.chkCreateFoldersAppendData.Location = new System.Drawing.Point(15, 166);
            this.chkCreateFoldersAppendData.Name = "chkCreateFoldersAppendData";
            this.chkCreateFoldersAppendData.Size = new System.Drawing.Size(168, 17);
            this.chkCreateFoldersAppendData.TabIndex = 12;
            this.chkCreateFoldersAppendData.Text = "Create Folders / Append Data";
            this.chkCreateFoldersAppendData.UseVisualStyleBackColor = true;
            this.chkCreateFoldersAppendData.Click += new System.EventHandler(this.chkOthers_Click);
            // 
            // chkWriteAttributes
            // 
            this.chkWriteAttributes.AutoSize = true;
            this.chkWriteAttributes.Location = new System.Drawing.Point(228, 28);
            this.chkWriteAttributes.Name = "chkWriteAttributes";
            this.chkWriteAttributes.Size = new System.Drawing.Size(98, 17);
            this.chkWriteAttributes.TabIndex = 13;
            this.chkWriteAttributes.Text = "Write Attributes";
            this.chkWriteAttributes.UseVisualStyleBackColor = true;
            this.chkWriteAttributes.Click += new System.EventHandler(this.chkOthers_Click);
            // 
            // chkWriteExtendedAttributes
            // 
            this.chkWriteExtendedAttributes.AutoSize = true;
            this.chkWriteExtendedAttributes.Location = new System.Drawing.Point(228, 51);
            this.chkWriteExtendedAttributes.Name = "chkWriteExtendedAttributes";
            this.chkWriteExtendedAttributes.Size = new System.Drawing.Size(146, 17);
            this.chkWriteExtendedAttributes.TabIndex = 14;
            this.chkWriteExtendedAttributes.Text = "Write Extended Attributes";
            this.chkWriteExtendedAttributes.UseVisualStyleBackColor = true;
            this.chkWriteExtendedAttributes.Click += new System.EventHandler(this.chkOthers_Click);
            // 
            // chkDeleteSubfoldersAndFiles
            // 
            this.chkDeleteSubfoldersAndFiles.AutoSize = true;
            this.chkDeleteSubfoldersAndFiles.Location = new System.Drawing.Point(228, 74);
            this.chkDeleteSubfoldersAndFiles.Name = "chkDeleteSubfoldersAndFiles";
            this.chkDeleteSubfoldersAndFiles.Size = new System.Drawing.Size(156, 17);
            this.chkDeleteSubfoldersAndFiles.TabIndex = 15;
            this.chkDeleteSubfoldersAndFiles.Text = "Delete Subfolders And Files";
            this.chkDeleteSubfoldersAndFiles.UseVisualStyleBackColor = true;
            this.chkDeleteSubfoldersAndFiles.Click += new System.EventHandler(this.chkOthers_Click);
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(228, 97);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(57, 17);
            this.chkDelete.TabIndex = 16;
            this.chkDelete.Text = "Delete";
            this.chkDelete.UseVisualStyleBackColor = true;
            this.chkDelete.Click += new System.EventHandler(this.chkOthers_Click);
            // 
            // chkReadPermissions
            // 
            this.chkReadPermissions.AutoSize = true;
            this.chkReadPermissions.Location = new System.Drawing.Point(228, 120);
            this.chkReadPermissions.Name = "chkReadPermissions";
            this.chkReadPermissions.Size = new System.Drawing.Size(110, 17);
            this.chkReadPermissions.TabIndex = 17;
            this.chkReadPermissions.Text = "Read Permissions";
            this.chkReadPermissions.UseVisualStyleBackColor = true;
            this.chkReadPermissions.Click += new System.EventHandler(this.chkOthers_Click);
            // 
            // chkChangePermissions
            // 
            this.chkChangePermissions.AutoSize = true;
            this.chkChangePermissions.Location = new System.Drawing.Point(228, 143);
            this.chkChangePermissions.Name = "chkChangePermissions";
            this.chkChangePermissions.Size = new System.Drawing.Size(121, 17);
            this.chkChangePermissions.TabIndex = 18;
            this.chkChangePermissions.Text = "Change Permissions";
            this.chkChangePermissions.UseVisualStyleBackColor = true;
            this.chkChangePermissions.Click += new System.EventHandler(this.chkOthers_Click);
            // 
            // chkTakeOwnership
            // 
            this.chkTakeOwnership.AutoSize = true;
            this.chkTakeOwnership.Location = new System.Drawing.Point(228, 166);
            this.chkTakeOwnership.Name = "chkTakeOwnership";
            this.chkTakeOwnership.Size = new System.Drawing.Size(104, 17);
            this.chkTakeOwnership.TabIndex = 19;
            this.chkTakeOwnership.Text = "Take Ownership";
            this.chkTakeOwnership.UseVisualStyleBackColor = true;
            this.chkTakeOwnership.Click += new System.EventHandler(this.chkOthers_Click);
            // 
            // txtWho
            // 
            this.txtWho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWho.Location = new System.Drawing.Point(88, 41);
            this.txtWho.Name = "txtWho";
            this.txtWho.Size = new System.Drawing.Size(317, 20);
            this.txtWho.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 44);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(49, 13);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "To who?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Type";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbAllow);
            this.panel1.Controls.Add(this.rdbDeny);
            this.panel1.Location = new System.Drawing.Point(88, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 25);
            this.panel1.TabIndex = 3;
            // 
            // pnlPermissions
            // 
            this.pnlPermissions.Controls.Add(this.chkFullControl);
            this.pnlPermissions.Controls.Add(this.chkTraverseFolderExecuteFile);
            this.pnlPermissions.Controls.Add(this.chkListFolderReadData);
            this.pnlPermissions.Controls.Add(this.chkReadAttributes);
            this.pnlPermissions.Controls.Add(this.chkReadExtendedAttributes);
            this.pnlPermissions.Controls.Add(this.chkTakeOwnership);
            this.pnlPermissions.Controls.Add(this.chkCreateFilesWriteData);
            this.pnlPermissions.Controls.Add(this.chkChangePermissions);
            this.pnlPermissions.Controls.Add(this.chkCreateFoldersAppendData);
            this.pnlPermissions.Controls.Add(this.chkReadPermissions);
            this.pnlPermissions.Controls.Add(this.chkWriteAttributes);
            this.pnlPermissions.Controls.Add(this.chkDelete);
            this.pnlPermissions.Controls.Add(this.chkWriteExtendedAttributes);
            this.pnlPermissions.Controls.Add(this.chkDeleteSubfoldersAndFiles);
            this.pnlPermissions.Location = new System.Drawing.Point(15, 141);
            this.pnlPermissions.Name = "pnlPermissions";
            this.pnlPermissions.Size = new System.Drawing.Size(390, 201);
            this.pnlPermissions.TabIndex = 5;
            this.pnlPermissions.TabStop = false;
            this.pnlPermissions.Text = "Permissions";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(15, 414);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 43);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete action";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 15);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 13);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Path";
            // 
            // lblRealPath
            // 
            this.lblRealPath.AutoSize = true;
            this.lblRealPath.Location = new System.Drawing.Point(89, 15);
            this.lblRealPath.Name = "lblRealPath";
            this.lblRealPath.Size = new System.Drawing.Size(29, 13);
            this.lblRealPath.TabIndex = 25;
            this.lblRealPath.Text = "Path";
            // 
            // lblMovePosition
            // 
            this.lblMovePosition.AutoSize = true;
            this.lblMovePosition.Location = new System.Drawing.Point(12, 354);
            this.lblMovePosition.Name = "lblMovePosition";
            this.lblMovePosition.Size = new System.Drawing.Size(44, 13);
            this.lblMovePosition.TabIndex = 26;
            this.lblMovePosition.Text = "Position";
            // 
            // cbPosition
            // 
            this.cbPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.ItemHeight = 13;
            this.cbPosition.Location = new System.Drawing.Point(88, 351);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(317, 21);
            this.cbPosition.TabIndex = 27;
            // 
            // ACLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 469);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.lblMovePosition);
            this.Controls.Add(this.lblRealPath);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlPermissions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWho);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cbbLevel);
            this.Controls.Add(this.lblPermissionLevel);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnComplete);
            this.Name = "ACLForm";
            this.Text = "ACLForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPermissions.ResumeLayout(false);
            this.pnlPermissions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkFullControl;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label lblPermissionLevel;
        private System.Windows.Forms.ComboBox cbbLevel;
        private System.Windows.Forms.RadioButton rdbAllow;
        private System.Windows.Forms.RadioButton rdbDeny;
        private System.Windows.Forms.CheckBox chkTraverseFolderExecuteFile;
        private System.Windows.Forms.CheckBox chkListFolderReadData;
        private System.Windows.Forms.CheckBox chkReadAttributes;
        private System.Windows.Forms.CheckBox chkReadExtendedAttributes;
        private System.Windows.Forms.CheckBox chkCreateFilesWriteData;
        private System.Windows.Forms.CheckBox chkCreateFoldersAppendData;
        private System.Windows.Forms.CheckBox chkWriteAttributes;
        private System.Windows.Forms.CheckBox chkWriteExtendedAttributes;
        private System.Windows.Forms.CheckBox chkDeleteSubfoldersAndFiles;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.CheckBox chkReadPermissions;
        private System.Windows.Forms.CheckBox chkChangePermissions;
        private System.Windows.Forms.CheckBox chkTakeOwnership;
        private System.Windows.Forms.TextBox txtWho;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox pnlPermissions;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblRealPath;
        private System.Windows.Forms.Label lblMovePosition;
        private System.Windows.Forms.ComboBox cbPosition;
    }
}