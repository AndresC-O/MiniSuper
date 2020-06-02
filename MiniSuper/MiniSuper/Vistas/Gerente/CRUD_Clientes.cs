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
    public partial class CRUD_Clientes : Form
    {
        Clientes cliente = new Clientes();
        public CRUD_Clientes()
        {
            InitializeComponent();
        }

        public CRUD_Clientes(Clientes cl)
        {
            InitializeComponent();
            this.cliente = cl;
        }

        public void Limpiar()
        {
            nombreClienteTextBox.Text = "";
            apellidosClienteTextBox.Text = "";
            direccionTextBox.Text = "";
            telefonoTextBox.Text = "";
            duiTextBox.Text = "";
            nitTextBox.Text = "";
        }
        private void CRUD_Clientes_Load(object sender, EventArgs e)
        {
            nombreClienteTextBox.Enabled = false;
            apellidosClienteTextBox.Enabled = false;
            direccionTextBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            duiTextBox.Enabled = false;
            nitTextBox.Enabled = false;

            clientesBindingSource.DataSource = cliente;
        }

        private void btnHabEdi_Click(object sender, EventArgs e)
        {
            nombreClienteTextBox.Enabled = true;
            apellidosClienteTextBox.Enabled = true;
            direccionTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            duiTextBox.Enabled = true;
            nitTextBox.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nombreClienteTextBox.Enabled = true;
            apellidosClienteTextBox.Enabled = true;
            direccionTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            duiTextBox.Enabled = true;
            nitTextBox.Enabled = true;

            clientesBindingSource.MoveLast();
            clientesBindingSource.AddNew();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CClientes cnuevo = new CClientes();
            clientesBindingSource.EndEdit();
            cnuevo.RegistrarCliente((Clientes)clientesBindingSource.Current);
            MessageBox.Show("¡Cliente registrado con éxito!");
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CClientes nCliente = new CClientes();
            clientesBindingSource.EndEdit();
            nCliente.ActualizarCliente((Clientes)clientesBindingSource.Current);
            MessageBox.Show("¡Cliente editado con éxito!");
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CClientes cEliminar = new CClientes();
            clientesBindingSource.EndEdit();
            cEliminar.EliminarCliente((Clientes)clientesBindingSource.Current);
            MessageBox.Show("¡Cliente eliminado con éxito!");
            Limpiar();
            this.Close();
        }
    }
}
