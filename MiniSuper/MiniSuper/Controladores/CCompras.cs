using MiniSuper.Entidades;
using MiniSuper.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Controladores
{
    public class CCompras
    {
        MCompras mCompra = new MCompras();

        public void RegistrarCompra(Compras c)
        {
            mCompra.RegistrarCompra(c);
        }

        public void EliminarCompra(Compras c)
        {
            mCompra.EliminarCompra(c);
        }

        public List<Compras> ListadoCompras()
        {
            return mCompra.ListadoCompras();
        }
    }
}
