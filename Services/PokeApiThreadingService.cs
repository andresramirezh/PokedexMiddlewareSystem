using PokedexMiddlewareSystem.Clients;
using PokedexMiddlewareSystem.Entities.Dot;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

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
            _currentThread = _threadCount;
        }


        public Boolean GetAndWirteMovesService(int offSet, int limit, int totalCount) {
            var currentThread = _currentThread;
            var threadCount = _threadCount;
            var currentCount = _currentCount;
            Console.WriteLine($"threadCount {threadCount}");
            Boolean [] ThreadStatus = new Boolean[threadCount];
            var moves = 0;
            for (var thread = 0; thread < ThreadStatus.Length; thread++)
            {
                ThreadStatus[thread] = true;
            }
            for (; moves <= totalCount;) {
                var ListTask = new List<Task>();
                if (ThreadStatus.Contains(true) && moves <= totalCount) {
                    Console.WriteLine($"totalCount {totalCount}");
                    Console.WriteLine($"moves {moves}");
                    if (ThreadStatus[0] && ThreadStatus[0] == true) 
                    {
                        moves = moves + 20;
                        ThreadStatus[0] = false;
                        ListTask.Add(Task.Run(() => 
                        {
                            Thread thread0 = new Thread(GetAndWritePartialMovesService);
                            thread0.Name = $"{0}";
                            thread0.Start(moves);
                            thread0.Join();
                        }));

                    }
                    else if (ThreadStatus[1] && ThreadStatus[1] == true) 
                    {
                        moves = moves + 20;
                        ThreadStatus[1] = false;
                        ListTask.Add(Task.Run(() => 
                        {                            
                            Thread thread1 = new Thread(GetAndWritePartialMovesService);
                            thread1.Name = $"{1}";
                            thread1.Start(moves);
                            thread1.Join();
                        }));
                    }
                    else if (ThreadStatus[2] && ThreadStatus[2] == true) 
                    {
                        moves = moves + 20;
                        ThreadStatus[2] = false;
                        ListTask.Add(Task.Run(() => 
                        {
                            Thread thread2 = new Thread(GetAndWritePartialMovesService);
                            thread2.Name = $"{2}";
                            thread2.Start(moves);
                            thread2.Join();
                        }));

                    }
                    else if (ThreadStatus[3] && ThreadStatus[3] == true) 
                    {
                        moves = moves + 20;
                        ThreadStatus[3] = false;
                        ListTask.Add(Task.Run(() => 
                        {
                            Thread thread3 = new Thread(GetAndWritePartialMovesService);
                            thread3.Name = $"{3}";
                            thread3.Start(moves);
                            thread3.Join();
                        }));

                    }
                    else if (ThreadStatus[4] && ThreadStatus[4] == true)
                    {
                        moves = moves + 20;
                        ThreadStatus[4] = false;
                        ListTask.Add(Task.Run(() => 
                        {
                            Thread thread4 = new Thread(GetAndWritePartialMovesService);
                            thread4.Name = $"{4}";
                            thread4.Start(moves);
                            thread4.Join();
                        }));
                    }
                    else if (ThreadStatus[5] && ThreadStatus[5] == true) 
                    {
                        moves = moves + 20;
                        ThreadStatus[5] = false;
                        ListTask.Add(Task.Run(() => 
                        {
                            Thread thread5 = new Thread(GetAndWritePartialMovesService);
                            thread5.Name = $"{5}";
                            thread5.Start(moves);
                            thread5.Join();
                        }));
                    }
                    else if (ThreadStatus[6] && ThreadStatus[6] == true) 
                    {
                        ThreadStatus[6] = false;
                        moves = moves + 20;
                        ListTask.Add(Task.Run(() => 
                        {
                            Thread thread6 = new Thread(GetAndWritePartialMovesService);
                            thread6.Name = $"{6}";
                            thread6.Start(moves);
                            thread6.Join();
                        }));
                    }
                    else if (ThreadStatus[7] && ThreadStatus[7] == true) 
                    {
                        ThreadStatus[7] = false;
                        moves = moves + 20;
                        ListTask.Add(Task.Run(() => 
                        {
                            Thread thread7 = new Thread(GetAndWritePartialMovesService);
                            thread7.Name = $"{7}";
                            thread7.Start(moves);
                            thread7.Join();
                        }));
                    }
                    else if (ThreadStatus[8] && ThreadStatus[8] == true) 
                    {
                        ThreadStatus[8] = false;
                        moves = moves + 20;
                        ListTask.Add(Task.Run(() => 
                        {
                            Thread thread8 = new Thread(GetAndWritePartialMovesService);
                            thread8.Name = $"{8}";
                            thread8.Start(moves);
                            thread8.Join();
                        }));
                    }
                    else if (ThreadStatus[9] && ThreadStatus[9] == true) 
                    {
                        ThreadStatus[9] = false;
                        moves = moves + 20;
                        ListTask.Add(Task.Run(() => 
                        {
                            Thread thread9 = new Thread(GetAndWritePartialMovesService);
                            thread9.Name = $"{9}";
                            thread9.Start(moves);
                            thread9.Join();
                        }));
                    }
                }
                Task oTask =Task.WhenAll(ListTask);
                try {
                    oTask.Wait();
                } catch {

                    if (oTask.Status == TaskStatus.RanToCompletion) {
                        for (var thread = 0; thread < ThreadStatus.Length; thread++)
                        {
                            ThreadStatus[thread] = true;
                        }
                        Console.WriteLine("Threads Finiched");
                    } else if (oTask.Status == TaskStatus.Faulted)
                    {
                        Console.WriteLine("Error");
                    }
                }
                currentThread++;
                currentCount = moves;
            }
            return true;
        }

        public async void GetAndWritePartialMovesService(Object obj) {
            await _pokeApiService.GetAndWirteMovesService(Convert.ToInt32(obj), 20);
        }
    }
}
