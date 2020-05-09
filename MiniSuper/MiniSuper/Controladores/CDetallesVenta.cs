using MiniSuper.Entidades;
using MiniSuper.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Controladores
{
    public class CDetallesVenta
    {
        MDetallesVenta mDetallesVenta = new MDetallesVenta();

        public void RegistrarDetalleVenta(DetallesVenta dv)
        {
            mDetallesVenta.RegistrarDetalleVenta(dv);
        }

        public void EliminarDetalleVenta(DetallesVenta dv)
        {
            mDetallesVenta.EliminarDetalleVenta(dv);
        }

        public List<DetallesVenta> ListadoDetallesVenta()
        {
            return mDetallesVenta.ListadoDetallesVenta();
        }
    }
}
