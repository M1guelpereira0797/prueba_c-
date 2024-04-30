// See https://aka.ms/new-console-template for more information
string contrasenia;
int intentos=0;
bool ingreso = true;
Console.WriteLine("Ingrese su contraseña");

while (ingreso)
{
    contrasenia=Console.ReadLine();
    intentos++;
    if (contrasenia.Equals("mama")) 
    {
        ingreso = false;
        Console.WriteLine("Bienvenido");
        break;
    }
   else if(intentos >= 3) 
        {
        Console.WriteLine("Has intentado mas de 5 veces con la contraseña");
        break;
    }
    Console.WriteLine("Intente de nuevo");

}