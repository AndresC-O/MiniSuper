using MiniSuper.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniSuper.Entidades;

namespace MiniSuper.Controladores
{
    public class CCargos
    {
        MCargos mCargo = new MCargos();

        public void RegistrarCargo(Cargos c)
        {
            mCargo.RegistrarCargo(c);
        }

        public void ActualizarCargo(Cargos c)
        {
            mCargo.ActualizarCargo(c);
        }

        public void EliminarCargo(Cargos c)
        {
            mCargo.EliminarCargo(c);
        }

        public List<Cargos> ListadoCargos()
        {
            return mCargo.ListadoCargos();
        }
    }
}
