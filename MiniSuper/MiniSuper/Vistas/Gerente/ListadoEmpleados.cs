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
    public partial class ListadoEmpleados : Form
    {
        public ListadoEmpleados()
        {
            InitializeComponent();
        }

        CEmpleados cEmpleados = new CEmpleados();
        CSucursales cSucursales = new CSucursales();
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            AccesoGerente ag = new AccesoGerente();
            ag.Show();
        }

        public void CargarDatos()
        {
            empleadosDataGridView.Rows.Clear();

            empleadosBindingSource.DataSource = cEmpleados.ListadoEmpleados();
            sucursalesBindingSource.DataSource = cSucursales.ListadoSucursales();
        }

        private void ListadoEmpleados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void pbActualizar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEditarEliminar_Click(object sender, EventArgs e)
        {
            if (empleadosDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("¡Aún no hay empleados para modificar/eliminar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Empleados emp = new Empleados();
                emp = (Empleados)empleadosBindingSource.Current;

                CRUD_Empleados crud = new CRUD_Empleados(emp);
                crud.Show();
                crud.btnGuardar.Visible = false;
                crud.btnNuevo.Visible = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CRUD_Empleados crud = new CRUD_Empleados();
            crud.Show();
            crud.btnEliminar.Visible = false;
            crud.btnModificar.Visible = false;
            crud.btnHabEdi.Visible = false;
        }
    }
}
