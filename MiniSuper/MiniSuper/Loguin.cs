﻿using System;
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
                using (MiniSuperEntities bd = new MiniSuperEntities())
                {
                    var lista = from em in bd.Empleados
                                where em.contrasenia == txtContra.Text
                                && em.usuario == txtUsuario.Text
                                select em;

                    if (lista.Count() > 0)
                    {
                        var cargo = from emp in bd.Empleados
                                    where emp.usuario == txtUsuario.Text

                                    select new
                                    {
                                        emp.idCargo
                                    };

                        foreach (var iterar in cargo)
                        {
                            if (iterar.idCargo == 1)
                            {
                                MessageBox.Show("Funciona, su cargo es: Gerente");
                                Limpiar();
                            }
                            else if (iterar.idCargo == 2)
                            {
                                MessageBox.Show("Funciona, su cargo es: Cajero");
                                Limpiar();
                            }
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres salir?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
