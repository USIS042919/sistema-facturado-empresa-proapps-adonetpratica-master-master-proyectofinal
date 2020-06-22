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
    public partial class frmFormas : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _idDetalleClientes;
        public frmFormas()
        {
            InitializeComponent();
        }

        private void frmFormas_Load(object sender, EventArgs e)
        {
            grdBusquedaFormas.DataSource = objConexion.obtener_datos().Tables["DetalleClientes_clientes"].DefaultView;
        }

        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaFormas.DataSource;
            bs.Filter = "codigo like '%" + valor + "%' or nombre like '%" + valor + "%'";
            grdBusquedaFormas.DataSource = bs;
        }
    }
}
