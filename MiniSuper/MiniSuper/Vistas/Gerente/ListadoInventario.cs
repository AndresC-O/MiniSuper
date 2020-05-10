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
    }
}
