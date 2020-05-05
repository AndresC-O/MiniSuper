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
    public partial class Inventario : Form
    {
        CProducto cProducto = new CProducto();
        CProveedores cProveedor = new CProveedores();
        CCategoria cCategoria = new CCategoria();
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            productosBindingSource.DataSource = cProducto.ListadoProductos();
            proveedoresBindingSource.DataSource = cProveedor.ListadoProveedores();
            categoriasBindingSource.DataSource = cCategoria.ListadoCategorias();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();
            p = (Productos)productosBindingSource.Current;

            CRUD_Producto crud = new CRUD_Producto(p);
            crud.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CRUD_Producto crud = new CRUD_Producto();
            crud.Show();
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
