namespace PowerShellACLDocuments.InputParameters
{
    partial class InputParameterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbbInputType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.pnlValues = new System.Windows.Forms.Panel();
            this.pnlValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(104, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(609, 20);
            this.txtName.TabIndex = 1;
            // 
            // cbbInputType
            // 
            this.cbbInputType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbInputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbInputType.FormattingEnabled = true;
            this.cbbInputType.Items.AddRange(new object[] {
            "Select",
            "String",
            "Array"});
            this.cbbInputType.Location = new System.Drawing.Point(95, 3);
            this.cbbInputType.Name = "cbbInputType";
            this.cbbInputType.Size = new System.Drawing.Size(608, 21);
            this.cbbInputType.TabIndex = 3;
            this.cbbInputType.SelectedIndexChanged += new System.EventHandler(this.cbbInputType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Type";
            // 
            // txtValue
            // 
            this.txtValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValue.Location = new System.Drawing.Point(95, 30);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(608, 150);
            this.txtValue.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input Value(s)";
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.Location = new System.Drawing.Point(722, 6);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(145, 233);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "Finish configuration";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type";
            // 
            // cbbType
            // 
            this.cbbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Select",
            "Define in this software",
            "Type as PowerShell input"});
            this.cbbType.Location = new System.Drawing.Point(104, 32);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(609, 21);
            this.cbbType.TabIndex = 2;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // pnlValues
            // 
            this.pnlValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlValues.Controls.Add(this.label2);
            this.pnlValues.Controls.Add(this.cbbInputType);
            this.pnlValues.Controls.Add(this.txtValue);
            this.pnlValues.Controls.Add(this.label3);
            this.pnlValues.Location = new System.Drawing.Point(10, 59);
            this.pnlValues.Name = "pnlValues";
            this.pnlValues.Size = new System.Drawing.Size(706, 186);
            this.pnlValues.TabIndex = 8;
            // 
            // InputParameterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 247);
            this.Controls.Add(this.pnlValues);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "InputParameterForm";
            this.Text = "InputParameterForm";
            this.pnlValues.ResumeLayout(false);
            this.pnlValues.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbbInputType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Panel pnlValues;
    }
}