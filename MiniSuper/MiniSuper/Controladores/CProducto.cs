using MiniSuper.Entidades;
using MiniSuper.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Controladores
{
    public class CProducto
    {
        MProductos mProducto = new MProductos();

        public void RegistrarProducto(Productos p)
        {
            mProducto.RegistrarProducto(p);
        }

        public void ActualizarProducto(Productos p)
        {
            mProducto.ActualizarProducto(p);
        }

        public void EliminarProducto(Productos p)
        {
            mProducto.EliminarProducto(p);
        }

        public List<Productos> ListadoProductos()
        {
            return mProducto.ListadoProductos();
        }
    }
}
