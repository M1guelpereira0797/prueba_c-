using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using ProyectodesdeCero.Database;
using ProyectodesdeCero.Models;



namespace ProyectodesdeCero.Database
{
    public class GestorBaseDatos : DbContext        
    {
        
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connecxionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion1;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connecxionString);
        }

    }


}
