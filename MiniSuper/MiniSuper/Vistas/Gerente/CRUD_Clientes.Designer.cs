namespace MiniSuper.Vistas.Gerente
{
    partial class CRUD_Clientes
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
            System.Windows.Forms.Label idInventarioLabel;
            this.label2 = new System.Windows.Forms.Label();
            this.apellidosClienteTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.duiTextBox = new System.Windows.Forms.TextBox();
            this.idClienteLabel1 = new System.Windows.Forms.Label();
            this.nitTextBox = new System.Windows.Forms.TextBox();
            this.nombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHabEdi = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idInventarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idInventarioLabel
            // 
            idInventarioLabel.AutoSize = true;
            idInventarioLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idInventarioLabel.ForeColor = System.Drawing.Color.DimGray;
            idInventarioLabel.Location = new System.Drawing.Point(106, 17);
            idInventarioLabel.Name = "idInventarioLabel";
            idInventarioLabel.Size = new System.Drawing.Size(28, 19);
            idInventarioLabel.TabIndex = 0;
            idInventarioLabel.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(58, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // apellidosClienteTextBox
            // 
            this.apellidosClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "apellidosCliente", true));
            this.apellidosClienteTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidosClienteTextBox.Location = new System.Drawing.Point(141, 83);
            this.apellidosClienteTextBox.Name = "apellidosClienteTextBox";
            this.apellidosClienteTextBox.Size = new System.Drawing.Size(303, 27);
            this.apellidosClienteTextBox.TabIndex = 5;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(141, 116);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(303, 27);
            this.direccionTextBox.TabIndex = 7;
            // 
            // duiTextBox
            // 
            this.duiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "dui", true));
            this.duiTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duiTextBox.Location = new System.Drawing.Point(141, 182);
            this.duiTextBox.Name = "duiTextBox";
            this.duiTextBox.Size = new System.Drawing.Size(303, 27);
            this.duiTextBox.TabIndex = 11;
            // 
            // idClienteLabel1
            // 
            this.idClienteLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "idCliente", true));
            this.idClienteLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idClienteLabel1.Location = new System.Drawing.Point(141, 17);
            this.idClienteLabel1.Name = "idClienteLabel1";
            this.idClienteLabel1.Size = new System.Drawing.Size(100, 23);
            this.idClienteLabel1.TabIndex = 1;
            this.idClienteLabel1.Text = "label1";
            // 
            // nitTextBox
            // 
            this.nitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nit", true));
            this.nitTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nitTextBox.Location = new System.Drawing.Point(141, 215);
            this.nitTextBox.Name = "nitTextBox";
            this.nitTextBox.Size = new System.Drawing.Size(303, 27);
            this.nitTextBox.TabIndex = 13;
            // 
            // nombreClienteTextBox
            // 
            this.nombreClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nombreCliente", true));
            this.nombreClienteTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreClienteTextBox.Location = new System.Drawing.Point(141, 50);
            this.nombreClienteTextBox.Name = "nombreClienteTextBox";
            this.nombreClienteTextBox.Size = new System.Drawing.Size(303, 27);
            this.nombreClienteTextBox.TabIndex = 3;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "telefono", true));
            this.telefonoTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.Location = new System.Drawing.Point(141, 149);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(303, 27);
            this.telefonoTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(50, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(48, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(56, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(96, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "DUI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(96, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "NIT:";
            // 
            // btnHabEdi
            // 
            this.btnHabEdi.BackColor = System.Drawing.Color.CadetBlue;
            this.btnHabEdi.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnHabEdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabEdi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabEdi.ForeColor = System.Drawing.Color.White;
            this.btnHabEdi.Location = new System.Drawing.Point(182, 278);
            this.btnHabEdi.Name = "btnHabEdi";
            this.btnHabEdi.Size = new System.Drawing.Size(149, 49);
            this.btnHabEdi.TabIndex = 16;
            this.btnHabEdi.Text = "Habiliar Edicion";
            this.btnHabEdi.UseVisualStyleBackColor = false;
            this.btnHabEdi.Click += new System.EventHandler(this.btnHabEdi_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(337, 278);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 49);
            this.btnEliminar.TabIndex = 17;
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
            this.btnModificar.Location = new System.Drawing.Point(27, 278);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(149, 49);
            this.btnModificar.TabIndex = 14;
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
            this.btnGuardar.Location = new System.Drawing.Point(337, 278);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(149, 49);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.CadetBlue;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(27, 278);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(149, 49);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(MiniSuper.Entidades.Clientes);
            // 
            // CRUD_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(511, 341);
            this.Controls.Add(this.btnHabEdi);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apellidosClienteTextBox);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(this.duiTextBox);
            this.Controls.Add(this.idClienteLabel1);
            this.Controls.Add(this.nitTextBox);
            this.Controls.Add(this.nombreClienteTextBox);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(idInventarioLabel);
            this.Controls.Add(this.label2);
            this.Name = "CRUD_Clientes";
            this.Load += new System.EventHandler(this.CRUD_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.TextBox apellidosClienteTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox duiTextBox;
        private System.Windows.Forms.Label idClienteLabel1;
        private System.Windows.Forms.TextBox nitTextBox;
        private System.Windows.Forms.TextBox nombreClienteTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnHabEdi;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnNuevo;
    }
}