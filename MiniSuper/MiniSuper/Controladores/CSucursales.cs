using MiniSuper.Entidades;
using MiniSuper.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Controladores
{
    public class CSucursales
    {
        MSucursales mSucursales = new MSucursales();

        public void RegistrarSucursal(Sucursales s)
        {
            mSucursales.RegistrarSucursal(s);
        }

        public void ActualizarSucursal(Sucursales s)
        {
            mSucursales.ActualizarSucursal(s);
        }

        public void EliminarSucursal(Sucursales s)
        {
            mSucursales.EliminarSucursal(s);
        }

        public List<Sucursales> ListadoSucursales()
        {
            return mSucursales.ListadoSucursales();
        }
    }
}
