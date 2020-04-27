using MiniSuper.Entidades;
using MiniSuper.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Controladores
{
    public class CProveedores
    {
        MProveedores mProveedores = new MProveedores();

        public void RegistrarProveedor(Proveedores pr)
        {
            mProveedores.RegistrarProveedor(pr);
        }

        public void ActualizarProveedor(Proveedores pr)
        {
            mProveedores.ActualizarProveedor(pr);
        }

        public void EliminarProveedor(Proveedores pr)
        {
            mProveedores.EliminarProveedor(pr);
        }

        public List<Proveedores> ListadoProveedores()
        {
            return mProveedores.ListadoProveedores();
        }
    }
}
