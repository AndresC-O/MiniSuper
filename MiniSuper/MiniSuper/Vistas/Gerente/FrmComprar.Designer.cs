namespace MiniSuper.Vistas.Gerente
{
    partial class FrmComprar
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
            System.Windows.Forms.Label idEmpleadoLabel;
            System.Windows.Forms.Label idProveedorLabel;
            System.Windows.Forms.Label totalCompraLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label idInventarioLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label totalLabel;
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevaOrden = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idEmpleadoComboBox = new System.Windows.Forms.ComboBox();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detallesCompraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detallesCompraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.detallesCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idInventarioComboBox = new System.Windows.Forms.ComboBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.totalCompraTextBox = new System.Windows.Forms.TextBox();
            this.lblRetornoID = new System.Windows.Forms.Label();
            idEmpleadoLabel = new System.Windows.Forms.Label();
            idProveedorLabel = new System.Windows.Forms.Label();
            totalCompraLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            idInventarioLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idEmpleadoLabel
            // 
            idEmpleadoLabel.AutoSize = true;
            idEmpleadoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idEmpleadoLabel.Location = new System.Drawing.Point(55, 84);
            idEmpleadoLabel.Name = "idEmpleadoLabel";
            idEmpleadoLabel.Size = new System.Drawing.Size(94, 21);
            idEmpleadoLabel.TabIndex = 37;
            idEmpleadoLabel.Text = "Empleado:";
            // 
            // idProveedorLabel
            // 
            idProveedorLabel.AutoSize = true;
            idProveedorLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProveedorLabel.Location = new System.Drawing.Point(55, 119);
            idProveedorLabel.Name = "idProveedorLabel";
            idProveedorLabel.Size = new System.Drawing.Size(94, 21);
            idProveedorLabel.TabIndex = 39;
            idProveedorLabel.Text = "Proveedor:";
            // 
            // totalCompraLabel
            // 
            totalCompraLabel.AutoSize = true;
            totalCompraLabel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalCompraLabel.Location = new System.Drawing.Point(26, 651);
            totalCompraLabel.Name = "totalCompraLabel";
            totalCompraLabel.Size = new System.Drawing.Size(237, 36);
            totalCompraLabel.TabIndex = 41;
            totalCompraLabel.Text = "Total Compra: $";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadLabel.Location = new System.Drawing.Point(58, 222);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(91, 21);
            cantidadLabel.TabIndex = 42;
            cantidadLabel.Text = "Cantidad:";
            // 
            // idInventarioLabel
            // 
            idInventarioLabel.AutoSize = true;
            idInventarioLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idInventarioLabel.Location = new System.Drawing.Point(63, 154);
            idInventarioLabel.Name = "idInventarioLabel";
            idInventarioLabel.Size = new System.Drawing.Size(86, 21);
            idInventarioLabel.TabIndex = 44;
            idInventarioLabel.Text = "Producto:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.Location = new System.Drawing.Point(88, 190);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(61, 21);
            precioLabel.TabIndex = 46;
            precioLabel.Text = "Precio:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalLabel.Location = new System.Drawing.Point(90, 256);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(53, 21);
            totalLabel.TabIndex = 48;
            totalLabel.Text = "Total:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MiniSuper.Properties.Resources.salir;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 39);
            this.label2.TabIndex = 13;
            this.label2.Text = "AREA DE COMPRAS";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(686, 624);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(256, 57);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "COMPRAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevaOrden
            // 
            this.btnNuevaOrden.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaOrden.Location = new System.Drawing.Point(604, 90);
            this.btnNuevaOrden.Name = "btnNuevaOrden";
            this.btnNuevaOrden.Size = new System.Drawing.Size(298, 72);
            this.btnNuevaOrden.TabIndex = 30;
            this.btnNuevaOrden.Text = "Nueva Orden";
            this.btnNuevaOrden.UseVisualStyleBackColor = true;
            this.btnNuevaOrden.Click += new System.EventHandler(this.btnNuevaOrden_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(604, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 75);
            this.button1.TabIndex = 31;
            this.button1.Text = "Agregar al Carrito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.CalendarFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.comprasBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(837, 20);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(131, 31);
            this.fechaDateTimePicker.TabIndex = 34;
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataSource = typeof(MiniSuper.Entidades.Compras);
            // 
            // idEmpleadoComboBox
            // 
            this.idEmpleadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "idEmpleado", true));
            this.idEmpleadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.comprasBindingSource, "idEmpleado", true));
            this.idEmpleadoComboBox.DataSource = this.empleadosBindingSource;
            this.idEmpleadoComboBox.DisplayMember = "nombreEmpleado";
            this.idEmpleadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idEmpleadoComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idEmpleadoComboBox.FormattingEnabled = true;
            this.idEmpleadoComboBox.Location = new System.Drawing.Point(164, 81);
            this.idEmpleadoComboBox.Name = "idEmpleadoComboBox";
            this.idEmpleadoComboBox.Size = new System.Drawing.Size(200, 29);
            this.idEmpleadoComboBox.TabIndex = 38;
            this.idEmpleadoComboBox.ValueMember = "idEmpleado";
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataSource = typeof(MiniSuper.Entidades.Empleados);
            // 
            // idProveedorComboBox
            // 
            this.idProveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "idProveedor", true));
            this.idProveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.comprasBindingSource, "idProveedor", true));
            this.idProveedorComboBox.DataSource = this.proveedoresBindingSource;
            this.idProveedorComboBox.DisplayMember = "nombreProveedor";
            this.idProveedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idProveedorComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProveedorComboBox.FormattingEnabled = true;
            this.idProveedorComboBox.Location = new System.Drawing.Point(164, 116);
            this.idProveedorComboBox.Name = "idProveedorComboBox";
            this.idProveedorComboBox.Size = new System.Drawing.Size(200, 29);
            this.idProveedorComboBox.TabIndex = 40;
            this.idProveedorComboBox.ValueMember = "idProveedor";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataSource = typeof(MiniSuper.Entidades.Proveedores);
            // 
            // detallesCompraDataGridView
            // 
            this.detallesCompraDataGridView.AllowUserToAddRows = false;
            this.detallesCompraDataGridView.AllowUserToDeleteRows = false;
            this.detallesCompraDataGridView.AutoGenerateColumns = false;
            this.detallesCompraDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detallesCompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detallesCompraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.detallesCompraDataGridView.DataSource = this.detallesCompraBindingSource1;
            this.detallesCompraDataGridView.Location = new System.Drawing.Point(59, 301);
            this.detallesCompraDataGridView.Name = "detallesCompraDataGridView";
            this.detallesCompraDataGridView.Size = new System.Drawing.Size(909, 220);
            this.detallesCompraDataGridView.TabIndex = 42;
            this.detallesCompraDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.detallesCompraDataGridView_RowsRemoved);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idDetalleCompra";
            this.dataGridViewTextBoxColumn1.HeaderText = "idDetalleCompra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idCompra";
            this.dataGridViewTextBoxColumn2.HeaderText = "idCompra";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idInventario";
            this.dataGridViewTextBoxColumn3.DataSource = this.inventarioBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "nombreProducto";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.HeaderText = "PRODUCTO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "idInventario";
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataSource = typeof(MiniSuper.Entidades.Inventario);
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
            // detallesCompraBindingSource1
            // 
            this.detallesCompraBindingSource1.DataSource = typeof(MiniSuper.Entidades.DetallesCompra);
            // 
            // cantidadNumericUpDown
            // 
            this.cantidadNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.detallesCompraBindingSource, "cantidad", true));
            this.cantidadNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadNumericUpDown.Location = new System.Drawing.Point(164, 220);
            this.cantidadNumericUpDown.Name = "cantidadNumericUpDown";
            this.cantidadNumericUpDown.Size = new System.Drawing.Size(121, 27);
            this.cantidadNumericUpDown.TabIndex = 43;
            this.cantidadNumericUpDown.ValueChanged += new System.EventHandler(this.cantidadNumericUpDown_ValueChanged_1);
            // 
            // detallesCompraBindingSource
            // 
            this.detallesCompraBindingSource.DataSource = typeof(MiniSuper.Entidades.DetallesCompra);
            // 
            // idInventarioComboBox
            // 
            this.idInventarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesCompraBindingSource, "idInventario", true));
            this.idInventarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.detallesCompraBindingSource, "idInventario", true));
            this.idInventarioComboBox.DataSource = this.inventarioBindingSource;
            this.idInventarioComboBox.DisplayMember = "nombreProducto";
            this.idInventarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idInventarioComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idInventarioComboBox.FormattingEnabled = true;
            this.idInventarioComboBox.Location = new System.Drawing.Point(164, 151);
            this.idInventarioComboBox.Name = "idInventarioComboBox";
            this.idInventarioComboBox.Size = new System.Drawing.Size(200, 29);
            this.idInventarioComboBox.TabIndex = 45;
            this.idInventarioComboBox.ValueMember = "idInventario";
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesCompraBindingSource, "precio", true));
            this.precioTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTextBox.Location = new System.Drawing.Point(164, 187);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(121, 27);
            this.precioTextBox.TabIndex = 47;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detallesCompraBindingSource, "total", true));
            this.totalTextBox.Enabled = false;
            this.totalTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(164, 253);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(121, 27);
            this.totalTextBox.TabIndex = 49;
            this.totalTextBox.TextChanged += new System.EventHandler(this.totalTextBox_TextChanged);
            // 
            // totalCompraTextBox
            // 
            this.totalCompraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "TotalCompra", true));
            this.totalCompraTextBox.Enabled = false;
            this.totalCompraTextBox.Font = new System.Drawing.Font("Broadway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCompraTextBox.Location = new System.Drawing.Point(259, 659);
            this.totalCompraTextBox.Name = "totalCompraTextBox";
            this.totalCompraTextBox.Size = new System.Drawing.Size(141, 31);
            this.totalCompraTextBox.TabIndex = 50;
            // 
            // lblRetornoID
            // 
            this.lblRetornoID.AutoSize = true;
            this.lblRetornoID.Location = new System.Drawing.Point(432, 116);
            this.lblRetornoID.Name = "lblRetornoID";
            this.lblRetornoID.Size = new System.Drawing.Size(35, 13);
            this.lblRetornoID.TabIndex = 51;
            this.lblRetornoID.Text = "label1";
            // 
            // FrmComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 751);
            this.Controls.Add(this.lblRetornoID);
            this.Controls.Add(this.totalCompraTextBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadNumericUpDown);
            this.Controls.Add(idInventarioLabel);
            this.Controls.Add(this.idInventarioComboBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.detallesCompraDataGridView);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(idEmpleadoLabel);
            this.Controls.Add(this.idEmpleadoComboBox);
            this.Controls.Add(idProveedorLabel);
            this.Controls.Add(this.idProveedorComboBox);
            this.Controls.Add(totalCompraLabel);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevaOrden);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmComprar";
            this.Text = "FrmComprar";
            this.Load += new System.EventHandler(this.FrmComprar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detallesCompraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevaOrden;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.ComboBox idEmpleadoComboBox;
        private System.Windows.Forms.ComboBox idProveedorComboBox;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private System.Windows.Forms.BindingSource detallesCompraBindingSource;
        private System.Windows.Forms.DataGridView detallesCompraDataGridView;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private System.Windows.Forms.NumericUpDown cantidadNumericUpDown;
        private System.Windows.Forms.ComboBox idInventarioComboBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.BindingSource detallesCompraBindingSource1;
        private System.Windows.Forms.TextBox totalCompraTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lblRetornoID;
    }
}