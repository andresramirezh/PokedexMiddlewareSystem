using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Net.Http.Headers;
using PokedexMiddlewareSystem.Entities.Dot;
using PokedexMiddlewareSystem.Models.Entity;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
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

        public Task<PokeApiGenericsResponse<List<PokemonMove>>>? pokemonsMoves { get; set; }
        public async Task<PokeApiGenericsResponse<List<PokemonMove>>> GetPokemonsMoves(int offSet, int limit)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("PokeApi");
            var httpResponseMessage = await httpClient.GetAsync($"api/v2/move?offset={offSet}&limit={limit}");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return await httpResponseMessage.Content.ReadFromJsonAsync<PokeApiGenericsResponse<List<PokemonMove>>>();

            }
            return null;
        }

        public async Task<PokemonDetails> GetPokemonsById(int id)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("PokeApi");
            var httpResponseMessage = await httpClient.GetAsync($"api/v2/pokemon/{id}");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return await httpResponseMessage.Content.ReadFromJsonAsync<PokemonDetails>();

            }
            return null;
        }

        public async Task<PokemonTypeDetail> GetPokemonsTypeDetailId(string id)
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("PokeApi");
            var httpResponseMessage = await httpClient.GetAsync($"api/v2/type/{id}");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return await httpResponseMessage.Content.ReadFromJsonAsync<PokemonTypeDetail>();

            }
            return null;
        }
    }
}
