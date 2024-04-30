// See https://aka.ms/new-console-template for more information
Console.WriteLine("CLASE 3");
// length te da la cantidad de caracteres de la cadena
// Toupper que sea todo mayuscula
// Tolower que todo sea minuscula
// Tostring
// Equals permite saber si una cadena tiene exactamente el mismo valor que otra
//Contains nos permite saber si una cadena se encuentra dentro de otra 
//Parse es una funcion utilizada para realizar conversiones de cadenas de texto tipos numeros(int, double, long, entre otros)
//Convert

// EN ESTA CLASE VAMOS A VER FOR Y WHILE

string cadenanula = null;
string cadenavacia= string.Empty;
string cadenasaludo = "Hola soy una cadena";


Console.WriteLine(cadenanula + cadenavacia + cadenasaludo);

if( cadenanula == cadenavacia)
{
    Console.WriteLine("Las cadenas son iguales");
}
else
{
    Console.WriteLine("Las cadenas no son iguales");
}

//Console.WriteLine(cadenanula.Length);
//Console.WriteLine(cadenavacia.Length);
//Console.WriteLine(cadenasaludo.Length);

string mensaje = "Voy desarrollar c# en back-end";
Console.WriteLine( " Mensaje en mayusculoa "  +  mensaje.ToLower());
Console.WriteLine(" Mensaje en mayusculoa "  +  mensaje.ToUpper());


Console.WriteLine("Ingrese un numero para sumar");
string cadena = Console.ReadLine();

double constante = 0.5;
double numeroencadenaconvertidoadoble;
double sumaconnumerodouble;

if(String.IsNullOrEmpty(cadena))
{
    Console.WriteLine("lA CADENA no se parsear ya que esta vacia");

}
else
{
    numeroencadenaconvertidoadoble = double.Parse(cadena);
    sumaconnumerodouble = numeroencadenaconvertidoadoble + constante;
    Console.WriteLine("El resultado es: " + sumaconnumerodouble);
}