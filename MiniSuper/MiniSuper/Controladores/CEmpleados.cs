using MiniSuper.Entidades;
using MiniSuper.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Controladores
{
    public class CEmpleados
    {
        MEmpleados mEmpleados = new MEmpleados();

        public void RegistrarEmpleado(Empleados e)
        {
            mEmpleados.RegistrarEmpleado(e);
        }

        public void ActualizarEmpleado(Empleados e)
        {
            mEmpleados.ActualizarEmpleado(e);
        }

        public void EliminarEmpleado(Empleados e)
        {
            mEmpleados.EliminarEmpleado(e);
        }

        public List<Empleados> ListadoEmpleados()
        {
            return mEmpleados.ListadoEmpleados();
        }
    }
}
