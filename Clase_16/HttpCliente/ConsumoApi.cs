using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace HttpCliente
{
    public class ConsumoApi
    {
        private readonly HttpClient _client;
        private readonly string _basePath;

        public ConsumoApi(string basePath)
        {
            _client = new HttpClient();
            _basePath = basePath;
        }

        /******/
        /******/
        /******/

        public async Task<List<Usuario>> FiltrarAsync()
        {
            List<Usuario>? list = null;
            try
            {
                HttpResponseMessage response = await _client.GetAsync(_basePath);
                if (response.IsSuccessStatusCode)
                {
                    list = await response.Content.ReadFromJsonAsync<List<Usuario>>();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error con la API: " + ex.Message);
            }
            return list;
        }

        /******/
        /******/
        /******/

        public async Task<bool> ModificarCliente(Usuario cliente)
        {
            HttpResponseMessage response = await _client.PutAsJsonAsync(_basePath, cliente);
            response.EnsureSuccessStatusCode();

            return response.IsSuccessStatusCode;

        }

        public async Task<bool> AltaCliente(Usuario cliente)
        {
            HttpResponseMessage response = await _client.PostAsJsonAsync(_basePath, cliente);

            response.EnsureSuccessStatusCode();

            return response.IsSuccessStatusCode;

        }
        public async Task<bool> EliminarCliente(int id)
        {
            try
            {

                HttpRequestMessage request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    Content = JsonContent.Create(id),
                    RequestUri = new Uri(_basePath, UriKind.Absolute)
                };

                HttpResponseMessage response = await _client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}