namespace MiniSuper.Vistas.Gerente
{
    partial class CRUD_Empleados
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
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label cargoLabel;
            System.Windows.Forms.Label contraseniaLabel;
            System.Windows.Forms.Label duiLabel;
            System.Windows.Forms.Label idEmpleadoLabel;
            System.Windows.Forms.Label idSucursalLabel;
            System.Windows.Forms.Label nombreEmpleadoLabel;
            System.Windows.Forms.Label usuarioLabel;
            this.btnHabEdi = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cargoComboBox = new System.Windows.Forms.ComboBox();
            this.contraseniaTextBox = new System.Windows.Forms.TextBox();
            this.duiTextBox = new System.Windows.Forms.TextBox();
            this.idSucursalComboBox = new System.Windows.Forms.ComboBox();
            this.sucursalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreEmpleadoTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.idEmpleadoLabel2 = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            cargoLabel = new System.Windows.Forms.Label();
            contraseniaLabel = new System.Windows.Forms.Label();
            duiLabel = new System.Windows.Forms.Label();
            idEmpleadoLabel = new System.Windows.Forms.Label();
            idSucursalLabel = new System.Windows.Forms.Label();
            nombreEmpleadoLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidosLabel.ForeColor = System.Drawing.Color.DimGray;
            apellidosLabel.Location = new System.Drawing.Point(50, 160);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(85, 19);
            apellidosLabel.TabIndex = 34;
            apellidosLabel.Text = "Apellidos:";
            // 
            // cargoLabel
            // 
            cargoLabel.AutoSize = true;
            cargoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cargoLabel.ForeColor = System.Drawing.Color.DimGray;
            cargoLabel.Location = new System.Drawing.Point(73, 57);
            cargoLabel.Name = "cargoLabel";
            cargoLabel.Size = new System.Drawing.Size(62, 19);
            cargoLabel.TabIndex = 36;
            cargoLabel.Text = "Cargo:";
            // 
            // contraseniaLabel
            // 
            contraseniaLabel.AutoSize = true;
            contraseniaLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contraseniaLabel.ForeColor = System.Drawing.Color.DimGray;
            contraseniaLabel.Location = new System.Drawing.Point(29, 259);
            contraseniaLabel.Name = "contraseniaLabel";
            contraseniaLabel.Size = new System.Drawing.Size(106, 19);
            contraseniaLabel.TabIndex = 38;
            contraseniaLabel.Text = "Contrasenia:";
            // 
            // duiLabel
            // 
            duiLabel.AutoSize = true;
            duiLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            duiLabel.ForeColor = System.Drawing.Color.DimGray;
            duiLabel.Location = new System.Drawing.Point(97, 193);
            duiLabel.Name = "duiLabel";
            duiLabel.Size = new System.Drawing.Size(38, 19);
            duiLabel.TabIndex = 40;
            duiLabel.Text = "Dui:";
            // 
            // idEmpleadoLabel
            // 
            idEmpleadoLabel.AutoSize = true;
            idEmpleadoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idEmpleadoLabel.ForeColor = System.Drawing.Color.DimGray;
            idEmpleadoLabel.Location = new System.Drawing.Point(107, 24);
            idEmpleadoLabel.Name = "idEmpleadoLabel";
            idEmpleadoLabel.Size = new System.Drawing.Size(28, 19);
            idEmpleadoLabel.TabIndex = 42;
            idEmpleadoLabel.Text = "ID:";
            // 
            // idSucursalLabel
            // 
            idSucursalLabel.AutoSize = true;
            idSucursalLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idSucursalLabel.ForeColor = System.Drawing.Color.DimGray;
            idSucursalLabel.Location = new System.Drawing.Point(58, 92);
            idSucursalLabel.Name = "idSucursalLabel";
            idSucursalLabel.Size = new System.Drawing.Size(77, 19);
            idSucursalLabel.TabIndex = 44;
            idSucursalLabel.Text = "Sucursal:";
            // 
            // nombreEmpleadoLabel
            // 
            nombreEmpleadoLabel.AutoSize = true;
            nombreEmpleadoLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreEmpleadoLabel.ForeColor = System.Drawing.Color.DimGray;
            nombreEmpleadoLabel.Location = new System.Drawing.Point(52, 127);
            nombreEmpleadoLabel.Name = "nombreEmpleadoLabel";
            nombreEmpleadoLabel.Size = new System.Drawing.Size(83, 19);
            nombreEmpleadoLabel.TabIndex = 46;
            nombreEmpleadoLabel.Text = "Nombres:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.ForeColor = System.Drawing.Color.DimGray;
            usuarioLabel.Location = new System.Drawing.Point(66, 226);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(69, 19);
            usuarioLabel.TabIndex = 48;
            usuarioLabel.Text = "Usuario:";
            // 
            // btnHabEdi
            // 
            this.btnHabEdi.BackColor = System.Drawing.Color.CadetBlue;
            this.btnHabEdi.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnHabEdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabEdi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabEdi.ForeColor = System.Drawing.Color.White;
            this.btnHabEdi.Location = new System.Drawing.Point(177, 320);
            this.btnHabEdi.Name = "btnHabEdi";
            this.btnHabEdi.Size = new System.Drawing.Size(149, 49);
            this.btnHabEdi.TabIndex = 31;
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
            this.btnEliminar.Location = new System.Drawing.Point(332, 320);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 49);
            this.btnEliminar.TabIndex = 32;
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
            this.btnModificar.Location = new System.Drawing.Point(22, 320);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(149, 49);
            this.btnModificar.TabIndex = 29;
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
            this.btnGuardar.Location = new System.Drawing.Point(332, 320);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(149, 49);
            this.btnGuardar.TabIndex = 33;
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
            this.btnNuevo.Location = new System.Drawing.Point(22, 320);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(149, 49);
            this.btnNuevo.TabIndex = 30;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "apellidos", true));
            this.apellidosTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidosTextBox.Location = new System.Drawing.Point(141, 156);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(287, 27);
            this.apellidosTextBox.TabIndex = 35;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataSource = typeof(MiniSuper.Entidades.Empleados);
            // 
            // cargoComboBox
            // 
            this.cargoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "cargo", true));
            this.cargoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cargoComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoComboBox.FormattingEnabled = true;
            this.cargoComboBox.Location = new System.Drawing.Point(141, 53);
            this.cargoComboBox.Name = "cargoComboBox";
            this.cargoComboBox.Size = new System.Drawing.Size(287, 29);
            this.cargoComboBox.TabIndex = 37;
            // 
            // contraseniaTextBox
            // 
            this.contraseniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "contrasenia", true));
            this.contraseniaTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseniaTextBox.Location = new System.Drawing.Point(141, 255);
            this.contraseniaTextBox.Name = "contraseniaTextBox";
            this.contraseniaTextBox.PasswordChar = '*';
            this.contraseniaTextBox.Size = new System.Drawing.Size(287, 27);
            this.contraseniaTextBox.TabIndex = 39;
            // 
            // duiTextBox
            // 
            this.duiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "dui", true));
            this.duiTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duiTextBox.Location = new System.Drawing.Point(141, 189);
            this.duiTextBox.Name = "duiTextBox";
            this.duiTextBox.Size = new System.Drawing.Size(287, 27);
            this.duiTextBox.TabIndex = 41;
            // 
            // idSucursalComboBox
            // 
            this.idSucursalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "idSucursal", true));
            this.idSucursalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empleadosBindingSource, "idSucursal", true));
            this.idSucursalComboBox.DataSource = this.sucursalesBindingSource;
            this.idSucursalComboBox.DisplayMember = "nombreSucursal";
            this.idSucursalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idSucursalComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idSucursalComboBox.FormattingEnabled = true;
            this.idSucursalComboBox.Location = new System.Drawing.Point(141, 88);
            this.idSucursalComboBox.Name = "idSucursalComboBox";
            this.idSucursalComboBox.Size = new System.Drawing.Size(287, 29);
            this.idSucursalComboBox.TabIndex = 45;
            this.idSucursalComboBox.ValueMember = "idSucursal";
            // 
            // sucursalesBindingSource
            // 
            this.sucursalesBindingSource.DataSource = typeof(MiniSuper.Entidades.Sucursales);
            // 
            // nombreEmpleadoTextBox
            // 
            this.nombreEmpleadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "nombreEmpleado", true));
            this.nombreEmpleadoTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEmpleadoTextBox.Location = new System.Drawing.Point(141, 123);
            this.nombreEmpleadoTextBox.Name = "nombreEmpleadoTextBox";
            this.nombreEmpleadoTextBox.Size = new System.Drawing.Size(287, 27);
            this.nombreEmpleadoTextBox.TabIndex = 47;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "usuario", true));
            this.usuarioTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.Location = new System.Drawing.Point(141, 222);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(287, 27);
            this.usuarioTextBox.TabIndex = 49;
            // 
            // idEmpleadoLabel2
            // 
            this.idEmpleadoLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "idEmpleado", true));
            this.idEmpleadoLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idEmpleadoLabel2.Location = new System.Drawing.Point(141, 24);
            this.idEmpleadoLabel2.Name = "idEmpleadoLabel2";
            this.idEmpleadoLabel2.Size = new System.Drawing.Size(100, 23);
            this.idEmpleadoLabel2.TabIndex = 50;
            this.idEmpleadoLabel2.Text = "label1";
            // 
            // CRUD_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(510, 389);
            this.Controls.Add(this.idEmpleadoLabel2);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(cargoLabel);
            this.Controls.Add(this.cargoComboBox);
            this.Controls.Add(contraseniaLabel);
            this.Controls.Add(this.contraseniaTextBox);
            this.Controls.Add(duiLabel);
            this.Controls.Add(this.duiTextBox);
            this.Controls.Add(idEmpleadoLabel);
            this.Controls.Add(idSucursalLabel);
            this.Controls.Add(this.idSucursalComboBox);
            this.Controls.Add(nombreEmpleadoLabel);
            this.Controls.Add(this.nombreEmpleadoTextBox);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.btnHabEdi);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "CRUD_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD_Empleados";
            this.Load += new System.EventHandler(this.CRUD_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnHabEdi;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.ComboBox cargoComboBox;
        private System.Windows.Forms.TextBox contraseniaTextBox;
        private System.Windows.Forms.TextBox duiTextBox;
        private System.Windows.Forms.ComboBox idSucursalComboBox;
        private System.Windows.Forms.TextBox nombreEmpleadoTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.BindingSource sucursalesBindingSource;
        private System.Windows.Forms.Label idEmpleadoLabel2;
    }
}