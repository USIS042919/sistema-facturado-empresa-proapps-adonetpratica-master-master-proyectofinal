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
    public partial class Avanzado_3 : Form
    {
        public Avanzado_3()
        {
            InitializeComponent();
        }

        private void seguroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.seguroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_dbDataSet1);

        }

        private void Avanzado_3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet1.DetalleEmpleados' Puede moverla o quitarla según sea necesario.
            this.detalleEmpleadosTableAdapter.Fill(this.sistema_dbDataSet1.DetalleEmpleados);
            // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet1.empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.sistema_dbDataSet1.empleados);
            // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet1.seguro' Puede moverla o quitarla según sea necesario.
            this.seguroTableAdapter.Fill(this.sistema_dbDataSet1.seguro);

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveFirst();
            seguroBindingSource.MoveFirst();
            detalleEmpleadosBindingSource.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MovePrevious();
            seguroBindingSource.MovePrevious();
            detalleEmpleadosBindingSource.MovePrevious();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveNext();
            seguroBindingSource.MoveNext();
            detalleEmpleadosBindingSource.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveLast();
            seguroBindingSource.MoveLast();
            detalleEmpleadosBindingSource.MoveLast();
        }
    }
}
