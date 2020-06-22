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
    public partial class frmBusquedaTipoPagos : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _idPagos;
        public frmBusquedaTipoPagos()
        {
            InitializeComponent();
        }

        private void frmBusquedaTipoPagos_Load(object sender, EventArgs e)
        {
            grdBusquedaPagos.DataSource = objConexion.obtener_datos().Tables["deposito_tipopago"].DefaultView;
        }

        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaPagos.DataSource;
            bs.Filter = "codigo like '%" + valor + "%' or nombre like '%" + valor + "%' or dui like '%" + valor + "%'";
            grdBusquedaPagos.DataSource = bs;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscar.Text);
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaPagos.RowCount > 0)
            {
                _idPagos = int.Parse(grdBusquedaPagos.CurrentRow.Cells["idDeposito"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Pagos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
