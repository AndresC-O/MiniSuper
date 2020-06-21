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
    public partial class FrmComprar : Form
    {
        public FrmComprar()
        {
            InitializeComponent();
        }

        CEmpleados cEmpleados = new CEmpleados();
        CProveedores cProveedores = new CProveedores();
        CInventario cInventario = new CInventario();

        public BindingList<DetallesCompra> detalles = new BindingList<DetallesCompra>();
        void Calculo()
        {
            if (cantidadNumericUpDown.Text == null)
            {
                MessageBox.Show("No puedes ingresar costos menores a 0");
                cantidadNumericUpDown.Select();
            }
            else
            {
                try
                {
                    Double precio;
                    Double totalPagar;
                    int cant;

                    precio = Double.Parse(precioTextBox.Text);
                    cant = Convert.ToInt32(cantidadNumericUpDown.Value);

                    totalPagar = (precio * cant);
                    totalTextBox.Text = totalPagar.ToString();
                }
                catch (Exception ex)
                {
                    cantidadNumericUpDown.Value = 0;
                    cantidadNumericUpDown.Select();
                }
            }
        }

        public void Limpiar()
        {
            idEmpleadoComboBox.Items.Clear();
            idProveedorComboBox.Items.Clear();
            idInventarioComboBox.Items.Clear();
            precioTextBox.Text = "";
            cantidadNumericUpDown.Value.Equals(0);
            totalTextBox.Text = "";
        }

        void CalcularTotalFinal()
        {
            Double Suma = 0;
            for (int i = 0; i < detallesCompraDataGridView.RowCount; i++)
            {
                String DatosAOperar = detallesCompraDataGridView.Rows[i].Cells[5].Value.ToString();
                Double DatosCovertidos = Convert.ToDouble(DatosAOperar);

                Suma += DatosCovertidos;
                totalCompraTextBox.Text = Suma.ToString();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            AccesoGerente ag = new AccesoGerente();
            ag.Show();
        }

        private void FrmComprar_Load(object sender, EventArgs e)
        {
            empleadosBindingSource.DataSource = cEmpleados.ListadoEmpleados();
            proveedoresBindingSource.DataSource = cProveedores.ListadoProveedores();
            inventarioBindingSource.DataSource = cInventario.ListadoInventarios();

            idEmpleadoComboBox.Enabled = false;
            idProveedorComboBox.Enabled = false;
            idInventarioComboBox.Enabled = false;
            precioTextBox.Enabled = false;
            cantidadNumericUpDown.Enabled = false;
            totalTextBox.Enabled = false;

            detallesCompraDataGridView.Enabled = false;
        }

        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            idEmpleadoComboBox.Enabled = true;
            idProveedorComboBox.Enabled = true;
            idInventarioComboBox.Enabled = true;
            precioTextBox.Enabled = true;
            cantidadNumericUpDown.Enabled = true;
            totalTextBox.Enabled = true;

            comprasBindingSource.MoveLast();
            comprasBindingSource.AddNew();

            detallesCompraBindingSource.MoveLast();
            detallesCompraBindingSource.AddNew();

            detallesCompraDataGridView.Enabled = true;
            detallesCompraDataGridView.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (precioTextBox.Text.Equals("0") && cantidadNumericUpDown.Value.Equals(0) && totalTextBox.Text.Equals("0"))
            {
                MessageBox.Show("¡Complete todos los campos!", "Rellenar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                detalles.Add((DetallesCompra)detallesCompraBindingSource.Current);
                detallesCompraBindingSource1.DataSource = detalles;
                detallesCompraBindingSource1.ResetBindings(true);

                detallesCompraBindingSource.EndEdit();
                detallesCompraBindingSource.AddNew();

                CalcularTotalFinal();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(detallesCompraDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("¡Aún no hay nada en el carrito!", "Rellenar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                comprasBindingSource.EndEdit();
                Compras co = new Compras();
                co = ((Compras)comprasBindingSource.Current);
                CCompras cCompras = new CCompras();
                cCompras.RegistrarCompra(co);

                CDetallesCompra cDetalles = new CDetallesCompra();
                cDetalles.GuardarMaestroDetalle(detalles);

                MessageBox.Show("¡Compra Realizada con éxito!", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            detallesCompraDataGridView.Rows.Clear();
        }

        private void cantidadNumericUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            Calculo();
        }

        private void detallesCompraDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcularTotalFinal();
        }

        private void totalTextBox_TextChanged(object sender, EventArgs e)
        {
            Calculo();
        }
      
    }
}
