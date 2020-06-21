using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniSuper.Controladores;
using MiniSuper.Entidades;


namespace MiniSuper.Vistas.Gerente
{
    public partial class frmVentas : Form
    {
        Inventario inv = new Entidades.Inventario();
        public frmVentas()
        {
            InitializeComponent();
        }

        public frmVentas(Inventario inven)
        {
            InitializeComponent();
            this.inv = inven;
        }

        CDocumentos cDocumentos = new CDocumentos();
        CEmpleados cEmpleados = new CEmpleados();
        CClientes cCliente = new CClientes();
        CInventario cInventario = new CInventario();

        public BindingList<DetallesVenta> detalles = new BindingList<DetallesVenta>();

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
            idDocumentoComboBox.Items.Clear();
            idClienteComboBox.Items.Clear();
            //idInventarioComboBox.Items.Clear();
            precioTextBox.Text = "";
            cantidadNumericUpDown.Value.Equals(0);
            totalTextBox.Text = "";
        }

        void CalcularTotalFinal()
        {
            Double Suma = 0;
            for (int i = 0; i < detallesVentaDataGridView.RowCount; i++)
            {
                String DatosAOperar = detallesVentaDataGridView.Rows[i].Cells[5].Value.ToString();
                Double DatosCovertidos = Convert.ToDouble(DatosAOperar);

                Suma += DatosCovertidos;
                totalVentaTextBox.Text = Suma.ToString();
            }
        }

        private void totalVentaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            inventarioBindingSource1.DataSource = inv;
            empleadosBindingSource.DataSource = cDocumentos.ListadoDocumentos(); 
            empleadosBindingSource.DataSource = cEmpleados.ListadoEmpleados();
            clientesBindingSource.DataSource = cCliente.ListadoClientes();
            //inventarioBindingSource.DataSource = cInventario.ListadoInventarios();

            idEmpleadoComboBox.Enabled = false;
            idClienteComboBox.Enabled = false;
            idDocumentoComboBox.Enabled = false;
            btnBuscarProdcuto.Enabled = false;
            idInventarioComboBox.Enabled = false;
            precioTextBox.Enabled = false;
            cantidadNumericUpDown.Enabled = false;
            totalTextBox.Enabled = false;

            detallesVentaDataGridView.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            AccesoGerente ag = new AccesoGerente();
            ag.Show();
        }

        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            idEmpleadoComboBox.Enabled = true;
            idClienteComboBox.Enabled = true;
            idDocumentoComboBox.Enabled = true;
            //idInventarioComboBox.Enabled = true;
            btnBuscarProdcuto.Enabled = true;
            cantidadNumericUpDown.Enabled = true;           

            ventasBindingSource.MoveLast();
            ventasBindingSource.AddNew();

            detallesVentaBindingSource.MoveLast();
            detallesVentaBindingSource.AddNew();

            detallesVentaDataGridView.Enabled = true;
            detallesVentaDataGridView.Rows.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (precioTextBox.Text.Equals("0") || cantidadNumericUpDown.Value.Equals(0) || totalTextBox.Text.Equals("0"))
            {
                MessageBox.Show("¡Complete todos los campos!", "Rellenar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                detalles.Add((DetallesVenta)detallesVentaBindingSource.Current);
                detallesVentaBindingSource1.DataSource = detalles;
                detallesVentaBindingSource1.ResetBindings(true);

                detallesVentaBindingSource.EndEdit();
                detallesVentaBindingSource.AddNew();

                CalcularTotalFinal();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (detallesVentaDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("¡Aún no hay nada en el carrito!", "Rellenar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ventasBindingSource.EndEdit();
                Ventas ven = new Ventas();
                ven = ((Ventas)ventasBindingSource.Current);
                CVentas cVentas = new CVentas();
                cVentas.RegistrarVenta(ven);

                CDetallesVenta cDetalles = new CDetallesVenta();
                cDetalles.GuardarMaestroDetalle(detalles);

                MessageBox.Show("¡Compra Realizada con éxito!", "Compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            detallesVentaDataGridView.Rows.Clear();
        }

        private void detallesVentaDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcularTotalFinal();
        }

        private void totalTextBox_TextChanged(object sender, EventArgs e)
        {
            Calculo();
        }

        private void cantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Calculo();
        }

        private void btnBuscarProdcuto_Click(object sender, EventArgs e)
        {
            frmBuscarProducto bp = new frmBuscarProducto();
            bp.Show();
        }
    }
}
