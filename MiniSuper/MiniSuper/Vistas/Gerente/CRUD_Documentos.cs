using MiniSuper.Controladores;
using MiniSuper.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSuper.Vistas.Gerente
{
    public partial class CRUD_Documentos : Form
    {
        Documentos documentos = new Documentos();
        public CRUD_Documentos()
        {
            InitializeComponent();
        }

        public CRUD_Documentos(Documentos doc)
        {
            InitializeComponent();
            this.documentos = doc;
        }

        void Limpiar()
        {
            tipoDocumentoTextBox.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tipoDocumentoTextBox.Enabled = true;

            documentosBindingSource.MoveLast();
            documentosBindingSource.AddNew();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tipoDocumentoTextBox.Text.Equals(""))
            {
                MessageBox.Show("¡Rellene todos los campos!", "Rellenar", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                CDocumentos cnuevo = new CDocumentos();
                documentosBindingSource.EndEdit();
                cnuevo.RegistrarDocumento((Documentos)documentosBindingSource.Current);
                MessageBox.Show("¡Documento registrado con éxito!");
                this.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tipoDocumentoTextBox.Text.Equals(""))
            {
                MessageBox.Show("¡Rellene todos los campos!", "Rellenar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que quieres modificar?", "Autorización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CDocumentos nDocu = new CDocumentos();
                    documentosBindingSource.EndEdit();
                    nDocu.ActualizarDocumento((Documentos)documentosBindingSource.Current);
                    MessageBox.Show("¡Documento editado con éxito!");
                    Limpiar();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres eliminar?", "Autorización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CDocumentos cEliminar = new CDocumentos();
                documentosBindingSource.EndEdit();
                cEliminar.EliminarDocumento((Documentos)documentosBindingSource.Current);
                MessageBox.Show("¡Documento eliminado con éxito!");
                Limpiar();
                this.Close();
            }
        }

        private void btnHabEdi_Click(object sender, EventArgs e)
        {
            tipoDocumentoTextBox.Enabled = true;
        }

        private void CRUD_Documentos_Load(object sender, EventArgs e)
        {
            documentosBindingSource.DataSource = documentos;
            tipoDocumentoTextBox.Enabled = false;
        }
    }
}
