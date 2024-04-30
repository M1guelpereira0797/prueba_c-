//void es cuando no regresa nada
bool validarcontrasenia(string contrasenia)
{
   return  contrasenia.Equals("holamama");
}
string ocultarpass(string pass)
{
    char[] caracteres = pass.ToCharArray();
    for (int uno = 0; uno < caracteres.Length; uno++) 
    {
        caracteres[uno] = '*';
    }
    string textomodificado = new string(caracteres);
    return textomodificado;
}
void validoingreso()
{
    int intentos = 0;
    string contrasenia;
    bool ingreso = true;

    Console.WriteLine("Ingrese la contraseña: ");

    while (ingreso)
    {
        contrasenia = Console.ReadLine();
        intentos++;

        if (validarcontrasenia(contrasenia))
        {
            string passoculto = ocultarpass(contrasenia);
            Console.WriteLine("Bienvenido has iniciado sesion");
            Console.WriteLine("Su contreseña es correcta {0}",passoculto );
            break;
        }
        else if (intentos >= 3)
        {
            Console.WriteLine("Su contraseña no fue valida y agoto los intentos");
            break;
        }
        int resto = 3 - intentos;
        Console.WriteLine("Su contraseña no fue valida intente nuevamente, le quedan {0} intentos", resto);
    }
}

validoingreso();