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


namespace MiniSuper
{
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }

        private void Loguin_Load(object sender, EventArgs e)
        {

        }

      
        private void btnAcceder_Click_1(object sender, EventArgs e)
        {
            using (MiniSuperEntities bd = new MiniSuperEntities())
            {
                var lista = from em in bd.Empleados
                            where em.contrasenia == contraseniaTextBox.Text
                            && em.usuario == usuarioTextBox.Text
                            select em;

                if (lista.Count() > 0)
                {
                    var cargo = from emp in bd.Empleados
                                where emp.usuario == usuarioTextBox.Text

                                select new
                                {
                                    emp.idCargo
                                };

                    foreach (var iterar in cargo)
                    {
                        if(iterar.idCargo == 1)
                        {
                            MessageBox.Show("Funciona, su cargo es: Gerente");
                        }
                        else if(iterar.idCargo == 2)
                        {
                            MessageBox.Show("Funciona, su cargo es: Cajero");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no existe.");
                }

            }
        }
    }
}
