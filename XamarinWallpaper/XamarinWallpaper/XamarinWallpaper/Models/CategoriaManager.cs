using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Linq;

namespace XamarinWallpaper.Models
{
    public class CategoriaManager
    {
        const String URL = "http://wallpaper.dfilitto.com.br/obtercategorias.php";
        private HttpClient getClient()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Accept", "Application/json");
            client.DefaultRequestHeaders.Add("Cennection", "close");
            return client;
        }

        public async Task<IEnumerable<Categoria>> getCategoria()
        {
            HttpClient client = getClient();
            var res = await client.GetAsync(URL);
            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Categoria>>(content);
            }
            return Enumerable.Empty<Categoria>();
        }

    }
}
