using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Desafio_1
{
    public class Producto
    {
        private int _id;
        private string _descripcion;
        private float _costo;
        private float _precioVenta;
        private int _stock;
        private string _idUsuario;




        public Producto(int id, string descripcion, float costo, float precioVenta, int stock , string idUsuario)
        {
            this._id = id;
            this._descripcion = descripcion;
            this._costo = costo;
            this._precioVenta = precioVenta;
            this._stock = stock;
            this._idUsuario = idUsuario;


        }


    }
}
