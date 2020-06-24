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
    public partial class ListadoDocumentos : Form
    {
        public ListadoDocumentos()
        {
            InitializeComponent();
        }

        CDocumentos cDocumentos = new CDocumentos();
        void CargarTabla()
        {
            documentosDataGridView.Rows.Clear();
            documentosBindingSource.DataSource = cDocumentos.ListadoDocumentos();
        }
        private void pbActualizar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void ListadoDocumentos_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnEditarEliminar_Click(object sender, EventArgs e)
        {
            if (documentosDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("¡Aún no hay documentos para modificar/eliminar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Documentos docu = new Documentos();
                docu = (Documentos)documentosBindingSource.Current;

                CRUD_Documentos crud = new CRUD_Documentos(docu);
                crud.Show();
                crud.btnGuardar.Visible = false;
                crud.btnNuevo.Visible = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CRUD_Documentos crud = new CRUD_Documentos();
            crud.Show();
            crud.btnEliminar.Visible = false;
            crud.btnModificar.Visible = false;
            crud.btnHabEdi.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            AccesoGerente ag = new AccesoGerente();
            ag.Show();
        }
    }
}
