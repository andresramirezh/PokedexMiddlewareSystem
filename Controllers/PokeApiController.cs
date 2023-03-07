using Microsoft.AspNetCore.Mvc;
using PokedexMiddlewareSystem.Clients;
using PokedexMiddlewareSystem.Entities.Dot;
using PokedexMiddlewareSystem.Services;
using System.Net.Http;

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
            _pokeApiThreadingService = new PokeApiThreadingService(httpClientFactory, 2); 
            _pokeApiService = new PokeApiService(httpClientFactory);
            _logger = logger;
        }



        [HttpGet(Name = "GetAndWritePokemonsMoves")]
        public async Task<Boolean> GetAndWrite()
        {
            return await _pokeApiThreadingService.GetAndWirteMovesService(0,20,920);
        }
    }
}