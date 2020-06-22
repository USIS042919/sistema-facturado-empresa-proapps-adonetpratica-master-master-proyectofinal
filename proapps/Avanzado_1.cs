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
    public partial class Avanzado_1 : Form
    {
        public Avanzado_1()
        {
            InitializeComponent();
        }

        private void detalleEventosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.detalleEventosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistema_dbDataSet1);

        }

        private void Avanzado_1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet1.categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.sistema_dbDataSet1.categorias);
            // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet1.eventos' Puede moverla o quitarla según sea necesario.
            this.eventosTableAdapter.Fill(this.sistema_dbDataSet1.eventos);
            // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet1.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.sistema_dbDataSet1.clientes);
            // TODO: esta línea de código carga datos en la tabla 'sistema_dbDataSet1.DetalleEventos' Puede moverla o quitarla según sea necesario.
            this.detalleEventosTableAdapter.Fill(this.sistema_dbDataSet1.DetalleEventos);

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveFirst();
            detalleEventosBindingSource.MoveFirst();
            categoriasBindingSource.MoveFirst();
            eventosBindingSource.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MovePrevious();
            detalleEventosBindingSource.MovePrevious();
            categoriasBindingSource.MovePrevious();
            eventosBindingSource.MovePrevious();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveNext();
            detalleEventosBindingSource.MoveNext();
            categoriasBindingSource.MoveNext();
            eventosBindingSource.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveLast();
            detalleEventosBindingSource.MoveLast();
            categoriasBindingSource.MoveLast();
            eventosBindingSource.MoveLast();
        }
    }
}
