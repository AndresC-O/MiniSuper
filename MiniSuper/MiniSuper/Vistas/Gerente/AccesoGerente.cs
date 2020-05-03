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
    public partial class AccesoGerente : Form
    {
        public AccesoGerente()
        {
            InitializeComponent();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres salir?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void cERRARSESIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que desea cerrar la sesión actual?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Loguin loguin = new Loguin();
                loguin.Show();
                this.Close();
            }
        }

        private void AccesoGerente_Load(object sender, EventArgs e)
        {
            Loguin lo = new Loguin();
            label2.Text = lo.txtUsuario.Text;
        }
    }
}
