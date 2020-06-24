namespace MiniSuper.Vistas.Gerente
{
    partial class ListadoSucursales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.sucursalesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditarEliminar = new System.Windows.Forms.Button();
            this.pbActualizar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "SUCURSALES";
            // 
            // sucursalesDataGridView
            // 
            this.sucursalesDataGridView.AllowUserToAddRows = false;
            this.sucursalesDataGridView.AllowUserToDeleteRows = false;
            this.sucursalesDataGridView.AutoGenerateColumns = false;
            this.sucursalesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sucursalesDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sucursalesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.sucursalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sucursalesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.sucursalesDataGridView.DataSource = this.sucursalesBindingSource;
            this.sucursalesDataGridView.Location = new System.Drawing.Point(166, 151);
            this.sucursalesDataGridView.Name = "sucursalesDataGridView";
            this.sucursalesDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucursalesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.sucursalesDataGridView.Size = new System.Drawing.Size(654, 319);
            this.sucursalesDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idSucursal";
            this.dataGridViewTextBoxColumn1.HeaderText = "CODIGO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 99;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombreSucursal";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE SUCURSAL";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ubicacion";
            this.dataGridViewTextBoxColumn3.HeaderText = "UBICACION";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn4.HeaderText = "ESTADO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // sucursalesBindingSource
            // 
            this.sucursalesBindingSource.DataSource = typeof(MiniSuper.Entidades.Sucursales);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Teal;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(592, 534);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(190, 67);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nueva Sucursal";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditarEliminar
            // 
            this.btnEditarEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnEditarEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEditarEliminar.Location = new System.Drawing.Point(223, 534);
            this.btnEditarEliminar.Name = "btnEditarEliminar";
            this.btnEditarEliminar.Size = new System.Drawing.Size(190, 67);
            this.btnEditarEliminar.TabIndex = 16;
            this.btnEditarEliminar.Text = "Editar o eliminar seleccionado";
            this.btnEditarEliminar.UseVisualStyleBackColor = false;
            this.btnEditarEliminar.Click += new System.EventHandler(this.btnEditarEliminar_Click);
            // 
            // pbActualizar
            // 
            this.pbActualizar.Image = global::MiniSuper.Properties.Resources.actualizar;
            this.pbActualizar.Location = new System.Drawing.Point(799, 122);
            this.pbActualizar.Name = "pbActualizar";
            this.pbActualizar.Size = new System.Drawing.Size(21, 23);
            this.pbActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbActualizar.TabIndex = 15;
            this.pbActualizar.TabStop = false;
            this.pbActualizar.Click += new System.EventHandler(this.pbActualizar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MiniSuper.Properties.Resources.salir;
            this.pictureBox2.Location = new System.Drawing.Point(8, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ListadoSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 751);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditarEliminar);
            this.Controls.Add(this.pbActualizar);
            this.Controls.Add(this.sucursalesDataGridView);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoSucursales";
            this.Text = "ListadoSucursales";
            this.Load += new System.EventHandler(this.ListadoSucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource sucursalesBindingSource;
        private System.Windows.Forms.DataGridView sucursalesDataGridView;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditarEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        public System.Windows.Forms.PictureBox pbActualizar;
    }
}