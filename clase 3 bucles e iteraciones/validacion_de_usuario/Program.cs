// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese contraseña");
string contrasena = Console.ReadLine();

while (!contrasena.Equals("coder!2022"));
{
    Console.WriteLine("Su contraseña no fue valida, por favor reintente");
    contrasena = Console.ReadLine();    
}

Console.WriteLine("Bienvenido a coderhouse");
