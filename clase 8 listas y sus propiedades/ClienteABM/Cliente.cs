using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteABM
{
    public class Cliente
    {
       

        public string nombre { get; set; }
        public string direccion { get; set; }

        public int iD { get; set; }
        public int edad { get; set; }


        /*
          public Cliente()
         {
             this.nombre = nombre;
             this.direccion = direccion;
             this.iD = iD;
             this.edad = edad;
         }
         * 
         * 
         * public override bool Equals(object? obj)
         {
             Cliente cliente = (Cliente)obj;
             return this.ID.Equals(cliente.ID);
         }*/
    }
}
