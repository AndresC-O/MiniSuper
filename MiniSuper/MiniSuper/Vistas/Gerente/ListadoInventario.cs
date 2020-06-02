using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniSuper.Controladores;
using MiniSuper.Entidades;

namespace MiniSuper.Vistas.Gerente
{
    public partial class ListadoInventario : Form
    {
        CInventario cProducto = new CInventario();
        CProveedores cProveedor = new CProveedores();
        CCategoria cCategoria = new CCategoria();
       
        

        public ListadoInventario()
        {
            InitializeComponent();
        }

        
        public void CargarTabla()
        {
            inventarioBindingSource.DataSource = cProducto.ListadoInventarios();
            categoriasBindingSource.DataSource = cCategoria.ListadoCategorias();
            proveedoresBindingSource.DataSource = cProveedor.ListadoProveedores();
        }

        private void ListadoInventario_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnEditarEliminar_Click(object sender, EventArgs e)
        {
            
            if (inventarioDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("¡Aún no hay productos para modificar/eliminar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Inventario prod = new Inventario();
                prod = (Inventario)inventarioBindingSource.Current;

                CRUD_Producto crud = new CRUD_Producto(prod);
                crud.Show();
                crud.btnGuardar.Visible = false;
                crud.btnNuevo.Visible = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CRUD_Producto crud = new CRUD_Producto();
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

        private void pbActualizar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
