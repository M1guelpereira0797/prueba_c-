using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    public class Usuario
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private int _contrasena;
        private string _mail;




        public Usuario( int id, string nombre, string apellido, string nombreUsuario, int contrasena, string mail)
            {
                this._id = id;
                this._nombre = nombre;  
                this._apellido = apellido;  
                this._nombreUsuario = nombreUsuario;
                this._contrasena = contrasena;
                this._mail = mail;
                   
            }


    }
}
