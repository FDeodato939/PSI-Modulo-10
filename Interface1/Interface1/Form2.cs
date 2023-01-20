using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbm_CheckedChanged(object sender, EventArgs e)
        {
            if (rbm.Checked == true)
            {
                lblgen.Text = "Male";
            }
            else
            {
                lblgen.Text = "Female";
            }
        }

        private void rbf_CheckedChanged(object sender, EventArgs e)
        {
            if (rbf.Checked == true)
            {
                lblgen.Text = "Female";
            }
            else
            {
                lblgen.Text = "Male";
            }
        }
    }
}
