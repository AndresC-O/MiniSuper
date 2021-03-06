﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniSuper.Entidades;
using MiniSuper.Controladores;

namespace MiniSuper.Vistas.Gerente
{
    public partial class CRUD_Producto : Form
    {
        ListadoInventario inv = new ListadoInventario();
        Inventario p = new Inventario();
        //CProducto cp = new CProducto();

        public CRUD_Producto()
        {
            InitializeComponent();
        }

        public CRUD_Producto(Inventario inv)
        {
            InitializeComponent();
            this.p = inv;
        }

      

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void CRUD_Producto_Load(object sender, EventArgs e)
        {
            txtNombreProd.Enabled = false;
            cmbCategoria.Enabled = false;
            cmbProveedor.Enabled = false;
            txtExistencias.Enabled = false;
            txtCosto.Enabled = false;
            txtPrecioVenta.Enabled = false;

            inventarioBindingSource.DataSource = p;

            CProveedores cProveedor = new CProveedores();
            proveedoresBindingSource.DataSource = cProveedor.ListadoProveedores();
            CCategoria cCategoria = new CCategoria();
            categoriasBindingSource.DataSource = cCategoria.ListadoCategorias();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            this.Close();
            this.Dispose();
            inv.Show();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres eliminar?", "Autorización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                CInventario cEliminar = new CInventario();
                inventarioBindingSource.EndEdit();
                cEliminar.EliminarInventario((Inventario)inventarioBindingSource.Current);
                MessageBox.Show("¡Producto eliminado con éxito!");
                Limpiar();
                this.Close();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Calculo();

            DialogResult result = MessageBox.Show("¿Estás seguro que quieres modificar?", "Autorización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                CInventario pEditar = new CInventario();
                inventarioBindingSource.EndEdit();
                pEditar.ActualizarInventario((Inventario)inventarioBindingSource.Current);
                MessageBox.Show("¡Producto editado con éxito!");
                Limpiar();
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombreProd.Enabled = true;
            cmbCategoria.Enabled = true;
            cmbProveedor.Enabled = true;
            txtExistencias.Enabled = true;
            txtCosto.Enabled = true;
            txtPrecioVenta.Enabled = true;

            inventarioBindingSource.MoveLast();
            inventarioBindingSource.AddNew();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Calculo();

            try
            {
                if (txtNombreProd.Text.Equals("") || txtExistencias.Text.Equals("") || txtCosto.Text.Equals("") || txtPrecioVenta.Text.Equals(""))
                {
                    MessageBox.Show("¡Rellene todos los campos!", "Rellenar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CInventario pnuevo = new CInventario();
                    inventarioBindingSource.EndEdit();
                    pnuevo.RegistrarInventario((Inventario)inventarioBindingSource.Current);
                    MessageBox.Show("¡Producto registrado con éxito!");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("¡Verifique las listas despleagables!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            Calculo();
        }

        void Calculo()
        {
            if (txtCosto.Text == null)
            {
                MessageBox.Show("No puedes ingresar costos menores a 0");
                txtCosto.Select();
            }
            else
            {
                try
                {
                    Double costo;
                    Double precioV;

                    costo = Double.Parse(txtCosto.Text);

                    precioV = ((costo * 0.13) + costo);
                    txtPrecioVenta.Text = precioV.ToString();
                }
                catch(Exception ex)
                {
                    txtCosto.Text = "0";
                    txtCosto.Select();
                }
            }
        }

        private void btnHabEdi_Click(object sender, EventArgs e)
        {
            txtNombreProd.Enabled = true;
            cmbCategoria.Enabled = true;
            cmbProveedor.Enabled = true;
            txtExistencias.Enabled = true;
            txtCosto.Enabled = true;
            txtPrecioVenta.Enabled = true;
        }

        void Limpiar()
        {
            txtNombreProd.Text = "";
            cmbCategoria.Text = "";
            cmbProveedor.Text = ";";
            txtExistencias.Text = "";
            txtCosto.Text = "";
            txtPrecioVenta.Text = "";
        }

        private void txtExistencias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
