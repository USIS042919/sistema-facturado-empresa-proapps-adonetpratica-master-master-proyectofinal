using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proapps
{
    public partial class pantalla__de_carga : Form
    {
        public pantalla__de_carga()
        {
            InitializeComponent();
        }

        public void fn_prbar()
        {
            progressBar2.Increment(1);
            lblcarga.Text = progressBar2.Value.ToString() + "%";
            if(progressBar2.Value ==progressBar2.Maximum)
            {
                timer2.Stop();
                this.Hide();
                Menu ff = new Menu();
                ff.Show();
            }
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void pantalla__de_carga_Load_1(object sender, EventArgs e)
        {
            lblcarga.Parent = pictureBox2;
            lblcarga.BackColor = Color.Transparent;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            fn_prbar();
        }
    }
}
