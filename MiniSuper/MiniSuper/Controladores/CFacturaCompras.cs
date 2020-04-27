using MiniSuper.Entidades;
using MiniSuper.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Controladores
{
    public class CFacturaCompras
    {
        MFacturaCompras mFacturaCompras = new MFacturaCompras();

        public void RegistrarFacturaCompra(FacturasCompras fc)
        {
            mFacturaCompras.RegistrarFacturaCompra(fc);
        }

        public void ActualizarFaturaCompra(FacturasCompras fc)
        {
            mFacturaCompras.ActualizarFaturaCompra(fc);
        }

        public void EliminarFacturaCompra(FacturasCompras fc)
        {
            mFacturaCompras.EliminarFacturaCompra(fc);
        }

        public List<FacturasCompras> ListadoFactsCompras()
        {
            return mFacturaCompras.ListadoFactsCompras();
        }
    }
}
