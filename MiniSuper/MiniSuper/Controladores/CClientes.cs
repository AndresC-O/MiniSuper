using MiniSuper.Entidades;
using MiniSuper.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Controladores
{
    public class CClientes
    {
        MClientes mCliente = new MClientes();

        public void RegistrarCliente(Clientes cl)
        {
            mCliente.RegistrarCliente(cl);
        }

        public void ActualizarCliente(Clientes cl)
        {
            mCliente.ActualizarCliente(cl);
        }

        public void EliminarCliente(Clientes cl)
        {
            mCliente.EliminarCliente(cl);
        }

        public List<Clientes> ListadoClientes()
        {
            return mCliente.ListadoClientes();
        }
    }
}
