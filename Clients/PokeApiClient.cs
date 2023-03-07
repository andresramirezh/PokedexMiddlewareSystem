using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Net.Http.Headers;
using PokedexMiddlewareSystem.Entities.Dot;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Text.Json;

namespace PokedexMiddlewareSystem.Clients
{
    public class PokeApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PokeApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;

        }

        public Generic<IEnumerable<string>>? pokemonsMoves { get; set; }
        public async Task<Generic<IEnumerable<string>>?> GetPokemonsMoves()
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("PokeApi");
            var httpResponseMessage = await httpClient.GetAsync("api/v2/move");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream =
                    await httpResponseMessage.Content.ReadAsStreamAsync();
                Console.WriteLine("contentStream",contentStream);
                pokemonsMoves = await JsonSerializer.DeserializeAsync
                    <Generic<IEnumerable<string>>?>(contentStream);
            }
            return pokemonsMoves;
        }
    }
}
