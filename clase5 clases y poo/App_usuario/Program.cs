namespace App_usuario
{
    class Program
    {
         static void Main(string[] args)
        {
            bool mayor;
            string nuevodireccion;
            bool gmail;

            Usuario usuario1 = new Usuario(" pedro", " apodo", 222, "pedroapodo07", 3298, 51254, "CRMALO", "pedroapodo@gmail.com");
            ;
            Usuario usuario2 = new Usuario(" juan ", " apodo", 22, "juanapodo07",989898, 545454,   "condorito", "juanapodo@gmail.com");


            mayor = usuario1.Esmayordeedad();
            Console.WriteLine("Usuario 1 tiene correo gmail " + mayor   );
            mayor = usuario2.Esmayordeedad();
            Console.WriteLine("Usuario 2 tiene correo gmail " + mayor);
            nuevodireccion = usuario1.Cambiardireccion("");
            Console.WriteLine("Usuario 1 tiene correo gmail " + nuevodireccion);
            nuevodireccion = usuario2.Cambiardireccion("1");
            Console.WriteLine("Usuario 2 tiene correo gmail " + nuevodireccion);
            gmail = usuario1.gmaile();
            Console.WriteLine("Usuario 1 tiene correo gmail " + gmail);
            gmail = usuario2.gmaile();
            Console.WriteLine("Usuario 2 tiene correo gmail " + gmail);






        }
    }
}