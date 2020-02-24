using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerShellACLDocuments.ACLGroups
{
    public partial class ACLGroup : Form
    {
        public bool executed = false;
        public bool deleted = false;

        public DataModeling.ACLSettingsGroup aclGroup;

        public ACLGroup()
        {
            InitializeComponent();
        }

        public void initialize(DataModeling.ACLSettingsGroup settingsGroup)
        {
            clearInterface();

            if(settingsGroup == null)
            {
                aclGroup = new DataModeling.ACLSettingsGroup();
                aclGroup.Id = Guid.NewGuid();
                btnDelete.Hide();
                return;
            }

            aclGroup = settingsGroup;

            if(aclGroup.Id == Guid.Empty)
            {
                aclGroup.Id = Guid.NewGuid();
            }

            txtName.Text = settingsGroup.Name;
            txtColor.Text = settingsGroup.Color.ToString();
            realColor.BackColor = settingsGroup.Color;
        }

        public void clearInterface()
        {
            txtColor.Text = "";
            txtName.Text = "";
            realColor.BackColor = txtName.BackColor;
            deleted = false;
            executed = false;
        }

        private void txtColor_Enter(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();

            Color color = colorDialog.Color;

            txtColor.Text = color.ToString();
            realColor.BackColor = color;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Sure?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            this.executed = true;
            this.deleted = true;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.executed = true;
            this.aclGroup.Name = txtName.Text;
            aclGroup.Color = realColor.BackColor;
            this.Close();
        }
    }
}
