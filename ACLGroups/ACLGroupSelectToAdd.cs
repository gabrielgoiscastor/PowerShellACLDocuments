using PowerShellACLDocuments.DataModeling;
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
    public partial class ACLGroupSelectToAdd : Form
    {
        List<ACLSettingsGroup> Groups;
        public ACLSettingsGroup SelectedGroup { get; set; }

        public ACLGroupSelectToAdd()
        {
            InitializeComponent();
        }

        public void initialize(List<DataModeling.ACLSettingsGroup> Groups)
        {
            this.Groups = Groups;
            cbbGroupSelect.Items.Clear();
            this.SelectedGroup = null;

            if(Groups == null || Groups.Count == 0)
            {
                return;
            }

            cbbGroupSelect.DisplayMember = "Name";

            foreach (var item in Groups.OrderBy(x => x.Name))
            {
                cbbGroupSelect.Items.Add(item);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(cbbGroupSelect.SelectedIndex == -1)
            {
                this.Close();
                return;
            }

            SelectedGroup = cbbGroupSelect.SelectedItem as ACLSettingsGroup;
            this.Close();
        }
    }
}
