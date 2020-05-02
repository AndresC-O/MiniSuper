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

namespace MiniSuper
{
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }

        CEmpleados cEmp = new CEmpleados();

        private void Loguin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Equals("")|| txtContra.Text.Equals(""))
            {
                MessageBox.Show("¡Complete todos los campos \npara iniciar sesión!", "Completar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Empleados emp = new Empleados();
                emp.usuario = txtUsuario.Text;
                emp.contrasenia = txtContra.Text;

                empleadosBindingSource.MoveLast();
                cEmp.Loguin(emp);

                if (empleadosBindingSource.Count > 0)
                {
                    MessageBox.Show("SE PUDOOOOOOOOOOOOOOOOOOO");
                }
                else
                {
                    MessageBox.Show("AUN NO CRACK :'v");
                }
            }
        }
    }
}
