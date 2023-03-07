using PokedexMiddlewareSystem.Clients;
using PokedexMiddlewareSystem.Entities.Dot;

namespace PokedexMiddlewareSystem.Services
{
    public class PokeApiService
    {
        private PokeApiClient _pokeApiClient;
        public PokeApiService(IHttpClientFactory httpClientFactory) =>
            _pokeApiClient = new PokeApiClient(httpClientFactory);
        
        public async Task<PokeApiGenericsResponse<List<PokemonMove>>> GetPokemonsMovesService(int offSet, int limit) {
            return await _pokeApiClient.GetPokemonsMoves(offSet, limit);
        }

        public async Task<Boolean> GetAndWirteMovesService(int offSet, int limit)
        {
            PokeApiGenericsResponse<List<PokemonMove>> response =
                await GetPokemonsMovesService(offSet, limit);
            for (var moves = 0; moves < response.results.Count; moves++)
            {
                var move = response.results[moves];
                //Console.WriteLine(move.name);
            }
            return true;
        }
    }
}
