namespace PokedexMiddlewareSystem.Entities.Dot
{
    public class PokeApiGenericsResponse <T>
    {
        public int count { get; set; }

        public string next { get; set; }

        public string previous { get; set; }

        public T results { get; set; }
    }
}
