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
using MiniSuper.Model;
using MiniSuper.Vistas;
using MiniSuper.Vistas.Gerente;

namespace MiniSuper
{
    public partial class Loguin : Form
    {
        frmVentas ven = new frmVentas();
        public static AccesoGerente manager = new AccesoGerente();

        public Loguin()
        {
            InitializeComponent();
            txtContra.UseSystemPasswordChar = true;
        }

        private void Loguin_Load(object sender, EventArgs e)
        {

        }

        void Limpiar()
        {
            txtUsuario.Text = "";
            txtContra.Text = "";
        }
      
        private void btnAcceder_Click_1(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Equals("") || txtContra.Text.Equals(""))
            {
                MessageBox.Show("¡Todos los campos son obligatorios!", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (MiniSuperEntities1 bd = new MiniSuperEntities1())
                {
                    Empleado emp = new Empleado();

                    var lista = from em in bd.Empleados
                                where em.contrasenia == txtContra.Text
                                && em.usuario == txtUsuario.Text && em.estado == "Activo"

                                select new
                                {
                                    em.cargo
                                };

                    if (lista.Count() > 0)
                    {
                        string usuario = txtUsuario.Text;

                        emp = bd.Empleados.Where(Buscar => Buscar.usuario == usuario).First();
                        int cargo = emp.cargo;

                        
                            if (cargo == 1)
                            {                                
                                manager.Show();
                                manager.lblUsuario.Text = txtUsuario.Text;

                                this.Hide();
                                Limpiar();
                            }
                            else if (cargo == 2)
                            {
                            AccesoCajero acj = new AccesoCajero();
                            acj.Show();
                            
                                
                            }
                        
                    }
                    else
                    {
                        MessageBox.Show("¡El usuario ingresado no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Limpiar();
                    }

                }
            }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres salir?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void cbVerContra_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVerContra.CheckState == CheckState.Checked)
            {
                txtContra.UseSystemPasswordChar = false;
            }
            else if (cbVerContra.CheckState == CheckState.Unchecked)
            {
                txtContra.UseSystemPasswordChar = true;
            }
        }
    }
}
