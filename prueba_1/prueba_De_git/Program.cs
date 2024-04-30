// See https://aka.ms/new-console-template for more information

int rut
const int rut2 = 23880443;
Console.WriteLine("Hello, World!");
string mensaje = ("hoy es 29/04/2024 haciendo pruebas con git");
int numero = 1;
Console.WriteLine(mensaje + numero);
Console.WriteLine("Escribe tu nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Escribe tu apellido: ");
string apellido = Console.ReadLine();
Console.WriteLine("Escribe tu apodo: ");
string apodo= Console.ReadLine();
Console.WriteLine("Escritbe tu edad: ");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("En que ciudad vives: ");
string ciudad = Console.ReadLine();
Console.WriteLine("Cual es tu altura? : ");
int altura = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Cual es tu Rut? : ");
rut = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" El rut es: " + rut2);
Console.WriteLine(" Tu nombre es:  " + nombre +  " tu edad es:  " + edad  +   " tu ciudad es:  "  + ciudad + 
    " tu altura es: " + altura + " tu rut es: " + rut);
Console.WriteLine("Tu nombre, apodo y apellido es {0} {1} {2} ", nombre, apodo, apellido);

Console.ReadKey();
