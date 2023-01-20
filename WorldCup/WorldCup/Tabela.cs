using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldCup
{
    public partial class Tabela : Form
    {
        public Tabela()
        {
            InitializeComponent();
        }

        private void volta_Click(object sender, EventArgs e)
        {
            var form2 = new Titulo();
            form2.Show();
            this.Hide();
        }
    }
}
