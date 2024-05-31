using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Desafio_1.models
{
    public class Producto
    {
        private int _id;
        private string _descripcion;
        private float _costo;
        private float _precioVenta;
        private int _stock;
        private string _idUsuario;




        public Producto(int id, string descripcion, float costo, float precioVenta, int stock, string idUsuario)
        {
            _id = id;
            _descripcion = descripcion;
            _costo = costo;
            _precioVenta = precioVenta;
            _stock = stock;
            _idUsuario = idUsuario;


        }


    }
}
