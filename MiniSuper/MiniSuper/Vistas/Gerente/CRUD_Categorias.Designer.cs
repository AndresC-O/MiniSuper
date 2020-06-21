namespace MiniSuper.Vistas.Gerente
{
    partial class CRUD_Categorias
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
            this.btnHabEdi = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.idCategoriaLabel1 = new System.Windows.Forms.Label();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreCategoriaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            idInventarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idInventarioLabel
            // 
            idInventarioLabel.AutoSize = true;
            idInventarioLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idInventarioLabel.ForeColor = System.Drawing.Color.DimGray;
            idInventarioLabel.Location = new System.Drawing.Point(129, 26);
            idInventarioLabel.Name = "idInventarioLabel";
            idInventarioLabel.Size = new System.Drawing.Size(28, 19);
            idInventarioLabel.TabIndex = 33;
            idInventarioLabel.Text = "Id:";
            // 
            // btnHabEdi
            // 
            this.btnHabEdi.BackColor = System.Drawing.Color.CadetBlue;
            this.btnHabEdi.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnHabEdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabEdi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabEdi.ForeColor = System.Drawing.Color.White;
            this.btnHabEdi.Location = new System.Drawing.Point(184, 139);
            this.btnHabEdi.Name = "btnHabEdi";
            this.btnHabEdi.Size = new System.Drawing.Size(149, 49);
            this.btnHabEdi.TabIndex = 26;
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
            this.btnEliminar.Location = new System.Drawing.Point(339, 139);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 49);
            this.btnEliminar.TabIndex = 27;
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
            this.btnModificar.Location = new System.Drawing.Point(29, 139);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(149, 49);
            this.btnModificar.TabIndex = 24;
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
            this.btnGuardar.Location = new System.Drawing.Point(339, 139);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(149, 49);
            this.btnGuardar.TabIndex = 28;
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
            this.btnNuevo.Location = new System.Drawing.Point(29, 139);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(149, 49);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // idCategoriaLabel1
            // 
            this.idCategoriaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriasBindingSource, "idCategoria", true));
            this.idCategoriaLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCategoriaLabel1.Location = new System.Drawing.Point(163, 25);
            this.idCategoriaLabel1.Name = "idCategoriaLabel1";
            this.idCategoriaLabel1.Size = new System.Drawing.Size(100, 23);
            this.idCategoriaLabel1.TabIndex = 30;
            this.idCategoriaLabel1.Text = "label1";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataSource = typeof(MiniSuper.Entidades.Categorias);
            // 
            // nombreCategoriaTextBox
            // 
            this.nombreCategoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriasBindingSource, "nombreCategoria", true));
            this.nombreCategoriaTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCategoriaTextBox.Location = new System.Drawing.Point(167, 53);
            this.nombreCategoriaTextBox.Name = "nombreCategoriaTextBox";
            this.nombreCategoriaTextBox.Size = new System.Drawing.Size(321, 27);
            this.nombreCategoriaTextBox.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(2, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre Categoria:";
            // 
            // CRUD_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(525, 203);
            this.Controls.Add(idInventarioLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idCategoriaLabel1);
            this.Controls.Add(this.nombreCategoriaTextBox);
            this.Controls.Add(this.btnHabEdi);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "CRUD_Categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD_Categorias";
            this.Load += new System.EventHandler(this.CRUD_Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnHabEdi;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private System.Windows.Forms.Label idCategoriaLabel1;
        private System.Windows.Forms.TextBox nombreCategoriaTextBox;
        private System.Windows.Forms.Label label2;
    }
}