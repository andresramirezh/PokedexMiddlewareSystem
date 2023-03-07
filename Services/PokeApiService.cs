﻿using PokedexMiddlewareSystem.Clients;
using PokedexMiddlewareSystem.Entities.Dot;

namespace PokedexMiddlewareSystem.Services
{
    public class PokeApiService
    {
        private PokeApiClient _pokeApiClient;
        public PokeApiService(IHttpClientFactory httpClientFactory) =>
            _pokeApiClient = new PokeApiClient(httpClientFactory);
        
        public async Task<PokeApiGenericsResponse<List<PokemonMove>>> GetPokemonsMovesService() {
            return await _pokeApiClient.GetPokemonsMoves();
        }
    }
}
