using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Desafio_1
{
    public class Venta
    {
        protected int id { get; set; }
        protected string comentarios { get; set; }

        protected string idUsuario { get; set; }






        public Venta(int id, string comentarios, string idUsuario)
        {
            this.id = id;
            this.comentarios = comentarios;
            this.idUsuario = idUsuario;
        }
    }
}
