// See https://aka.ms/new-console-template for more information
string usuario;
string contraseña= "holamama";
string contraseñaingresada;

Console.WriteLine("Ingrese su perfil");
usuario=Console.ReadLine();
Console.WriteLine("Ingrese su contraseña: ");
contraseñaingresada=Console.ReadLine();

if (contraseña == contraseñaingresada)
{
    switch(usuario)
        {
         case "usuario":
         Console.WriteLine("Has ingresado como Usuario");
         break;
        case "administrador":
            Console.WriteLine("Has ingresado como Administrador");
            break;
        default:
            Console.WriteLine("Has ingresado como Usuario sin identificar");
            break;
    }
}
else
{
    Console.WriteLine("DEBES REINICIAR EL SISTEMA");
}