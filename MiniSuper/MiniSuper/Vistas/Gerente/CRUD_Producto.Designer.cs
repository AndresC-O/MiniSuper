namespace MiniSuper.Vistas.Gerente
{
    partial class CRUD_Producto
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
            System.Windows.Forms.Label costoLabel;
            System.Windows.Forms.Label existenciasLabel;
            System.Windows.Forms.Label precioVentaLabel;
            System.Windows.Forms.Label idInventarioLabel;
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.idInventarioLabel2 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnHabEdi = new System.Windows.Forms.Button();
            costoLabel = new System.Windows.Forms.Label();
            existenciasLabel = new System.Windows.Forms.Label();
            precioVentaLabel = new System.Windows.Forms.Label();
            idInventarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // costoLabel
            // 
            costoLabel.AutoSize = true;
            costoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costoLabel.ForeColor = System.Drawing.Color.DimGray;
            costoLabel.Location = new System.Drawing.Point(169, 329);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(55, 19);
            costoLabel.TabIndex = 13;
            costoLabel.Text = "Costo:";
            // 
            // existenciasLabel
            // 
            existenciasLabel.AutoSize = true;
            existenciasLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            existenciasLabel.ForeColor = System.Drawing.Color.DimGray;
            existenciasLabel.Location = new System.Drawing.Point(129, 285);
            existenciasLabel.Name = "existenciasLabel";
            existenciasLabel.Size = new System.Drawing.Size(95, 19);
            existenciasLabel.TabIndex = 11;
            existenciasLabel.Text = "Existencias:";
            // 
            // precioVentaLabel
            // 
            precioVentaLabel.AutoSize = true;
            precioVentaLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioVentaLabel.ForeColor = System.Drawing.Color.DimGray;
            precioVentaLabel.Location = new System.Drawing.Point(113, 374);
            precioVentaLabel.Name = "precioVentaLabel";
            precioVentaLabel.Size = new System.Drawing.Size(111, 19);
            precioVentaLabel.TabIndex = 16;
            precioVentaLabel.Text = "Precio Venta:";
            // 
            // idInventarioLabel
            // 
            idInventarioLabel.AutoSize = true;
            idInventarioLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idInventarioLabel.ForeColor = System.Drawing.Color.DimGray;
            idInventarioLabel.Location = new System.Drawing.Point(196, 40);
            idInventarioLabel.Name = "idInventarioLabel";
            idInventarioLabel.Size = new System.Drawing.Size(28, 19);
            idInventarioLabel.TabIndex = 0;
            idInventarioLabel.Text = "Id:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(129, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 57);
            this.label13.TabIndex = 7;
            this.label13.Text = "Seleccionar o \r\n   Cambiar\r\n  Proveedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(128, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 57);
            this.label8.TabIndex = 4;
            this.label8.Text = "Seleccionar o \r\n   Cambiar\r\n  Categoria";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(481, 474);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 49);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(81, 474);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(149, 49);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(481, 474);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(149, 49);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(151, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblProveedor.Location = new System.Drawing.Point(298, 333);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(17, 19);
            this.lblProveedor.TabIndex = 15;
            this.lblProveedor.Text = "  ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "hola";
            this.pictureBox1.Image = global::MiniSuper.Properties.Resources.salir;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataSource = typeof(MiniSuper.Entidades.Inventario);
            // 
            // txtCosto
            // 
            this.txtCosto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "costo", true));
            this.txtCosto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(268, 329);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(102, 27);
            this.txtCosto.TabIndex = 14;
            this.txtCosto.TextChanged += new System.EventHandler(this.txtCosto_TextChanged);
            // 
            // txtExistencias
            // 
            this.txtExistencias.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "existencias", true));
            this.txtExistencias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistencias.Location = new System.Drawing.Point(268, 285);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(203, 27);
            this.txtExistencias.TabIndex = 12;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "idCategoria", true));
            this.cmbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.inventarioBindingSource, "idCategoria", true));
            this.cmbCategoria.DataSource = this.categoriasBindingSource;
            this.cmbCategoria.DisplayMember = "nombreCategoria";
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(268, 134);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(203, 29);
            this.cmbCategoria.TabIndex = 5;
            this.cmbCategoria.ValueMember = "idCategoria";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataSource = typeof(MiniSuper.Entidades.Categorias);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "idProveedor", true));
            this.cmbProveedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.inventarioBindingSource, "idProveedor", true));
            this.cmbProveedor.DataSource = this.proveedoresBindingSource;
            this.cmbProveedor.DisplayMember = "nombreProveedor";
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(268, 211);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(203, 29);
            this.cmbProveedor.TabIndex = 8;
            this.cmbProveedor.ValueMember = "idProveedor";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataSource = typeof(MiniSuper.Entidades.Proveedores);
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "nombreProducto", true));
            this.txtNombreProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProd.Location = new System.Drawing.Point(268, 78);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(391, 27);
            this.txtNombreProd.TabIndex = 3;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "precioVenta", true));
            this.txtPrecioVenta.Enabled = false;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(268, 374);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(102, 27);
            this.txtPrecioVenta.TabIndex = 17;
            // 
            // idInventarioLabel2
            // 
            this.idInventarioLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventarioBindingSource, "idInventario", true));
            this.idInventarioLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idInventarioLabel2.Location = new System.Drawing.Point(265, 40);
            this.idInventarioLabel2.Name = "idInventarioLabel2";
            this.idInventarioLabel2.Size = new System.Drawing.Size(100, 23);
            this.idInventarioLabel2.TabIndex = 1;
            this.idInventarioLabel2.Text = "label1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.CadetBlue;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(81, 474);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(149, 49);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnHabEdi
            // 
            this.btnHabEdi.BackColor = System.Drawing.Color.CadetBlue;
            this.btnHabEdi.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnHabEdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabEdi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabEdi.ForeColor = System.Drawing.Color.White;
            this.btnHabEdi.Location = new System.Drawing.Point(236, 474);
            this.btnHabEdi.Name = "btnHabEdi";
            this.btnHabEdi.Size = new System.Drawing.Size(149, 49);
            this.btnHabEdi.TabIndex = 99;
            this.btnHabEdi.Text = "Habiliar Edicion";
            this.btnHabEdi.UseVisualStyleBackColor = false;
            this.btnHabEdi.Click += new System.EventHandler(this.btnHabEdi_Click);
            // 
            // CRUD_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(715, 553);
            this.Controls.Add(this.btnHabEdi);
            this.Controls.Add(this.idInventarioLabel2);
            this.Controls.Add(idInventarioLabel);
            this.Controls.Add(costoLabel);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(existenciasLabel);
            this.Controls.Add(this.txtExistencias);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(precioVentaLabel);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUD_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD_Producto";
            this.Load += new System.EventHandler(this.CRUD_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private System.Windows.Forms.Label idInventarioLabel2;
        public System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Button btnHabEdi;
    }
}