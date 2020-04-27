using MiniSuper.Entidades;
using MiniSuper.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Controladores
{
    public class CCategoria
    {
        MCategorias mCategoria = new MCategorias();

        public void RegistrarCategoria(Categorias ca)
        {
            mCategoria.RegistrarCategoria(ca);
        }

        public void ActualizarCategoria(Categorias ca)
        {
            mCategoria.ActualizarCategoria(ca);
        }

        public void EliminarCategoria(Categorias ca)
        {
            mCategoria.EliminarCategoria(ca);
        }

        public List<Categorias> ListadoCategorias()
        {
            return mCategoria.ListadoCategorias();
        }
    }
}
