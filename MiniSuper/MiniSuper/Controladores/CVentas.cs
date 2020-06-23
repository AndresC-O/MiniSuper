using MiniSuper.Entidades;
using MiniSuper.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Controladores
{
    public class CVentas
    {
        MVentas mVentas = new MVentas();

        public void RegistrarVenta(Ventas v)
        {
            mVentas.RegistrarVenta(v);
        }

        public void EliminarVenta(Ventas v)
        {
            mVentas.EliminarVenta(v);
        }

        public List<Ventas> ListadoVentas()
        {
            return mVentas.ListadoVentas();
        }

        public List<Ventas> RetornoId()
        {
            return mVentas.RetornoId();
        }
    }
}
