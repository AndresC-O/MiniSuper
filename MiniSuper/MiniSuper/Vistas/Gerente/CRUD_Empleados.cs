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
    public partial class CRUD_Empleados : Form
    {
        Empleados emp = new Empleados();
        CSucursales cSucursales = new CSucursales();
        public CRUD_Empleados()
        {
            InitializeComponent();
        }

        public CRUD_Empleados(Empleados emple)
        {
            InitializeComponent();
            this.emp = emple;
        }

        public void CargarCombo()
        {
            int cargo1 = 1, cargo2 = 2;
            cargoComboBox.Items.Add(cargo1);
            cargoComboBox.Items.Add(cargo2);
        }

        public void Limpiar()
        {
            cargoComboBox.Text = "";
            idSucursalComboBox.Text = "";
            nombreEmpleadoTextBox.Text = "";
            apellidosTextBox.Text = "";
            duiTextBox.Text = "";
            usuarioTextBox.Text = "";
            contraseniaTextBox.Text = "";
        }

        private void CRUD_Empleados_Load(object sender, EventArgs e)
        {
            cargoComboBox.Enabled = false;
            idSucursalComboBox.Enabled = false;
            nombreEmpleadoTextBox.Enabled = false;
            apellidosTextBox.Enabled = false;
            duiTextBox.Enabled = false;
            usuarioTextBox.Enabled = false;
            contraseniaTextBox.Enabled = false;

            CargarCombo();
            empleadosBindingSource.DataSource = emp;
            sucursalesBindingSource.DataSource = cSucursales.ListadoSucursales();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CEmpleados pEditar = new CEmpleados();
            empleadosBindingSource.EndEdit();
            pEditar.ActualizarEmpleado((Empleados)empleadosBindingSource.Current);
            MessageBox.Show("¡Empleado editado con éxito!");
            Limpiar();
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cargoComboBox.Enabled = true;
            idSucursalComboBox.Enabled = true;
            nombreEmpleadoTextBox.Enabled = true;
            apellidosTextBox.Enabled = true;
            duiTextBox.Enabled = true;
            usuarioTextBox.Enabled = true;
            contraseniaTextBox.Enabled = true;

            empleadosBindingSource.MoveLast();
            empleadosBindingSource.AddNew();
        }

        private void btnHabEdi_Click(object sender, EventArgs e)
        {
            cargoComboBox.Enabled = true;
            idSucursalComboBox.Enabled = true;
            nombreEmpleadoTextBox.Enabled = true;
            apellidosTextBox.Enabled = true;
            duiTextBox.Enabled = true;
            usuarioTextBox.Enabled = true;
            contraseniaTextBox.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CEmpleados cEliminar = new CEmpleados();
            empleadosBindingSource.EndEdit();
            cEliminar.EliminarEmpleado((Empleados)empleadosBindingSource.Current);
            MessageBox.Show("¡Empleado eliminado con éxito!");
            Limpiar();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CEmpleados pnuevo = new CEmpleados();
            empleadosBindingSource.EndEdit();
            pnuevo.RegistrarEmpleado((Empleados)empleadosBindingSource.Current);
            MessageBox.Show("¡Empleado registrado con éxito!");
            this.Close();
        }
    }
}
