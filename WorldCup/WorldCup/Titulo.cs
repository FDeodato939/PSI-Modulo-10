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
    public partial class Titulo : Form
    {
        public Titulo()
        {
            InitializeComponent();
        }

        private void play_Click(object sender, EventArgs e)
        {
            var form2 = new Contra();
            form2.Show();
            this.Hide();
        }

        private void saida_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
