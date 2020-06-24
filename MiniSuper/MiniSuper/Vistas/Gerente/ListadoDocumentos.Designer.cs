namespace MiniSuper.Vistas.Gerente
{
    partial class ListadoDocumentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.documentosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditarEliminar = new System.Windows.Forms.Button();
            this.pbActualizar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.documentosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 39);
            this.label2.TabIndex = 14;
            this.label2.Text = "DOCUMENTOS";
            // 
            // documentosDataGridView
            // 
            this.documentosDataGridView.AllowUserToAddRows = false;
            this.documentosDataGridView.AllowUserToDeleteRows = false;
            this.documentosDataGridView.AutoGenerateColumns = false;
            this.documentosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.documentosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.documentosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.documentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.documentosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.documentosDataGridView.DataSource = this.documentosBindingSource;
            this.documentosDataGridView.Location = new System.Drawing.Point(182, 134);
            this.documentosDataGridView.Name = "documentosDataGridView";
            this.documentosDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentosDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.documentosDataGridView.Size = new System.Drawing.Size(636, 291);
            this.documentosDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idDocumento";
            this.dataGridViewTextBoxColumn1.HeaderText = "CODIGO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tipoDocumento";
            this.dataGridViewTextBoxColumn2.HeaderText = "DOCUMENTO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn3.HeaderText = "estado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // documentosBindingSource
            // 
            this.documentosBindingSource.DataSource = typeof(MiniSuper.Entidades.Documentos);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Teal;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(589, 491);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(190, 67);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "Nuevo Documento";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditarEliminar
            // 
            this.btnEditarEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnEditarEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEditarEliminar.Location = new System.Drawing.Point(220, 491);
            this.btnEditarEliminar.Name = "btnEditarEliminar";
            this.btnEditarEliminar.Size = new System.Drawing.Size(190, 67);
            this.btnEditarEliminar.TabIndex = 18;
            this.btnEditarEliminar.Text = "Editar o eliminar seleccionado";
            this.btnEditarEliminar.UseVisualStyleBackColor = false;
            this.btnEditarEliminar.Click += new System.EventHandler(this.btnEditarEliminar_Click);
            // 
            // pbActualizar
            // 
            this.pbActualizar.Image = global::MiniSuper.Properties.Resources.actualizar;
            this.pbActualizar.Location = new System.Drawing.Point(797, 105);
            this.pbActualizar.Name = "pbActualizar";
            this.pbActualizar.Size = new System.Drawing.Size(21, 23);
            this.pbActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbActualizar.TabIndex = 17;
            this.pbActualizar.TabStop = false;
            this.pbActualizar.Click += new System.EventHandler(this.pbActualizar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MiniSuper.Properties.Resources.salir;
            this.pictureBox2.Location = new System.Drawing.Point(8, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ListadoDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 751);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditarEliminar);
            this.Controls.Add(this.pbActualizar);
            this.Controls.Add(this.documentosDataGridView);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoDocumentos";
            this.Load += new System.EventHandler(this.ListadoDocumentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource documentosBindingSource;
        private System.Windows.Forms.DataGridView documentosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public System.Windows.Forms.PictureBox pbActualizar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditarEliminar;
    }
}