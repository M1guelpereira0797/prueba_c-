using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.models
{
    public class ProductoVendido
    {
        private int _id;
        private int _idProducto;
        private int _stock;
        private int _idVenta;


        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            _id = id;
            _idProducto = idProducto;
            _stock = stock;
            _idVenta = idVenta;
        }
    }
}
