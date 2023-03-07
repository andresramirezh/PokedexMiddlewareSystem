using PokedexMiddlewareSystem.Clients;
using PokedexMiddlewareSystem.Entities.Dot;
using System.Collections.Generic;
using System.Threading;

namespace PokedexMiddlewareSystem.Services
{
    public class PokeApiThreadingService
    {
        private PokeApiService _pokeApiService;
        private int _threadCount = 0;
        private int _currentThread = 0;
        private int _currentCount = 0;
        public PokeApiThreadingService(IHttpClientFactory httpClientFactory, int threadCount) 
        {
            _pokeApiService = new PokeApiService(httpClientFactory);
            _threadCount = threadCount;
        }


        public async Task<Boolean> GetAndWirteMovesService(int offSet, int limit, int totalCount) {
            _currentThread = _threadCount;
            for (var moves = 0; moves <= totalCount;) {
                while (_currentThread > 0 && _currentThread <= _threadCount && moves <= totalCount) {
                    Console.WriteLine("Hilos", _currentThread.ToString());
                    _currentThread--;
                    Thread thread = new Thread(GetAndWritePartialMovesService);
                    thread.Start();
                    thread.Join(_currentThread++);
                    moves = moves + 20;
                    _currentCount = moves;
                }
            }
            return true;
        }

        public async void GetAndWritePartialMovesService() {
                await _pokeApiService.GetAndWirteMovesService(_currentCount, 20);
        }
    }
}
