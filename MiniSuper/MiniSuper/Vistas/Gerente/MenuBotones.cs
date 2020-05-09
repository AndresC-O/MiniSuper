using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniSuper.Vistas.Gerente;



namespace MiniSuper.Vistas.Gerente
{
    public partial class MenuBotones : Form
    {

        AccesoGerente ag = new AccesoGerente();

        public MenuBotones()
        {
            InitializeComponent();
        }

        void CargarFrmCargo()
        {
            
        }

        void CargarFrmCategoria()
        {
            
        }

        void CargarFrmCliente()
        {
           
        }

        void CargarFrmEmpleado()
        {
           
        }

        void CargarFrmProducto()
        {
            ListadoInventario inv = new ListadoInventario();
            this.Close();
            this.Dispose();
            ag.Dispose();
            ag.Close();
            inv.Show();

        }

        

        private void MenuBotones_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void panel6_Click(object sender, EventArgs e)
        {
            
        }

        private void pnCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void pbCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {
           
        }

        private void pnVenta_Click(object sender, EventArgs e)
        {
            
        }

        private void pbVenta_Click(object sender, EventArgs e)
        {
            
        }

        private void lblVenta_Click(object sender, EventArgs e)
        {
            
        }

        private void pnCargo_Click(object sender, EventArgs e)
        {
            
        }

        private void pbCargo_Click(object sender, EventArgs e)
        {
           
        }

        private void lblCargo_Click(object sender, EventArgs e)
        {
            
        }

        private void pnCategoria_Click(object sender, EventArgs e)
        {
           
        }

        private void pbCategoria_Click(object sender, EventArgs e)
        {
            
        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {
            
        }

        private void pbProducto_Click(object sender, EventArgs e)
        {
            CargarFrmProducto();
        }

        private void lblProducto_Click(object sender, EventArgs e)
        {
            
        }

        private void pnSucursal_Click(object sender, EventArgs e)
        {
           
        }

        private void pbSucursal_Click(object sender, EventArgs e)
        {
            
        }

        private void lblSucursal_Click(object sender, EventArgs e)
        {
            
        }

        private void pnEmpleado_Click(object sender, EventArgs e)
        {
            
        }

        private void pbEmpleado_Click(object sender, EventArgs e)
        {
            
        }

        private void lblEmpleado_Click(object sender, EventArgs e)
        {
            
        }

        private void pnProveedor_Click(object sender, EventArgs e)
        {
            
        }

        private void pbProveedor_Click(object sender, EventArgs e)
        {
           
        }

        private void lblProveedor_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
