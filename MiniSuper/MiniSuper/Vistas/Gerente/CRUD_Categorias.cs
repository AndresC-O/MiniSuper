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
    public partial class CRUD_Categorias : Form
    {
        Categorias cate = new Categorias();
        public CRUD_Categorias()
        {
            InitializeComponent();
        }

        public CRUD_Categorias(Categorias categ)
        {
            InitializeComponent();
            this.cate = categ;
        }

        public void Limpiar()
        {
            nombreCategoriaTextBox.Text = "";
        }
        private void CRUD_Categorias_Load(object sender, EventArgs e)
        {
            categoriasBindingSource.DataSource = cate;

            nombreCategoriaTextBox.Enabled = false;
        }

        private void btnHabEdi_Click(object sender, EventArgs e)
        {
            nombreCategoriaTextBox.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CCategoria nCateg = new CCategoria();
            categoriasBindingSource.EndEdit();
            nCateg.ActualizarCategoria((Categorias)categoriasBindingSource.Current);
            MessageBox.Show("¡Categoria editado con éxito!");
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CCategoria cEliminar = new CCategoria();
            categoriasBindingSource.EndEdit();
            cEliminar.EliminarCategoria((Categorias)categoriasBindingSource.Current);
            MessageBox.Show("¡Categoria eliminado con éxito!");
            Limpiar();
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nombreCategoriaTextBox.Enabled = true;

            categoriasBindingSource.MoveLast();
            categoriasBindingSource.AddNew();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CCategoria cnuevo = new CCategoria();
            categoriasBindingSource.EndEdit();
            cnuevo.RegistrarCategoria((Categorias)categoriasBindingSource.Current);
            MessageBox.Show("¡Categoria registrado con éxito!");
            this.Close();
        }
    }
}
