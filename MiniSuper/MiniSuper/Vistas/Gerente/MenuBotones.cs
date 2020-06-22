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
        public MenuBotones()
        {
            InitializeComponent();
            PanelContenedor.Visible = false;
        }

        public void Invertir()
        {
            PanelContenedor.Dispose();
            PanelContenedor.Visible = false;
            flpPanelScroll.AutoScroll = false;
        }

        public void AbrirFormHijo(object formhijo)
        {
            flpPanelScroll.AutoScroll = false;
            PanelContenedor.Visible = true;
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

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
            AbrirFormHijo(new ListadoClientes());
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {
           
        }

        private void pnVenta_Click(object sender, EventArgs e)
        {
            
        }

        public static frmVentas ventas = new frmVentas();
        private void pbVenta_Click(object sender, EventArgs e)
        {
            //AbrirFormHijo(new frmVentas());
            flpPanelScroll.AutoScroll = false;
            PanelContenedor.Visible = true;
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            ventas.TopLevel = false;
            ventas.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(ventas);
            this.PanelContenedor.Tag = ventas;
            ventas.Show();
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
            AbrirFormHijo(new ListadoCategorias());
        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {
            
        }

        private void pbProducto_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new ListadoInventario());
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
            AbrirFormHijo(new ListadoEmpleados());
        }

        private void lblEmpleado_Click(object sender, EventArgs e)
        {
            
        }

        private void pnProveedor_Click(object sender, EventArgs e)
        {
            
        }

        private void pbProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new ListadoProveedores());
        }

        private void lblProveedor_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbDocumentos_Click(object sender, EventArgs e)
        {

        }

        private void pbComprar_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FrmComprar());
        }
    }
}
