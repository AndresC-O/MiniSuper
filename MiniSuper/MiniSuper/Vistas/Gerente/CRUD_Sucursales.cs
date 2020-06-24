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
    public partial class CRUD_Sucursales : Form
    {
        Sucursales sucu = new Sucursales();
        public CRUD_Sucursales()
        {
            InitializeComponent();
        }
        public CRUD_Sucursales(Sucursales sucursal)
        {
            InitializeComponent();
            this.sucu = sucursal;
        }
        void Limpiar()
        {
            nombreSucursalTextBox.Text = "";
            ubicacionTextBox.Text = "";
        }
        private void CRUD_Sucursales_Load(object sender, EventArgs e)
        {
            sucursalesBindingSource.DataSource = sucu;
            nombreSucursalTextBox.Enabled = false;
            ubicacionTextBox.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nombreSucursalTextBox.Enabled = true;
            ubicacionTextBox.Enabled = true;

            sucursalesBindingSource.MoveLast();
            sucursalesBindingSource.AddNew();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (nombreSucursalTextBox.Text.Equals("") || ubicacionTextBox.Text.Equals(""))
            {
                MessageBox.Show("¡Rellene todos los campos!", "Rellenar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Estás seguro que quieres modificar?", "Autorización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CSucursales nSucu = new CSucursales();
                    sucursalesBindingSource.EndEdit();
                    nSucu.ActualizarSucursal((Sucursales)sucursalesBindingSource.Current);
                    MessageBox.Show("¡Sucursal editada con éxito!");
                    Limpiar();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nombreSucursalTextBox.Text.Equals("")||ubicacionTextBox.Text.Equals(""))
            {
                MessageBox.Show("¡Rellene todos los campos!", "Rellenar", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                CSucursales cnuevo = new CSucursales();
                sucursalesBindingSource.EndEdit();
                cnuevo.RegistrarSucursal((Sucursales)sucursalesBindingSource.Current);
                MessageBox.Show("¡Sucursal registrada con éxito!");
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres eliminar?", "Autorización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CSucursales cEliminar = new CSucursales();
                sucursalesBindingSource.EndEdit();
                cEliminar.EliminarSucursal((Sucursales)sucursalesBindingSource.Current);
                MessageBox.Show("¡Sucursal eliminado con éxito!");
                Limpiar();
                this.Close();
            }
        }

        private void btnHabEdi_Click(object sender, EventArgs e)
        {
            nombreSucursalTextBox.Enabled = true;
            ubicacionTextBox.Enabled = true;
        }
    }
    
}
