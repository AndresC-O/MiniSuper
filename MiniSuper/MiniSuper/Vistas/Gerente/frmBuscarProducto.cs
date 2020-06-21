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
    public partial class frmBuscarProducto : Form
    {
        CInventario cInventario = new CInventario();

        public frmBuscarProducto()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (inventarioDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("¡Aún no hay categorias para modificar/eliminar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Inventario inv = new Inventario();
                inv = (Inventario)inventarioBindingSource.Current;

                frmVentas crud = new frmVentas(inv);
                this.Close();
                
            }
        }

        private void frmBuscarProducto_Load(object sender, EventArgs e)
        {
            inventarioBindingSource.DataSource = cInventario.ListadoInventarios();
        }
    }
}
