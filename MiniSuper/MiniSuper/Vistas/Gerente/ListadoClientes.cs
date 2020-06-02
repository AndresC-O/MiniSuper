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
    public partial class ListadoClientes : Form
    {
        public ListadoClientes()
        {
            InitializeComponent();
        }

        CClientes cClientes = new CClientes();
        public void CargarTabla()
        {
            clientesDataGridView.Rows.Clear();
            clientesBindingSource.DataSource = cClientes.ListadoClientes();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            AccesoGerente ag = new AccesoGerente();
            ag.Show();
        }

        private void ListadoClientes_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void pbActualizar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnEditarEliminar_Click(object sender, EventArgs e)
        {
            if (clientesDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("¡Aún no hay productos para modificar/eliminar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Clientes customer = new Clientes();
                customer = (Clientes)clientesBindingSource.Current;

                CRUD_Clientes crud = new CRUD_Clientes(customer);
                crud.Show();
                crud.btnGuardar.Visible = false;
                crud.btnNuevo.Visible = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CRUD_Clientes crud = new CRUD_Clientes();
            crud.Show();
            crud.btnEliminar.Visible = false;
            crud.btnModificar.Visible = false;
            crud.btnHabEdi.Visible = false;
        }
    }
}
