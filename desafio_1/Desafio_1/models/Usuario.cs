using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1.models
{
    public class Usuario
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private int _contrasena;
        private string _mail;




        public Usuario(int id, string nombre, string apellido, string nombreUsuario, int contrasena, string mail)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _nombreUsuario = nombreUsuario;
            _contrasena = contrasena;
            _mail = mail;

        }


    }
}
