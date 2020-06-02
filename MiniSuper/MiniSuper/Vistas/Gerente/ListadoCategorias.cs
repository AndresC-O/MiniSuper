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
    public partial class ListadoCategorias : Form
    {
        public ListadoCategorias()
        {
            InitializeComponent();
        }

        CCategoria cCategoria = new CCategoria();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            AccesoGerente ag = new AccesoGerente();
            ag.Show();
        }

        public void CargarTabla()
        {
            categoriasDataGridView.Rows.Clear();
            categoriasBindingSource.DataSource = cCategoria.ListadoCategorias();
        }

        private void ListadoCategorias_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void pbActualizar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CRUD_Categorias crud = new CRUD_Categorias();
            crud.Show();
            crud.btnEliminar.Visible = false;
            crud.btnModificar.Visible = false;
            crud.btnHabEdi.Visible = false;
        }

        private void btnEditarEliminar_Click(object sender, EventArgs e)
        {
            if (categoriasDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("¡Aún no hay categorias para modificar/eliminar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Categorias cate = new Categorias();
                cate = (Categorias)categoriasBindingSource.Current;

                CRUD_Categorias crud = new CRUD_Categorias(cate);
                crud.Show();
                crud.btnGuardar.Visible = false;
                crud.btnNuevo.Visible = false;
            }
        }
    }
}
