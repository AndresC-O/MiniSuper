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
        CProducto cProducto = new CProducto();
        CProveedores cProveedor = new CProveedores();
        CCategoria cCategoria = new CCategoria();
        public ListadoInventario()
        {
            InitializeComponent();
        }

        public void CargarTabla()
        {
            productosDataGridView.Rows.Clear();

            productosBindingSource.DataSource = cProducto.ListadoProductos();
            proveedoresBindingSource.DataSource = cProveedor.ListadoProveedores();
            categoriasBindingSource.DataSource = cCategoria.ListadoCategorias();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(productosDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("¡Aún no hay productos para modificar/eliminar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Productos p = new Productos();
                p = (Productos)productosBindingSource.Current;

                CRUD_Producto crud = new CRUD_Producto(p);
                crud.Show();
                crud.btnGuardar.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUD_Producto crud = new CRUD_Producto();
            crud.Show();
            crud.btnEliminar.Visible = false;
            crud.btnModificar.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AccesoGerente mb = new AccesoGerente();
            this.Close();
            this.Dispose();
            mb.Show();

        }
    }
}
