using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteABM
{
    public class ListaDeMayores
    {
        public List<Cliente> _clientesMayores;

        public ListaDeMayores()
        {
            _clientesMayores = new List<Cliente>();

        }
        public void InsertarEnLista(Cliente[] clientes )
        {
            for (int i = 0; i < clientes.Length; i++) 
            {
                _clientesMayores.Add(new Cliente(clientes[i].Nombre, clientes[i].Direccion, clientes[i].ID, clientes[i].Edad));
            }
        }
        public bool Borrar(Cliente cliente)
        {
            if(!_clientesMayores.Contains(cliente))
            {
                return false;
            }
            return _clientesMayores.Remove(cliente);
        }
        public int Buscar(Cliente cliente)
        {
            return _clientesMayores.IndexOf(cliente);
        }
        public List<Cliente> GetListaMayores()
        {
            return _clientesMayores;
        }
        public bool Modificar(Cliente clienteActual, Cliente clienteNuevo)
        {
            int posicion = Buscar(clienteActual);
            if (posicion < 0)
            {
                return false;
            }

            _clientesMayores[posicion] = clienteNuevo; 
            return true;
        }
    }

}
