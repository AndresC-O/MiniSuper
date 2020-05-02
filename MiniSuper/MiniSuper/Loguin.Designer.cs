namespace MiniSuper
{
    partial class Loguin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label contraseniaLabel;
            System.Windows.Forms.Label usuarioLabel;
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            contraseniaLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contraseniaLabel
            // 
            contraseniaLabel.AutoSize = true;
            contraseniaLabel.Location = new System.Drawing.Point(60, 113);
            contraseniaLabel.Name = "contraseniaLabel";
            contraseniaLabel.Size = new System.Drawing.Size(65, 13);
            contraseniaLabel.TabIndex = 1;
            contraseniaLabel.Text = "contrasenia:";
            // 
            // txtContra
            // 
            this.txtContra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "contrasenia", true));
            this.txtContra.Location = new System.Drawing.Point(131, 110);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(176, 20);
            this.txtContra.TabIndex = 2;
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(60, 74);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(44, 13);
            usuarioLabel.TabIndex = 3;
            usuarioLabel.Text = "usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "usuario", true));
            this.txtUsuario.Location = new System.Drawing.Point(131, 71);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(176, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(118, 178);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(146, 37);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Iniciar Sesión.";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataSource = typeof(MiniSuper.Entidades.Empleados);
            // 
            // Loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 285);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(contraseniaLabel);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.txtUsuario);
            this.Name = "Loguin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Loguin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnIngresar;
    }
}

