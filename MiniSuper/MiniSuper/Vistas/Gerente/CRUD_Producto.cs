using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniSuper.Entidades;
using MiniSuper.Controladores;

namespace MiniSuper.Vistas.Gerente
{
    public partial class CRUD_Producto : Form
    {
        Inventario inv = new Inventario();
        Productos p = new Productos();
        CProducto cp = new CProducto();

        public CRUD_Producto()
        {
            InitializeComponent();
        }

        public CRUD_Producto(Productos p)
        {
            InitializeComponent();
            this.p = p;
        }

        

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void CRUD_Producto_Load(object sender, EventArgs e)
        { 
            productosBindingSource.DataSource = p;
            
            CProveedores cProveedor = new CProveedores();
            proveedoresBindingSource.DataSource = cProveedor.ListadoProveedores();
            CCategoria cCategoria = new CCategoria();
            categoriasBindingSource.DataSource = cCategoria.ListadoCategorias();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            this.Close();
            this.Dispose();
            inv.Show();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CProducto cEliminar = new CProducto();
            productosBindingSource.EndEdit();
            cEliminar.EliminarProducto((Productos)productosBindingSource.Current);
            MessageBox.Show("¡Producto eliminado con éxito!");
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            inv.Show();
        }
    }
}
