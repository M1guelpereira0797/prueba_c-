﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.models
{
    public class Cliente
    { 
        public int id { get; set; }
        public string Nombre { get; set; }   
        public string Apellido { get; set; }

        public string Domicilio { get; set; }
        public int Telefono { get; set;  }
    }
}
