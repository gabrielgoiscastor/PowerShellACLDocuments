namespace PowerShellACLDocuments
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFromExistingFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btnActionBase = new System.Windows.Forms.Button();
            this.btnInputBase = new System.Windows.Forms.Button();
            this.actionsStrip = new System.Windows.Forms.ToolStrip();
            this.toolBtnNewACL = new System.Windows.Forms.ToolStripButton();
            this.toolBtnNewFileCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnNewInput = new System.Windows.Forms.ToolStripButton();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBasePath = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnGeneratePS = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.foldersTree = new System.Windows.Forms.TreeView();
            this.lblFolders = new System.Windows.Forms.Label();
            this.lblConfigsFor = new System.Windows.Forms.Label();
            this.btnClearSelection = new System.Windows.Forms.Button();
            this.btnDeleteFolder = new System.Windows.Forms.Button();
            this.btnNewFolder = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnExpandCollapse = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.actionsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(895, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFromExistingFolderToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // newFromExistingFolderToolStripMenuItem
            // 
            this.newFromExistingFolderToolStripMenuItem.Name = "newFromExistingFolderToolStripMenuItem";
            this.newFromExistingFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newFromExistingFolderToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.newFromExistingFolderToolStripMenuItem.Text = "New from existing folder";
            this.newFromExistingFolderToolStripMenuItem.Click += new System.EventHandler(this.newFromExistingFolderToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.splitContainer);
            this.panel1.Controls.Add(this.actionsStrip);
            this.panel1.Location = new System.Drawing.Point(312, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 345);
            this.panel1.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 25);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.AutoScroll = true;
            this.splitContainer.Panel1.Controls.Add(this.btnActionBase);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.AutoScroll = true;
            this.splitContainer.Panel2.Controls.Add(this.btnInputBase);
            this.splitContainer.Size = new System.Drawing.Size(571, 320);
            this.splitContainer.SplitterDistance = 390;
            this.splitContainer.TabIndex = 3;
            // 
            // btnActionBase
            // 
            this.btnActionBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActionBase.BackColor = System.Drawing.SystemColors.Control;
            this.btnActionBase.Location = new System.Drawing.Point(3, 3);
            this.btnActionBase.Name = "btnActionBase";
            this.btnActionBase.Size = new System.Drawing.Size(384, 41);
            this.btnActionBase.TabIndex = 0;
            this.btnActionBase.Text = "Action";
            this.btnActionBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActionBase.UseVisualStyleBackColor = false;
            // 
            // btnInputBase
            // 
            this.btnInputBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInputBase.BackColor = System.Drawing.SystemColors.Control;
            this.btnInputBase.Location = new System.Drawing.Point(3, 3);
            this.btnInputBase.Name = "btnInputBase";
            this.btnInputBase.Size = new System.Drawing.Size(171, 41);
            this.btnInputBase.TabIndex = 1;
            this.btnInputBase.Text = "Input";
            this.btnInputBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInputBase.UseVisualStyleBackColor = false;
            // 
            // actionsStrip
            // 
            this.actionsStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.actionsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnNewACL,
            this.toolBtnNewFileCopy,
            this.toolStripSeparator1,
            this.toolBtnNewInput});
            this.actionsStrip.Location = new System.Drawing.Point(0, 0);
            this.actionsStrip.Name = "actionsStrip";
            this.actionsStrip.Size = new System.Drawing.Size(571, 25);
            this.actionsStrip.TabIndex = 2;
            this.actionsStrip.Text = "toolStrip1";
            // 
            // toolBtnNewACL
            // 
            this.toolBtnNewACL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnNewACL.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnNewACL.Image")));
            this.toolBtnNewACL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnNewACL.Name = "toolBtnNewACL";
            this.toolBtnNewACL.Size = new System.Drawing.Size(98, 22);
            this.toolBtnNewACL.Text = "New ACL Action";
            this.toolBtnNewACL.Click += new System.EventHandler(this.toolBtnNewACL_Click);
            // 
            // toolBtnNewFileCopy
            // 
            this.toolBtnNewFileCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnNewFileCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnNewFileCopy.Image")));
            this.toolBtnNewFileCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnNewFileCopy.Name = "toolBtnNewFileCopy";
            this.toolBtnNewFileCopy.Size = new System.Drawing.Size(125, 22);
            this.toolBtnNewFileCopy.Text = "New File Copy Action";
            this.toolBtnNewFileCopy.Click += new System.EventHandler(this.toolBtnNewFileCopy_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnNewInput
            // 
            this.toolBtnNewInput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnNewInput.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnNewInput.Image")));
            this.toolBtnNewInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnNewInput.Name = "toolBtnNewInput";
            this.toolBtnNewInput.Size = new System.Drawing.Size(66, 22);
            this.toolBtnNewInput.Text = "New Input";
            this.toolBtnNewInput.Click += new System.EventHandler(this.toolBtnNewInput_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Project Name";
            // 
            // lblBasePath
            // 
            this.lblBasePath.AutoSize = true;
            this.lblBasePath.Location = new System.Drawing.Point(12, 68);
            this.lblBasePath.Name = "lblBasePath";
            this.lblBasePath.Size = new System.Drawing.Size(56, 13);
            this.lblBasePath.TabIndex = 3;
            this.lblBasePath.Text = "Base Path";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(92, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(791, 20);
            this.txtName.TabIndex = 4;
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBox_TextChanged);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(92, 65);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(791, 20);
            this.txtPath.TabIndex = 5;
            this.txtPath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBox_TextChanged);
            this.txtPath.Leave += new System.EventHandler(this.txtPath_Leave);
            // 
            // btnGeneratePS
            // 
            this.btnGeneratePS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneratePS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGeneratePS.Location = new System.Drawing.Point(708, 474);
            this.btnGeneratePS.Name = "btnGeneratePS";
            this.btnGeneratePS.Size = new System.Drawing.Size(175, 40);
            this.btnGeneratePS.TabIndex = 6;
            this.btnGeneratePS.Text = "Generate PowerShell Script";
            this.btnGeneratePS.UseVisualStyleBackColor = false;
            this.btnGeneratePS.Click += new System.EventHandler(this.btnGeneratePS_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "*.json";
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "json";
            this.saveFileDialog.RestoreDirectory = true;
            this.saveFileDialog.Title = "Save PS configuration";
            // 
            // foldersTree
            // 
            this.foldersTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.foldersTree.HotTracking = true;
            this.foldersTree.Location = new System.Drawing.Point(15, 148);
            this.foldersTree.Name = "foldersTree";
            this.foldersTree.Size = new System.Drawing.Size(291, 320);
            this.foldersTree.TabIndex = 7;
            this.foldersTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.foldersTree_AfterSelect);
            // 
            // lblFolders
            // 
            this.lblFolders.AutoSize = true;
            this.lblFolders.Location = new System.Drawing.Point(12, 102);
            this.lblFolders.Name = "lblFolders";
            this.lblFolders.Size = new System.Drawing.Size(65, 13);
            this.lblFolders.TabIndex = 8;
            this.lblFolders.Text = "Folder setup";
            // 
            // lblConfigsFor
            // 
            this.lblConfigsFor.AutoSize = true;
            this.lblConfigsFor.Location = new System.Drawing.Point(309, 102);
            this.lblConfigsFor.Name = "lblConfigsFor";
            this.lblConfigsFor.Size = new System.Drawing.Size(84, 13);
            this.lblConfigsFor.TabIndex = 9;
            this.lblConfigsFor.Text = "Configuration for";
            // 
            // btnClearSelection
            // 
            this.btnClearSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearSelection.Location = new System.Drawing.Point(15, 474);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new System.Drawing.Size(144, 40);
            this.btnClearSelection.TabIndex = 10;
            this.btnClearSelection.Text = "Clear Selection";
            this.btnClearSelection.UseVisualStyleBackColor = true;
            this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click);
            // 
            // btnDeleteFolder
            // 
            this.btnDeleteFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteFolder.Location = new System.Drawing.Point(165, 474);
            this.btnDeleteFolder.Name = "btnDeleteFolder";
            this.btnDeleteFolder.Size = new System.Drawing.Size(141, 40);
            this.btnDeleteFolder.TabIndex = 11;
            this.btnDeleteFolder.Text = "Delete folder";
            this.btnDeleteFolder.UseVisualStyleBackColor = false;
            this.btnDeleteFolder.Click += new System.EventHandler(this.btnDeleteFolder_Click);
            // 
            // btnNewFolder
            // 
            this.btnNewFolder.Location = new System.Drawing.Point(15, 123);
            this.btnNewFolder.Name = "btnNewFolder";
            this.btnNewFolder.Size = new System.Drawing.Size(144, 23);
            this.btnNewFolder.TabIndex = 12;
            this.btnNewFolder.Text = "+ New Folder";
            this.btnNewFolder.UseVisualStyleBackColor = true;
            this.btnNewFolder.Click += new System.EventHandler(this.btnNewFolder_Click);
            // 
            // folderDialog
            // 
            this.folderDialog.CheckFileExists = false;
            this.folderDialog.FileName = "Select a folder";
            this.folderDialog.ValidateNames = false;
            // 
            // btnExpandCollapse
            // 
            this.btnExpandCollapse.Location = new System.Drawing.Point(165, 123);
            this.btnExpandCollapse.Name = "btnExpandCollapse";
            this.btnExpandCollapse.Size = new System.Drawing.Size(141, 23);
            this.btnExpandCollapse.TabIndex = 13;
            this.btnExpandCollapse.Text = "Expand/Collapse all";
            this.btnExpandCollapse.UseVisualStyleBackColor = true;
            this.btnExpandCollapse.Click += new System.EventHandler(this.btnExpandCollapse_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 526);
            this.Controls.Add(this.btnExpandCollapse);
            this.Controls.Add(this.btnNewFolder);
            this.Controls.Add(this.btnDeleteFolder);
            this.Controls.Add(this.btnClearSelection);
            this.Controls.Add(this.lblConfigsFor);
            this.Controls.Add(this.lblFolders);
            this.Controls.Add(this.foldersTree);
            this.Controls.Add(this.btnGeneratePS);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblBasePath);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "Power Shell ACL Script Creator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.actionsStrip.ResumeLayout(false);
            this.actionsStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBasePath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ToolStrip actionsStrip;
        private System.Windows.Forms.ToolStripButton toolBtnNewInput;
        private System.Windows.Forms.ToolStripButton toolBtnNewFileCopy;
        private System.Windows.Forms.ToolStripButton toolBtnNewACL;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button btnGeneratePS;
        private System.Windows.Forms.Button btnActionBase;
        private System.Windows.Forms.Button btnInputBase;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TreeView foldersTree;
        private System.Windows.Forms.Label lblFolders;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblConfigsFor;
        private System.Windows.Forms.Button btnClearSelection;
        private System.Windows.Forms.Button btnDeleteFolder;
        private System.Windows.Forms.Button btnNewFolder;
        private System.Windows.Forms.ToolStripMenuItem newFromExistingFolderToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog folderDialog;
        private System.Windows.Forms.Button btnExpandCollapse;
    }
}