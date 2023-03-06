namespace PokedexMiddlewareSystem.Entities.Dot
{

    public class Pokemon
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public float Height { get; set; } 
        
        public float Width { get; set; }

        public List<string>? Types { get; set; }

        public  string TypeName { get; set; }

        public string Related { get; set; }

        public List<string>? Movements { get; set; }

        public string? FirstPicture { get; set; }

        public string? SecondPicture { get; set; }

        public string AreaName { get; set; }



    }
}

