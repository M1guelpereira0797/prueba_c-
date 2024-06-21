namespace HttpCliente
{
    class Program
    {
        static async Task Main(string[] args)
        {

            string url = @"https://localhost:7074/api/Cliente";

            ConsumoApi clienteHttp = new ConsumoApi(url);

            List<Usuario> usuarios = await clienteHttp.FiltrarAsync();

            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine($"Cliente: {usuario.Nombre}");
            }

            Console.WriteLine("---------- Modificar ----------");

            Usuario usuario1 = new Usuario();
            usuario1.id = 12;
            usuario1.Nombre = "Diego";
            usuario1.Apellido = "Lopez";
            usuario1.Domicilio = "Camino Cintura 2500";
            usuario1.Telefono = "123123123132";

            // bool respuesta = await clienteHttp.ModificarCliente(cliente1);

            //Console.WriteLine(respuesta);

            Console.WriteLine("---------- Crear Cliente ----------");

            Usuario usuariosNew = new Usuario();

            usuariosNew.Nombre = "Lucho";
            usuariosNew.Apellido = "Lopez";
            usuariosNew.Domicilio = "Camino Cintura 22500";
            usuariosNew.Telefono = "+123123123132";

            bool respuesta = await clienteHttp.AltaCliente(usuariosNew);

            Console.WriteLine(respuesta);

            Console.WriteLine("---------- Eliminar Cliente ----------");

            respuesta = await clienteHttp.EliminarCliente(13);

            Console.WriteLine(respuesta);
            Console.ReadLine();
        }
    }
}



