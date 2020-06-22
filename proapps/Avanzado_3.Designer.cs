namespace proapps
{
    partial class Avanzado_3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label edadLabel;
            System.Windows.Forms.Label idDetalleEmpleadosLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avanzado_3));
            this.sistema_dbDataSet1 = new proapps.sistema_dbDataSet1();
            this.seguroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seguroTableAdapter = new proapps.sistema_dbDataSet1TableAdapters.seguroTableAdapter();
            this.tableAdapterManager = new proapps.sistema_dbDataSet1TableAdapters.TableAdapterManager();
            this.detalleEmpleadosTableAdapter = new proapps.sistema_dbDataSet1TableAdapters.DetalleEmpleadosTableAdapter();
            this.empleadosTableAdapter = new proapps.sistema_dbDataSet1TableAdapters.empleadosTableAdapter();
            this.seguroBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.seguroBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.seguroDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.correoComboBox = new System.Windows.Forms.ComboBox();
            this.detalleEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.edadComboBox = new System.Windows.Forms.ComboBox();
            this.idDetalleEmpleadosTextBox = new System.Windows.Forms.TextBox();
            this.pnlNavegacion = new System.Windows.Forms.Panel();
            this.lblregistroxden = new System.Windows.Forms.Label();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.pnlEdicion = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlEmpleadoGrid = new System.Windows.Forms.Panel();
            this.btnQuitarProductosGrid = new System.Windows.Forms.Button();
            this.btnAgregarProductosGrid = new System.Windows.Forms.Button();
            correoLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            idDetalleEmpleadosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguroBindingNavigator)).BeginInit();
            this.seguroBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seguroDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleEmpleadosBindingSource)).BeginInit();
            this.pnlNavegacion.SuspendLayout();
            this.pnlEdicion.SuspendLayout();
            this.pnlEmpleadoGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(19, 92);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(41, 13);
            correoLabel.TabIndex = 2;
            correoLabel.Text = "Correo:";
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.Location = new System.Drawing.Point(276, 54);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(35, 13);
            edadLabel.TabIndex = 6;
            edadLabel.Text = "Edad:";
            // 
            // idDetalleEmpleadosLabel
            // 
            idDetalleEmpleadosLabel.AutoSize = true;
            idDetalleEmpleadosLabel.Location = new System.Drawing.Point(38, 54);
            idDetalleEmpleadosLabel.Name = "idDetalleEmpleadosLabel";
            idDetalleEmpleadosLabel.Size = new System.Drawing.Size(21, 13);
            idDetalleEmpleadosLabel.TabIndex = 8;
            idDetalleEmpleadosLabel.Text = "ID:";
            // 
            // sistema_dbDataSet1
            // 
            this.sistema_dbDataSet1.DataSetName = "sistema_dbDataSet1";
            this.sistema_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seguroBindingSource
            // 
            this.seguroBindingSource.DataMember = "seguro";
            this.seguroBindingSource.DataSource = this.sistema_dbDataSet1;
            // 
            // seguroTableAdapter
            // 
            this.seguroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriasTableAdapter = null;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.depositoTableAdapter = null;
            this.tableAdapterManager.DetalleClientesTableAdapter = null;
            this.tableAdapterManager.DetalleEmpleadosTableAdapter = this.detalleEmpleadosTableAdapter;
            this.tableAdapterManager.DetalleEventosTableAdapter = null;
            this.tableAdapterManager.empleadosTableAdapter = this.empleadosTableAdapter;
            this.tableAdapterManager.eventosTableAdapter = null;
            this.tableAdapterManager.formasTableAdapter = null;
            this.tableAdapterManager.gastoTableAdapter = null;
            this.tableAdapterManager.informeTableAdapter = null;
            this.tableAdapterManager.integracionTableAdapter = null;
            this.tableAdapterManager.relacionTableAdapter = null;
            this.tableAdapterManager.seguroTableAdapter = this.seguroTableAdapter;
            this.tableAdapterManager.tipopagoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = proapps.sistema_dbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // detalleEmpleadosTableAdapter
            // 
            this.detalleEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // seguroBindingNavigator
            // 
            this.seguroBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.seguroBindingNavigator.BindingSource = this.seguroBindingSource;
            this.seguroBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.seguroBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.seguroBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.seguroBindingNavigatorSaveItem});
            this.seguroBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.seguroBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.seguroBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.seguroBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.seguroBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.seguroBindingNavigator.Name = "seguroBindingNavigator";
            this.seguroBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.seguroBindingNavigator.Size = new System.Drawing.Size(821, 25);
            this.seguroBindingNavigator.TabIndex = 0;
            this.seguroBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // seguroBindingNavigatorSaveItem
            // 
            this.seguroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.seguroBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("seguroBindingNavigatorSaveItem.Image")));
            this.seguroBindingNavigatorSaveItem.Name = "seguroBindingNavigatorSaveItem";
            this.seguroBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.seguroBindingNavigatorSaveItem.Text = "Guardar datos";
            this.seguroBindingNavigatorSaveItem.Click += new System.EventHandler(this.seguroBindingNavigatorSaveItem_Click);
            // 
            // seguroDataGridView
            // 
            this.seguroDataGridView.AutoGenerateColumns = false;
            this.seguroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seguroDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.seguroDataGridView.DataSource = this.seguroBindingSource;
            this.seguroDataGridView.Location = new System.Drawing.Point(12, 140);
            this.seguroDataGridView.Name = "seguroDataGridView";
            this.seguroDataGridView.Size = new System.Drawing.Size(800, 220);
            this.seguroDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdSeguro";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdSeguro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dui ";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dui ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nit";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nit";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fecha_de_nacimiento";
            this.dataGridViewTextBoxColumn7.HeaderText = "Fecha de nacimiento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "empleados";
            this.empleadosBindingSource.DataSource = this.sistema_dbDataSet1;
            // 
            // correoComboBox
            // 
            this.correoComboBox.DataSource = this.empleadosBindingSource;
            this.correoComboBox.DisplayMember = "correo";
            this.correoComboBox.FormattingEnabled = true;
            this.correoComboBox.Location = new System.Drawing.Point(65, 89);
            this.correoComboBox.Name = "correoComboBox";
            this.correoComboBox.Size = new System.Drawing.Size(225, 21);
            this.correoComboBox.TabIndex = 3;
            this.correoComboBox.ValueMember = "correo";
            // 
            // detalleEmpleadosBindingSource
            // 
            this.detalleEmpleadosBindingSource.DataMember = "DetalleEmpleados";
            this.detalleEmpleadosBindingSource.DataSource = this.sistema_dbDataSet1;
            // 
            // edadComboBox
            // 
            this.edadComboBox.DataSource = this.detalleEmpleadosBindingSource;
            this.edadComboBox.DisplayMember = "edad";
            this.edadComboBox.FormattingEnabled = true;
            this.edadComboBox.Location = new System.Drawing.Point(316, 51);
            this.edadComboBox.Name = "edadComboBox";
            this.edadComboBox.Size = new System.Drawing.Size(121, 21);
            this.edadComboBox.TabIndex = 7;
            this.edadComboBox.ValueMember = "edad";
            // 
            // idDetalleEmpleadosTextBox
            // 
            this.idDetalleEmpleadosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleEmpleadosBindingSource, "IdDetalleEmpleados", true));
            this.idDetalleEmpleadosTextBox.Location = new System.Drawing.Point(65, 51);
            this.idDetalleEmpleadosTextBox.Name = "idDetalleEmpleadosTextBox";
            this.idDetalleEmpleadosTextBox.Size = new System.Drawing.Size(100, 20);
            this.idDetalleEmpleadosTextBox.TabIndex = 9;
            // 
            // pnlNavegacion
            // 
            this.pnlNavegacion.Controls.Add(this.lblregistroxden);
            this.pnlNavegacion.Controls.Add(this.btnUltimo);
            this.pnlNavegacion.Controls.Add(this.btnSiguiente);
            this.pnlNavegacion.Controls.Add(this.btnAnterior);
            this.pnlNavegacion.Controls.Add(this.btnPrimero);
            this.pnlNavegacion.Location = new System.Drawing.Point(558, 61);
            this.pnlNavegacion.Name = "pnlNavegacion";
            this.pnlNavegacion.Size = new System.Drawing.Size(204, 49);
            this.pnlNavegacion.TabIndex = 18;
            // 
            // lblregistroxden
            // 
            this.lblregistroxden.AutoSize = true;
            this.lblregistroxden.Location = new System.Drawing.Point(76, 16);
            this.lblregistroxden.Name = "lblregistroxden";
            this.lblregistroxden.Size = new System.Drawing.Size(36, 13);
            this.lblregistroxden.TabIndex = 6;
            this.lblregistroxden.Text = "x de n";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(160, 3);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(32, 38);
            this.btnUltimo.TabIndex = 3;
            this.btnUltimo.Text = ">|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(129, 3);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(32, 38);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(38, 3);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(32, 38);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(7, 3);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(32, 38);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "|<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // pnlEdicion
            // 
            this.pnlEdicion.Controls.Add(this.btnBuscar);
            this.pnlEdicion.Controls.Add(this.btnEliminar);
            this.pnlEdicion.Controls.Add(this.btnModificar);
            this.pnlEdicion.Controls.Add(this.btnAgregar);
            this.pnlEdicion.Location = new System.Drawing.Point(122, 373);
            this.pnlEdicion.Name = "pnlEdicion";
            this.pnlEdicion.Size = new System.Drawing.Size(260, 49);
            this.pnlEdicion.TabIndex = 30;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(200, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 38);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(146, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(53, 38);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(73, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(72, 38);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(5, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(67, 38);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Nuevo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // pnlEmpleadoGrid
            // 
            this.pnlEmpleadoGrid.Controls.Add(this.btnQuitarProductosGrid);
            this.pnlEmpleadoGrid.Controls.Add(this.btnAgregarProductosGrid);
            this.pnlEmpleadoGrid.Location = new System.Drawing.Point(12, 373);
            this.pnlEmpleadoGrid.Name = "pnlEmpleadoGrid";
            this.pnlEmpleadoGrid.Size = new System.Drawing.Size(94, 49);
            this.pnlEmpleadoGrid.TabIndex = 29;
            this.pnlEmpleadoGrid.Visible = false;
            // 
            // btnQuitarProductosGrid
            // 
            this.btnQuitarProductosGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarProductosGrid.Location = new System.Drawing.Point(52, 4);
            this.btnQuitarProductosGrid.Name = "btnQuitarProductosGrid";
            this.btnQuitarProductosGrid.Size = new System.Drawing.Size(31, 38);
            this.btnQuitarProductosGrid.TabIndex = 1;
            this.btnQuitarProductosGrid.Text = "-";
            this.btnQuitarProductosGrid.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProductosGrid
            // 
            this.btnAgregarProductosGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductosGrid.Location = new System.Drawing.Point(5, 4);
            this.btnAgregarProductosGrid.Name = "btnAgregarProductosGrid";
            this.btnAgregarProductosGrid.Size = new System.Drawing.Size(47, 38);
            this.btnAgregarProductosGrid.TabIndex = 0;
            this.btnAgregarProductosGrid.Text = "+";
            this.btnAgregarProductosGrid.UseVisualStyleBackColor = true;
            // 
            // Avanzado_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(821, 434);
            this.Controls.Add(this.pnlEdicion);
            this.Controls.Add(this.pnlEmpleadoGrid);
            this.Controls.Add(this.pnlNavegacion);
            this.Controls.Add(idDetalleEmpleadosLabel);
            this.Controls.Add(this.idDetalleEmpleadosTextBox);
            this.Controls.Add(edadLabel);
            this.Controls.Add(this.edadComboBox);
            this.Controls.Add(correoLabel);
            this.Controls.Add(this.correoComboBox);
            this.Controls.Add(this.seguroDataGridView);
            this.Controls.Add(this.seguroBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Avanzado_3";
            this.Text = "Avanzado_3";
            this.Load += new System.EventHandler(this.Avanzado_3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistema_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seguroBindingNavigator)).EndInit();
            this.seguroBindingNavigator.ResumeLayout(false);
            this.seguroBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seguroDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleEmpleadosBindingSource)).EndInit();
            this.pnlNavegacion.ResumeLayout(false);
            this.pnlNavegacion.PerformLayout();
            this.pnlEdicion.ResumeLayout(false);
            this.pnlEmpleadoGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistema_dbDataSet1 sistema_dbDataSet1;
        private System.Windows.Forms.BindingSource seguroBindingSource;
        private sistema_dbDataSet1TableAdapters.seguroTableAdapter seguroTableAdapter;
        private sistema_dbDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator seguroBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton seguroBindingNavigatorSaveItem;
        private sistema_dbDataSet1TableAdapters.empleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.DataGridView seguroDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private sistema_dbDataSet1TableAdapters.DetalleEmpleadosTableAdapter detalleEmpleadosTableAdapter;
        private System.Windows.Forms.ComboBox correoComboBox;
        private System.Windows.Forms.BindingSource detalleEmpleadosBindingSource;
        private System.Windows.Forms.ComboBox edadComboBox;
        private System.Windows.Forms.TextBox idDetalleEmpleadosTextBox;
        private System.Windows.Forms.Panel pnlNavegacion;
        private System.Windows.Forms.Label lblregistroxden;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Panel pnlEdicion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlEmpleadoGrid;
        private System.Windows.Forms.Button btnQuitarProductosGrid;
        private System.Windows.Forms.Button btnAgregarProductosGrid;
    }
}