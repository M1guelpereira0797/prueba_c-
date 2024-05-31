using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using clase11.Database;
using clase11.Models;



namespace clase11.Database
{
    public class GestorBaseDatos : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connecxionString = @"Server=localhost\SQLEXPRESS01;Database=SistemaGestion;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connecxionString);
        }

    }


} 

