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
    public partial class CRUD_Proveedores : Form
    {
        Proveedores prove = new Proveedores();
        public CRUD_Proveedores()
        {
            InitializeComponent();
        }

        public CRUD_Proveedores(Proveedores pro)
        {
            InitializeComponent();
            this.prove = pro;
        }

        private void CRUD_Proveedores_Load(object sender, EventArgs e)
        {
            proveedoresBindingSource.DataSource = prove;

            nombreProveedorTextBox.Enabled = false;
            direccionTextBox.Enabled = false;
            telefonoTextBox.Enabled = false;
        }

        public void Limpiar()
        {
            nombreProveedorTextBox.Text = "";
            direccionTextBox.Text = "";
            telefonoTextBox.Text = "";
        }

        private void btnHabEdi_Click(object sender, EventArgs e)
        {
            nombreProveedorTextBox.Enabled = true;
            direccionTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CProveedores nProvee = new CProveedores();
            proveedoresBindingSource.EndEdit();
            nProvee.ActualizarProveedor((Proveedores)proveedoresBindingSource.Current);
            MessageBox.Show("¡Proveedor editado con éxito!");
            Limpiar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nombreProveedorTextBox.Enabled = true;
            direccionTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;

            proveedoresBindingSource.MoveLast();
            proveedoresBindingSource.AddNew();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CProveedores cEliminar = new CProveedores();
            proveedoresBindingSource.EndEdit();
            cEliminar.EliminarProveedor((Proveedores)proveedoresBindingSource.Current);
            MessageBox.Show("¡Proveedor eliminado con éxito!");
            Limpiar();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CProveedores cnuevo = new CProveedores();
            proveedoresBindingSource.EndEdit();
            cnuevo.RegistrarProveedor((Proveedores)proveedoresBindingSource.Current);
            MessageBox.Show("¡Proveedor registrado con éxito!");
            this.Close();
        }
    }
}
