using System.Data.SqlClient;
using App1.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Models;


namespace App.Models
{   
    
    public class Program
    {
        
        static void Main(string[] args)
        {
            GestorBaseDeDatos gestorBaseDeDatos = new GestorBaseDeDatos();

            try
            {

                // if (gestorBaseDeDatos.DeleteUser(7))
                // {
                //     Console.WriteLine("Usuario eliminado");
                // }

                Usuario newUser = new Usuario("Carlos", "Perez", "peres32", "123456789", "carlo@mail.com");
                //if(gestorBaseDeDatos.CreateUser(newUser))
                //{
                //    Console.WriteLine("Usuario creado!");
                //}
                Usuario editUser = new Usuario("Carlos", "Perez", "peres32", "123456789", "carlo@mail.com");

                if (gestorBaseDeDatos.UpdateUser(6, editUser))
                {
                    Console.WriteLine("Usuario actualizado!");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}