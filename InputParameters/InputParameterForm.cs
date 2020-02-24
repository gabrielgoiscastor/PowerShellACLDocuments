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
        public InputParameterForm()
        {
            InitializeComponent();
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
            if(cbbInputType.SelectedItem.ToString() == "Array")
            {
                txtValue.Multiline = true;
            }
            else
            {
                txtValue.Multiline = false;
            }
        }
    }
}
