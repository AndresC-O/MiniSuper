﻿using MiniSuper.Controladores;
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
        public void Envio()
        {
            String idPrd = inventarioDataGridView.CurrentRow.Cells[0].Value.ToString();
            int idPrdConv = Convert.ToInt32(idPrd);
            String nombreProd = inventarioDataGridView.CurrentRow.Cells[1].Value.ToString();
            String precio = inventarioDataGridView.CurrentRow.Cells[6].Value.ToString();

            MenuBotones.ventas.idInventarioComboBox.SelectedValue = idPrdConv;
            MenuBotones.ventas.precioTextBox.Text = precio;

            AccesoCajero.v.idInventarioComboBox.SelectedValue = idPrdConv;
            AccesoCajero.v.precioTextBox.Text = precio;

            MenuBotones.ventas.cantidadNumericUpDown.Focus();
            AccesoCajero.v.cantidadNumericUpDown.Focus();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Envio();
            this.Close();
        }

        private void frmBuscarProducto_Load(object sender, EventArgs e)
        {
            inventarioBindingSource.DataSource = cInventario.ListadoInventarios();
        }

        private void inventarioDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Envio();
                this.Close();
                MenuBotones.ventas.cantidadNumericUpDown.Value = 0;
            }
        }

        private void inventarioDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Envio();
            this.Close();
            MenuBotones.ventas.cantidadNumericUpDown.Value = 0;
        }
    }
}
