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

        public PokeApiController(IHttpClientFactory httpClientFactory, ILogger<PokeApiController> logger)
        {
            _pokeApiService = new PokeApiService(httpClientFactory);
            _logger = logger;
        }

        [HttpGet(Name = "GetPokemonsMovesService")]
        public async Task<Generic<IEnumerable<string>>?> Get() {
            return await _pokeApiService.GetPokemonsMovesService();


        } 
    }
}