using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creacion_nuevo_usuario_parte2
{
    public class Producto
    {
        private int _numero;
        private string _descripcion;
        private string _categoria;
        private double _preciodeventa;
        private double _preciodecompra;


        public Producto(int numero,string descripcion, string categoria, double preciodecompra, double preciodeventa)
        {
            //ahora => antes 

            this._numero= numero;   //numero = 0;
            this._descripcion = descripcion;//descripcion =   string.Empty;
            this._categoria = categoria;//categoria = string.Empty;   
            this._preciodecompra = preciodecompra;//preciodecompra = 0;
            this._preciodeventa = preciodeventa; //preciodeventa = 0;  
            
         }

        public bool haypreciodeventa()
        {
            return this._preciodeventa > 0;  
        }
        public int numero 
        {
            get
            {
                return this._numero;
            }       
            set
            {
                this._numero = value;
            }
        }
        public string descripcion
        {
            get
            {
                return this._descripcion;
            }
            set
            {
                this._descripcion = value;
            }




        }
        public string categoria
        {
            get
            {
                if (!string.IsNullOrEmpty(this._categoria))
                {
                    return this._categoria;
                }
                else
                {
                    return "Sin categoria";
                }
            }
            set
            {
                this._categoria = value;
            }




        }
        public double preciodecompra { get; set; }
        public double preciodeventa { get; set; }

    }
}

