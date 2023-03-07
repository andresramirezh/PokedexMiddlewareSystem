﻿using Microsoft.AspNetCore.DataProtection.KeyManagement;
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

        public Task<PokeApiGenericsResponse<List<PokemonMove>>>? pokemonsMoves { get; set; }
        public async Task<PokeApiGenericsResponse<List<PokemonMove>>> GetPokemonsMoves()
        {
            HttpClient httpClient = _httpClientFactory.CreateClient("PokeApi");
            var httpResponseMessage = await httpClient.GetAsync("api/v2/move?limit=10");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return await httpResponseMessage.Content.ReadFromJsonAsync<PokeApiGenericsResponse<List<PokemonMove>>>();

            }
            return null;
        }
    }
}