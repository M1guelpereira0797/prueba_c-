using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using ProyectodesdeCero.Database;
using ProyectodesdeCero.Models;
using System.Data.SqlClient;

namespace ProyectodesdeCero.Models
{
    public class Usuario
    { 
        public string Id { get; set; }
        public string Nombre { get; set; }

        public string Apellido{ get; set; }
        public string Domicilio { get; set; }
        public int Telefono { get; set; }
    
    
    }

}
   