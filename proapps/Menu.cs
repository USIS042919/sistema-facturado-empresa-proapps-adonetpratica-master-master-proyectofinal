using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace proapps
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       private void AbrirFormsEnpanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormsEnpanel(new Form1());
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormsEnpanel(new empleados());
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            AbrirFormsEnpanel(new gastos());
        }

        private void btnTipodecliente_Click(object sender, EventArgs e)
        {
            AbrirFormsEnpanel(new frmElementos());
        }

        private void btnTipodeEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormsEnpanel(new frmOpciones());
        }

        private void btnAvanzado1_Click(object sender, EventArgs e)
        {
            AbrirFormsEnpanel(new Avanzado_1());
        }

        private void btnAvanzado2_Click(object sender, EventArgs e)
        {
            AbrirFormsEnpanel(new Avanzado_2());
        }

        private void btnTipodepagos_Click(object sender, EventArgs e)
        {
            AbrirFormsEnpanel(new frmTipopagos());
        }

        private void btnAvanzado3_Click(object sender, EventArgs e)
        {
            AbrirFormsEnpanel(new Avanzado_3());
        }
    }
}
