using MiniSuper.Entidades;
using MiniSuper.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Controladores
{
    public class CDetallesCompra
    {
        MDetallesCompra mDetallesCompra = new MDetallesCompra();

        public void RegistrarDetalleCompra(DetallesCompra dc)
        {
            mDetallesCompra.RegistrarDetalleCompra(dc);
        }

        public void EliminarDetalleCompra(DetallesCompra dc)
        {
            mDetallesCompra.EliminarDetalleCompra(dc);
        }

        public List<DetallesCompra> ListadoDetallesCompra()
        {
            return mDetallesCompra.ListadoDetallesCompra();
        }
    }
}
