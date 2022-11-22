using Data;
using Domain.Negocio;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ClienteService
    {
        ClienteHandler clienteHandler = new ClienteHandler();
        public void GuardarCliente(Cliente cliente)
        {
            clienteHandler.Insert(cliente);
        }

        public List<Cliente> BuscarXDNI(int dni)
        {
            var cliente = clienteHandler.Get();
            var clienteBuscado = cliente.Where(cliente => cliente.DNI.Equals(dni));

            return clienteBuscado.ToList();
        }
    }
}
