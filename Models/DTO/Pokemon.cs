using PokedexMiddlewareSystem.Models.Entity;

namespace PokedexMiddlewareSystem.Entities.Dot
{

    public class Pokemon
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public float Height { get; set; } 
        
        public float Width { get; set; }

        public IList<Types> Types { get; set; }

        public  string TypeName { get; set; }

        public IList<object> Related { get; set; }

        public IList<object> Movements { get; set; }

        public string? FirstPicture { get; set; }

        public string? SecondPicture { get; set; }

        public string AreaName { get; set; }



    }


}

