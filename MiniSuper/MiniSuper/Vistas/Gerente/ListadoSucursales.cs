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
    public partial class ListadoSucursales : Form
    {
        public ListadoSucursales()
        {
            InitializeComponent();
        }

        CSucursales cSucursales = new CSucursales();
        void CargarTabla()
        {
            sucursalesDataGridView.Rows.Clear();
            sucursalesBindingSource.DataSource = cSucursales.ListadoSucursales();
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

        private void btnEditarEliminar_Click(object sender, EventArgs e)
        {

            if (sucursalesDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("¡Aún no hay sucursales para modificar/eliminar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Sucursales sucu = new Sucursales();
                sucu = (Sucursales)sucursalesBindingSource.Current;

                CRUD_Sucursales crud = new CRUD_Sucursales(sucu);
                crud.Show();
                crud.btnGuardar.Visible = false;
                crud.btnNuevo.Visible = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CRUD_Sucursales crud = new CRUD_Sucursales();
            crud.Show();
            crud.btnEliminar.Visible = false;
            crud.btnModificar.Visible = false;
            crud.btnHabEdi.Visible = false;
        }

        private void ListadoSucursales_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
    }
}
