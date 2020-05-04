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
            System.Windows.Forms.Label label1;
            this.txtContra = new System.Windows.Forms.TextBox();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbVerContra = new System.Windows.Forms.CheckBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            contraseniaLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // contraseniaLabel
            // 
            contraseniaLabel.AutoSize = true;
            contraseniaLabel.BackColor = System.Drawing.Color.Teal;
            contraseniaLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contraseniaLabel.ForeColor = System.Drawing.Color.Gainsboro;
            contraseniaLabel.Location = new System.Drawing.Point(431, 228);
            contraseniaLabel.Name = "contraseniaLabel";
            contraseniaLabel.Size = new System.Drawing.Size(124, 22);
            contraseniaLabel.TabIndex = 3;
            contraseniaLabel.Text = "Contraseña:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.ForeColor = System.Drawing.Color.Gainsboro;
            usuarioLabel.Location = new System.Drawing.Point(431, 115);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(80, 22);
            usuarioLabel.TabIndex = 1;
            usuarioLabel.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(525, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(145, 44);
            label1.TabIndex = 0;
            label1.Text = "LOG IN";
            // 
            // txtContra
            // 
            this.txtContra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "contrasenia", true));
            this.txtContra.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(435, 267);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(338, 31);
            this.txtContra.TabIndex = 4;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataSource = typeof(MiniSuper.Entidades.Empleados);
            // 
            // txtUsuario
            // 
            this.txtUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "usuario", true));
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(435, 167);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(338, 31);
            this.txtUsuario.TabIndex = 2;
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAcceder.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAcceder.Location = new System.Drawing.Point(414, 362);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(390, 48);
            this.btnAcceder.TabIndex = 5;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 483);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MiniSuper.Properties.Resources._32officeicons_2_89706;
            this.pictureBox2.Location = new System.Drawing.Point(49, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 256);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // cbVerContra
            // 
            this.cbVerContra.AutoSize = true;
            this.cbVerContra.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbVerContra.Location = new System.Drawing.Point(676, 304);
            this.cbVerContra.Name = "cbVerContra";
            this.cbVerContra.Size = new System.Drawing.Size(99, 17);
            this.cbVerContra.TabIndex = 8;
            this.cbVerContra.Text = "Ver Contraseña";
            this.cbVerContra.UseVisualStyleBackColor = true;
            this.cbVerContra.CheckedChanged += new System.EventHandler(this.cbVerContra_CheckedChanged);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Image = global::MiniSuper.Properties.Resources.cerrar;
            this.pbCerrar.Location = new System.Drawing.Point(849, 4);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(32, 32);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCerrar.TabIndex = 9;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // Loguin
            // 
            this.AcceptButton = this.btnAcceder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(882, 483);
            this.Controls.Add(this.pbCerrar);
            this.Controls.Add(this.cbVerContra);
            this.Controls.Add(this.panel1);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(contraseniaLabel);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Loguin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btnAcceder;
        public System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbVerContra;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

