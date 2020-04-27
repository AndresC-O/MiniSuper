using MiniSuper.Entidades;
using MiniSuper.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Controladores
{
    public class CFacturaConsumidoresFinales
    {
        MFacturaConsumidoresFinales mFacturaCF = new MFacturaConsumidoresFinales();

        public void RegistrarFacturaConsFinal(FacturasConsumidoresFinales fcf)
        {
            mFacturaCF.RegistrarFacturaConsFinal(fcf);
        }

        public void ActualizarFacturaConsFinal(FacturasConsumidoresFinales fcf)
        {
            mFacturaCF.ActualizarFacturaConsFinal(fcf);
        }

        public void EliminarFacturaConsFinal(FacturasConsumidoresFinales fcf)
        {
            mFacturaCF.EliminarFacturaConsFinal(fcf);
        }

        public List<FacturasConsumidoresFinales> ListadoFacturasConsFinal()
        {
            return mFacturaCF.ListadoFacturasConsFinal();
        }
    }
}
