using PokedexMiddlewareSystem.Clients;
using PokedexMiddlewareSystem.Entities.Dot;
using PokedexMiddlewareSystem.Models.Entity;
using Pokemon = PokedexMiddlewareSystem.Entities.Dot.Pokemon;

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

        public async Task<Pokemon> GetPokemonsByIdService(int id)
        {
           var pokemonDetails = await _pokeApiClient.GetPokemonsById(id);
           var pokemonTypeDetails = await _pokeApiClient.GetPokemonsTypeDetailId(pokemonDetails.types[0].type.name);

            Pokemon pokemon = new Pokemon
            {
                Name = pokemonDetails.name,
                Id = pokemonDetails.id,
                Height = pokemonDetails.height,
                Width = pokemonDetails.weight,
                Types = pokemonDetails.types,
                TypeName = pokemonDetails.types[0].type.name,
                Related = pokemonTypeDetails.pokemon,
                Movements = pokemonDetails.moves,
                FirstPicture = pokemonDetails.sprites.back_default,
                SecondPicture = pokemonDetails.sprites.back_shiny,
                AreaName = pokemonDetails.location_area_encounters
            };
            return pokemon;
        }

        public async Task<Boolean> GetAndWirteMovesService(int offSet, int limit)
        {
            Console.WriteLine($"offSet {offSet}");
            Console.WriteLine(Thread.CurrentThread.Name);
            PokeApiGenericsResponse<List<PokemonMove>> response =
                await GetPokemonsMovesService(offSet, limit);
            for (var moves = 0; moves < response.results.Count; moves++)
            {
                var move = response.results[moves];
                Console.WriteLine(move.name);
            }
            return true;
        }
    }
}
