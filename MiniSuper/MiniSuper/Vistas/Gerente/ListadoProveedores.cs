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
    public partial class ListadoProveedores : Form
    {
        public ListadoProveedores()
        {
            InitializeComponent();
        }

        CProveedores cProveedores = new CProveedores();
        public void CargarTabla()
        {
            proveedoresDataGridView.Rows.Clear();
            proveedoresBindingSource.DataSource = cProveedores.ListadoProveedores();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            AccesoGerente ag = new AccesoGerente();
            ag.Show();
        }

        private void ListadoProveedores_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CRUD_Proveedores crud = new CRUD_Proveedores();
            crud.Show();
            crud.btnEliminar.Visible = false;
            crud.btnModificar.Visible = false;
            crud.btnHabEdi.Visible = false;
        }

        private void btnEditarEliminar_Click(object sender, EventArgs e)
        {
            if (proveedoresDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("¡Aún no hay proveedores para modificar/eliminar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Proveedores prov = new Proveedores();
                prov = (Proveedores)proveedoresBindingSource.Current;

                CRUD_Proveedores crud = new CRUD_Proveedores(prov);
                crud.Show();
                crud.btnGuardar.Visible = false;
                crud.btnNuevo.Visible = false;
            }
        }

        private void pbActualizar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }
    }
}
