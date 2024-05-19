using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteABM
{
    /*public class ListaDeMayores
    {
        public List<Cliente> _clientesMayores;

        public ListaDeMayores()
        {
            _clientesMayores = new List<Cliente>();

        }
        /*public void InsertarEnLista(Cliente[] clientes )
        {
            for (int i = 0; i < clientes.Length; i++) 
            {
                _clientesMayores.Add(new Cliente(clientes[i].nombre, clientes[i].direccion, clientes[i].iD, clientes[i].edad));
            }
        }*/
       /* public bool Borrar(Cliente cliente)
        {
            /*if(!_clientesMayores.Contains(cliente))
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
        public void LimpiarLista()
        {
            _clientesMayores.Clear();
        }
        public int CompararCliente( Cliente cliente1, Cliente cliente2)
        {
            return cliente1.iD.CompareTo(cliente2.iD);
        }
        public void Ordenar()
        {
            _clientesMayores.Sort(CompararCliente);
        }
    }
       */

   
}
