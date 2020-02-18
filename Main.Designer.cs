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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBasePath = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.actionsStrip = new System.Windows.Forms.ToolStrip();
            this.toolBtnNewInput = new System.Windows.Forms.ToolStripButton();
            this.toolBtnNewFileCopy = new System.Windows.Forms.ToolStripButton();
            this.toolBtnNewACL = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnGeneratePS = new System.Windows.Forms.Button();
            this.btnInputBase = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.actionsStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1098, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuMain";
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
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.actionsStrip);
            this.panel1.Location = new System.Drawing.Point(12, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 535);
            this.panel1.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Settings name";
            // 
            // lblBasePath
            // 
            this.lblBasePath.AutoSize = true;
            this.lblBasePath.Location = new System.Drawing.Point(12, 63);
            this.lblBasePath.Name = "lblBasePath";
            this.lblBasePath.Size = new System.Drawing.Size(56, 13);
            this.lblBasePath.TabIndex = 3;
            this.lblBasePath.Text = "Base Path";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(92, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(994, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(92, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(994, 20);
            this.textBox2.TabIndex = 5;
            // 
            // actionsStrip
            // 
            this.actionsStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.actionsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnNewACL,
            this.toolBtnNewFileCopy,
            this.toolBtnNewInput});
            this.actionsStrip.Location = new System.Drawing.Point(0, 0);
            this.actionsStrip.Name = "actionsStrip";
            this.actionsStrip.Size = new System.Drawing.Size(1074, 25);
            this.actionsStrip.TabIndex = 2;
            this.actionsStrip.Text = "toolStrip1";
            // 
            // toolBtnNewInput
            // 
            this.toolBtnNewInput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnNewInput.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnNewInput.Image")));
            this.toolBtnNewInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnNewInput.Name = "toolBtnNewInput";
            this.toolBtnNewInput.Size = new System.Drawing.Size(66, 22);
            this.toolBtnNewInput.Text = "New Input";
            // 
            // toolBtnNewFileCopy
            // 
            this.toolBtnNewFileCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnNewFileCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnNewFileCopy.Image")));
            this.toolBtnNewFileCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnNewFileCopy.Name = "toolBtnNewFileCopy";
            this.toolBtnNewFileCopy.Size = new System.Drawing.Size(125, 22);
            this.toolBtnNewFileCopy.Text = "New File Copy Action";
            // 
            // toolBtnNewACL
            // 
            this.toolBtnNewACL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolBtnNewACL.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnNewACL.Image")));
            this.toolBtnNewACL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnNewACL.Name = "toolBtnNewACL";
            this.toolBtnNewACL.Size = new System.Drawing.Size(98, 22);
            this.toolBtnNewACL.Text = "New ACL Action";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnInputBase);
            this.splitContainer1.Size = new System.Drawing.Size(1074, 510);
            this.splitContainer1.SplitterDistance = 358;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnGeneratePS
            // 
            this.btnGeneratePS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneratePS.Location = new System.Drawing.Point(955, 628);
            this.btnGeneratePS.Name = "btnGeneratePS";
            this.btnGeneratePS.Size = new System.Drawing.Size(131, 23);
            this.btnGeneratePS.TabIndex = 6;
            this.btnGeneratePS.Text = "Generate PowerShell";
            this.btnGeneratePS.UseVisualStyleBackColor = true;
            // 
            // btnInputBase
            // 
            this.btnInputBase.Location = new System.Drawing.Point(3, 3);
            this.btnInputBase.Name = "btnInputBase";
            this.btnInputBase.Size = new System.Drawing.Size(352, 41);
            this.btnInputBase.TabIndex = 0;
            this.btnInputBase.Text = "Input | Input";
            this.btnInputBase.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 663);
            this.Controls.Add(this.btnGeneratePS);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBasePath);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.actionsStrip.ResumeLayout(false);
            this.actionsStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBasePath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStrip actionsStrip;
        private System.Windows.Forms.ToolStripButton toolBtnNewInput;
        private System.Windows.Forms.ToolStripButton toolBtnNewFileCopy;
        private System.Windows.Forms.ToolStripButton toolBtnNewACL;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnGeneratePS;
        private System.Windows.Forms.Button btnInputBase;
    }
}