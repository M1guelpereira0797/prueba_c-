using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_usuario
{
    public class Usuario
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private string _id;
        private int _contrasena;
        private int _RUT;
        private string _domicilio;
        private string _mail;

        public Usuario(string nombre, string apellido, int edad, string id, int contrasena, int rut, string domicilio, string mail)
        {
            
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._id = id;
            this._contrasena = contrasena;
            this._RUT = rut;
            this._domicilio = domicilio;
            this._mail = mail;

        }
        public string mail
        {
            get
            {
                return this._mail;
            }
            set
            {
                this._mail = value;
            }

         }
        public bool Esmayordeedad()
        {
            return this._edad >= 18;
        }
        public string Cambiardireccion(string nuevodireccion)
        {
            this._domicilio = nuevodireccion;

            return this._domicilio;
        }
        public bool gmaile()
        {
            if(this._mail.EndsWith("gmail.com"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
    

}
