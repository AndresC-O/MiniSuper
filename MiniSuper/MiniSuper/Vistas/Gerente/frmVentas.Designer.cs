namespace MiniSuper.Vistas.Gerente
{
    partial class frmVentas
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
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label idDocumentoLabel;
            System.Windows.Forms.Label idEmpleadoLabel;
            System.Windows.Forms.Label totalCompraLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label idInventarioLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.idDocumentoComboBox = new System.Windows.Forms.ComboBox();
            this.documentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idEmpleadoComboBox = new System.Windows.Forms.ComboBox();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalVentaTextBox = new System.Windows.Forms.TextBox();
            this.ventasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detallesVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallesVentaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.inventarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallesVentaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.idInventarioComboBox = new System.Windows.Forms.ComboBox();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.btnNuevaOrden = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarProdcuto = new System.Windows.Forms.Button();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            idClienteLabel = new System.Windows.Forms.Label();
            idDocumentoLabel = new System.Windows.Forms.Label();
            idEmpleadoLabel = new System.Windows.Forms.Label();
            totalCompraLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            idInventarioLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idClienteLabel.Location = new System.Drawing.Point(91, 178);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(70, 21);
            idClienteLabel.TabIndex = 17;
            idClienteLabel.Text = "Cliente:";
            // 
            // idDocumentoLabel
            // 
            idDocumentoLabel.AutoSize = true;
            idDocumentoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idDocumentoLabel.Location = new System.Drawing.Point(70, 113);
            idDocumentoLabel.Name = "idDocumentoLabel";
            idDocumentoLabel.Size = new System.Drawing.Size(108, 21);
            idDocumentoLabel.TabIndex = 19;
            idDocumentoLabel.Text = "Documento:";
            // 
            // idEmpleadoLabel
            // 
            idEmpleadoLabel.AutoSize = true;
            idEmpleadoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idEmpleadoLabel.Location = new System.Drawing.Point(577, 112);
            idEmpleadoLabel.Name = "idEmpleadoLabel";
            idEmpleadoLabel.Size = new System.Drawing.Size(94, 21);
            idEmpleadoLabel.TabIndex = 21;
            idEmpleadoLabel.Text = "Empleado:";
            // 
            // totalCompraLabel
            // 
            totalCompraLabel.AutoSize = true;
            totalCompraLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalCompraLabel.Location = new System.Drawing.Point(45, 660);
            totalCompraLabel.Name = "totalCompraLabel";
            totalCompraLabel.Size = new System.Drawing.Size(197, 36);
            totalCompraLabel.TabIndex = 42;
            totalCompraLabel.Text = "Total Venta $";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadLabel.Location = new System.Drawing.Point(83, 250);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(88, 21);
            cantidadLabel.TabIndex = 42;
            cantidadLabel.Text = "cantidad:";
            // 
            // idInventarioLabel
            // 
            idInventarioLabel.AutoSize = true;
            idInventarioLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idInventarioLabel.Location = new System.Drawing.Point(83, 213);
            idInventarioLabel.Name = "idInventarioLabel";
            idInventarioLabel.Size = new System.Drawing.Size(86, 21);
            idInventarioLabel.TabIndex = 46;
            idInventarioLabel.Text = "Producto:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.Location = new System.Drawing.Point(106, 288);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(63, 21);
            precioLabel.TabIndex = 50;
            precioLabel.Text = "precio:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalLabel.Location = new System.Drawing.Point(109, 324);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(52, 21);
            totalLabel.TabIndex = 52;
            totalLabel.Text = "total:";
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataSource = typeof(MiniSuper.Entidades.Ventas);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(329, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 41);
            this.label2.TabIndex = 15;
            this.label2.Text = "AREA DE VENTAS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MiniSuper.Properties.Resources.salir;
            this.pictureBox2.Location = new System.Drawing.Point(6, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // idDocumentoComboBox
            // 
            this.idDocumentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "idDocumento", true));
            this.idDocumentoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventasBindingSource, "idDocumento", true));
            this.idDocumentoComboBox.DataSource = this.documentosBindingSource;
            this.idDocumentoComboBox.DisplayMember = "tipoDocumento";
            this.idDocumentoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idDocumentoComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idDocumentoComboBox.FormattingEnabled = true;
            this.idDocumentoComboBox.Location = new System.Drawing.Point(200, 112);
            this.idDocumentoComboBox.Name = "idDocumentoComboBox";
            this.idDocumentoComboBox.Size = new System.Drawing.Size(220, 30);
            this.idDocumentoComboBox.TabIndex = 20;
            this.idDocumentoComboBox.ValueMember = "idDocumento";
            // 
            // documentosBindingSource
            // 
            this.documentosBindingSource.DataSource = typeof(MiniSuper.Entidades.Documentos);
            // 
            // idEmpleadoComboBox
            // 
            this.idEmpleadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "idEmpleado", true));
            this.idEmpleadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventasBindingSource, "idEmpleado", true));
            this.idEmpleadoComboBox.DataSource = this.empleadosBindingSource;
            this.idEmpleadoComboBox.DisplayMember = "nombreEmpleado";
            this.idEmpleadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idEmpleadoComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idEmpleadoComboBox.FormattingEnabled = true;
            this.idEmpleadoComboBox.Location = new System.Drawing.Point(707, 112);
            this.idEmpleadoComboBox.Name = "idEmpleadoComboBox";
            this.idEmpleadoComboBox.Size = new System.Drawing.Size(220, 30);
            this.idEmpleadoComboBox.TabIndex = 22;
            this.idEmpleadoComboBox.ValueMember = "idEmpleado";
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataSource = typeof(MiniSuper.Entidades.Empleados);
            // 
            // totalVentaTextBox
            // 
            this.totalVentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "totalVenta", true));
            this.totalVentaTextBox.Enabled = false;
            this.totalVentaTextBox.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVentaTextBox.Location = new System.Drawing.Point(248, 660);
            this.totalVentaTextBox.Name = "totalVentaTextBox";
            this.totalVentaTextBox.Size = new System.Drawing.Size(121, 40);
            this.totalVentaTextBox.TabIndex = 26;
            this.totalVentaTextBox.TextChanged += new System.EventHandler(this.totalVentaTextBox_TextChanged);
            // 
            // ventasBindingSource1
            // 
            this.ventasBindingSource1.DataSource = typeof(MiniSuper.Entidades.Ventas);
            // 
            // detallesVentaBindingSource
            // 
            this.detallesVentaBindingSource.DataSource = typeof(MiniSuper.Entidades.DetallesVenta);
            // 
            // detallesVentaDataGridView
            // 
            this.detallesVentaDataGridView.AllowUserToAddRows = false;
            this.detallesVentaDataGridView.AutoGenerateColumns = false;
            this.detallesVentaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detallesVentaDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detallesVentaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.detallesVentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallesVentaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.detallesVentaDataGridView.DataSource = this.detallesVentaBindingSource1;
            this.detallesVentaDataGridView.Location = new System.Drawing.Point(73, 391);
            this.detallesVentaDataGridView.Name = "detallesVentaDataGridView";
            this.detallesVentaDataGridView.Size = new System.Drawing.Size(854, 197);
            this.detallesVentaDataGridView.TabIndex = 42;
            this.detallesVentaDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.detallesVentaDataGridView_RowsRemoved);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idDetalleVenta";
            this.dataGridViewTextBoxColumn1.HeaderText = "idDetalleVenta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idVenta";
            this.dataGridViewTextBoxColumn2.HeaderText = "idVenta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idInventario";
            this.dataGridViewTextBoxColumn3.DataSource = this.inventarioBindingSource1;
            this.dataGridViewTextBoxColumn3.DisplayMember = "nombreProducto";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.HeaderText = "PRODUCTO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "idInventario";
            // 
            // inventarioBindingSource1
            // 
            this.inventarioBindingSource1.DataSource = typeof(MiniSuper.Entidades.Inventario);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "CANTIDAD";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn5.HeaderText = "PRECIO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "total";
            this.dataGridViewTextBoxColumn6.HeaderText = "TOTAL";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // detallesVentaBindingSource1
            // 
            this.detallesVentaBindingSource1.DataSource = typeof(MiniSuper.Entidades.DetallesVenta);
            // 
            // cantidadNumericUpDown
            // 
            this.cantidadNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.detallesVentaBindingSource, "cantidad", true));
            this.cantidadNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadNumericUpDown.Location = new System.Drawing.Point(200, 247);
            this.cantidadNumericUpDown.Name = "cantidadNumericUpDown";
            this.cantidadNumericUpDown.Size = new System.Drawing.Size(121, 31);
            this.cantidadNumericUpDown.TabIndex = 43;
            this.cantidadNumericUpDown.ValueChanged += new System.EventHandler(this.cantidadNumericUpDown_ValueChanged);
            // 
            // idInventarioComboBox
            // 
            this.idInventarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesVentaBindingSource, "idInventario", true));
            this.idInventarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.detallesVentaBindingSource, "idInventario", true));
            this.idInventarioComboBox.DataSource = this.inventarioBindingSource1;
            this.idInventarioComboBox.DisplayMember = "nombreProducto";
            this.idInventarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idInventarioComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idInventarioComboBox.FormattingEnabled = true;
            this.idInventarioComboBox.Location = new System.Drawing.Point(200, 211);
            this.idInventarioComboBox.Name = "idInventarioComboBox";
            this.idInventarioComboBox.Size = new System.Drawing.Size(220, 30);
            this.idInventarioComboBox.TabIndex = 47;
            this.idInventarioComboBox.ValueMember = "idInventario";
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataSource = typeof(MiniSuper.Entidades.Inventario);
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesVentaBindingSource, "total", true));
            this.totalTextBox.Enabled = false;
            this.totalTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(200, 321);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(121, 31);
            this.totalTextBox.TabIndex = 53;
            this.totalTextBox.TextChanged += new System.EventHandler(this.totalTextBox_TextChanged);
            // 
            // btnNuevaOrden
            // 
            this.btnNuevaOrden.BackColor = System.Drawing.Color.Teal;
            this.btnNuevaOrden.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaOrden.ForeColor = System.Drawing.Color.White;
            this.btnNuevaOrden.Location = new System.Drawing.Point(707, 182);
            this.btnNuevaOrden.Name = "btnNuevaOrden";
            this.btnNuevaOrden.Size = new System.Drawing.Size(220, 59);
            this.btnNuevaOrden.TabIndex = 54;
            this.btnNuevaOrden.Text = "Nueva Orden";
            this.btnNuevaOrden.UseVisualStyleBackColor = false;
            this.btnNuevaOrden.Click += new System.EventHandler(this.btnNuevaOrden_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Teal;
            this.btnAgregar.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(707, 260);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(220, 63);
            this.btnAgregar.TabIndex = 55;
            this.btnAgregar.Text = "Agregar al Carrito";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(707, 639);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(220, 57);
            this.btnGuardar.TabIndex = 56;
            this.btnGuardar.Text = "Facturar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // idClienteComboBox
            // 
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "idCliente", true));
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventasBindingSource, "idCliente", true));
            this.idClienteComboBox.DataSource = this.clientesBindingSource;
            this.idClienteComboBox.DisplayMember = "nombreCliente";
            this.idClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idClienteComboBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(200, 175);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(220, 30);
            this.idClienteComboBox.TabIndex = 57;
            this.idClienteComboBox.ValueMember = "idCliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(MiniSuper.Entidades.Clientes);
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventasBindingSource, "fecha", true));
            this.fechaDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(796, 24);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(131, 31);
            this.fechaDateTimePicker.TabIndex = 58;
            // 
            // btnBuscarProdcuto
            // 
            this.btnBuscarProdcuto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProdcuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProdcuto.Image = global::MiniSuper.Properties.Resources.buscar;
            this.btnBuscarProdcuto.Location = new System.Drawing.Point(426, 206);
            this.btnBuscarProdcuto.Name = "btnBuscarProdcuto";
            this.btnBuscarProdcuto.Size = new System.Drawing.Size(41, 42);
            this.btnBuscarProdcuto.TabIndex = 59;
            this.btnBuscarProdcuto.UseVisualStyleBackColor = true;
            this.btnBuscarProdcuto.Click += new System.EventHandler(this.btnBuscarProdcuto_Click);
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesVentaBindingSource, "precio", true));
            this.precioTextBox.Enabled = false;
            this.precioTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTextBox.Location = new System.Drawing.Point(200, 284);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(121, 27);
            this.precioTextBox.TabIndex = 60;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 751);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.btnBuscarProdcuto);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(this.idClienteComboBox);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevaOrden);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadNumericUpDown);
            this.Controls.Add(idInventarioLabel);
            this.Controls.Add(this.idInventarioComboBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.detallesVentaDataGridView);
            this.Controls.Add(totalCompraLabel);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(idDocumentoLabel);
            this.Controls.Add(this.idDocumentoComboBox);
            this.Controls.Add(idEmpleadoLabel);
            this.Controls.Add(this.idEmpleadoComboBox);
            this.Controls.Add(this.totalVentaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesVentaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ventasBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox idDocumentoComboBox;
        private System.Windows.Forms.ComboBox idEmpleadoComboBox;
        private System.Windows.Forms.TextBox totalVentaTextBox;
        private System.Windows.Forms.BindingSource documentosBindingSource;
        private System.Windows.Forms.BindingSource ventasBindingSource1;
        private System.Windows.Forms.BindingSource detallesVentaBindingSource;
        private System.Windows.Forms.DataGridView detallesVentaDataGridView;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button btnNuevaOrden;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private System.Windows.Forms.BindingSource detallesVentaBindingSource1;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.Button btnBuscarProdcuto;
        private System.Windows.Forms.BindingSource inventarioBindingSource1;
        public System.Windows.Forms.NumericUpDown cantidadNumericUpDown;
        public System.Windows.Forms.ComboBox idInventarioComboBox;
        public System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        public System.Windows.Forms.PictureBox pictureBox2;
    }
}