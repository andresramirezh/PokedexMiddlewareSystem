using Microsoft.AspNetCore.Mvc;
using PokedexMiddlewareSystem.Clients;
using PokedexMiddlewareSystem.Entities.Dot;
using PokedexMiddlewareSystem.Models.Entity;
using PokedexMiddlewareSystem.Services;
using System.Net.Http;
using Pokemon = PokedexMiddlewareSystem.Entities.Dot.Pokemon;

namespace PokedexMiddlewareSystem.Controllers
{

    [ApiController]
    [Route("Pokedex")]
    public class PokeApiController : ControllerBase
    {
        private readonly ILogger<PokeApiController> _logger;
        private PokeApiService _pokeApiService;
        private PokeApiThreadingService _pokeApiThreadingService;

        public PokeApiController(IHttpClientFactory httpClientFactory, ILogger<PokeApiController> logger)
        {
            /* El numero 10 en el segundo parametro es la cantidad de hilos */
            _pokeApiThreadingService = new PokeApiThreadingService(httpClientFactory, 10);
            _pokeApiService = new PokeApiService(httpClientFactory);
            _logger = logger;
        }



        [HttpGet("GetAndWirtePokemonsMovesService")]
        public  Boolean GetAndWrite()
        {
            return _pokeApiThreadingService.GetAndWirteMovesService(0, 20, 920);
        }

        [HttpGet("GetPokemonsMovesService")]
        public async Task<PokeApiGenericsResponse<List<PokemonMove>>> GetMoves(int offSet, int limit)
        {
            return await _pokeApiService.GetPokemonsMovesService(offSet, limit);
        }

        [HttpGet("GetPokemon")]
        public async Task<Pokemon> GetPokemonById(int id)
        {
            return await _pokeApiService.GetPokemonsByIdService(id);
        }
    }
}