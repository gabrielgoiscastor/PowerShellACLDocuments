using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerShellACLDocuments.InputParameters
{
    public partial class InputParameterForm : Form
    {
        public DataModeling.Parameter parameter = null;
        public bool executed = false;
        public bool deleted = false;

        public InputParameterForm()
        {
            InitializeComponent();
        }

        public void initialize(DataModeling.Parameter parameter)
        {
            executed = false;
            deleted = false;
            if (parameter == null)
            {
                this.clearForm();
                btnDeleteInput.Hide();
                this.parameter = new DataModeling.Parameter();
                return;
            }

            this.parameter = parameter;
            btnDeleteInput.Show();
            txtValue.Text = parameter.Value;
            txtName.Text = parameter.Name;
            cbbType.SelectedIndex = parameter.IsInput ? 2 : 1;
            cbbInputType.SelectedIndex = parameter.DataType == "Array" ? 2 : 1;
        }

        private void clearForm()
        {
            txtName.Text = "";
            txtValue.Text = "";
            cbbInputType.SelectedIndex = -1;
            cbbType.SelectedIndex = -1;
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbType.SelectedIndex != 1)
            {
                pnlValues.Hide();
            }
            else
            {
                pnlValues.Show();
            }
        }

        private void cbbInputType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbInputType.SelectedItem == null)
            {
                return;
            }
            if(cbbInputType.SelectedItem.ToString() == "Array")
            {
                txtValue.Multiline = true;
            }
            else
            {
                txtValue.Multiline = false;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            parameter = new DataModeling.Parameter()
            {
                DataType = cbbInputType.SelectedItem.ToString(),
                IsInput = cbbType.SelectedIndex == 2,
                Name = txtName.Text != null ?  txtName.Text : "",
                Value = txtName.Text != null ? txtValue.Text : ""
            };

            executed = true;
            this.Close();
        }

        private void btnDeleteInput_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Sure?", "Delete?", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return;
            }
            this.deleted = true;
            this.executed = true;
            this.Close();
        }
    }
}
