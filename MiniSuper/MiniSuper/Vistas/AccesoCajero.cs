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

namespace MiniSuper.Vistas
{
    public partial class AccesoCajero : Form
    {
        Loguin lo = new Loguin();
        public AccesoCajero()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres salir?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que desea cerrar la sesión actual?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {

                lo.Show();
                this.Close();
            }
        }

        public static frmVentas v = new frmVentas();
        private void AccesoCajero_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = lo.txtUsuario.Text;
            lblHora.Text = DateTime.Now.ToShortTimeString();
            
            v.MdiParent = this;
            v.Dock = DockStyle.Fill;
            v.Show();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
