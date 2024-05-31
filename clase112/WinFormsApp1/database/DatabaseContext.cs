using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using WinFormsApp1.models;

namespace WinFormsApp1.database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=localhost\SQLEXPRESS01;Database=BasePrueba3;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);  

        }

        
    }
}
