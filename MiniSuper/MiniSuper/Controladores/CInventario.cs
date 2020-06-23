using MiniSuper.Entidades;
using MiniSuper.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Controladores
{
    public class CInventario
    {
        MInventario mInventario = new MInventario();

        public void RegistrarInventario(Inventario i)
        {
            mInventario.RegistrarInventario(i);
        }

        public void ActualizarInventario(Inventario i)
        {
            mInventario.ActualizarInventario(i);
        }

        public void EliminarInventario(Inventario i)
        {
            mInventario.EliminarInventario(i);
        }

        public List<Inventario> ListadoInventarios()
        {
            return mInventario.ListadoInventarios();
        }

        public List<Inventario> ListadoInventariosxPro(int pro)
        {
            return mInventario.ListadoInventariosxPro(pro);
        }
    }
}
