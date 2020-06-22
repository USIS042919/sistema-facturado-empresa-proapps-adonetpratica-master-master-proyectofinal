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
    public partial class Avanzado_2 : Form
    {
        public Avanzado_2()
        {
            InitializeComponent();
        }

        private void detalleEmpleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.detalleEmpleadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_dbDataSet1);

        }

        private void Avanzado_2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet1.formas' Puede moverla o quitarla según sea necesario.
            this.formasTableAdapter.Fill(this.sistema_dbDataSet1.formas);
            // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet1.empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.sistema_dbDataSet1.empleados);
            // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet1.informe' Puede moverla o quitarla según sea necesario.
            this.informeTableAdapter.Fill(this.sistema_dbDataSet1.informe);
            // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet1.DetalleEmpleados' Puede moverla o quitarla según sea necesario.
            this.detalleEmpleadosTableAdapter.Fill(this.sistema_dbDataSet1.DetalleEmpleados);

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveFirst();
            formasBindingSource.MoveFirst();
            informeBindingSource.MoveFirst();
            detalleEmpleadosBindingSource.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MovePrevious();
            formasBindingSource.MovePrevious();
            informeBindingSource.MovePrevious();
            detalleEmpleadosBindingSource.MovePrevious();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveNext();
            formasBindingSource.MoveNext();
            informeBindingSource.MoveNext();
            detalleEmpleadosBindingSource.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveLast();
            formasBindingSource.MoveLast();
            informeBindingSource.MoveLast();
            detalleEmpleadosBindingSource.MoveLast();
        }
    }
}
