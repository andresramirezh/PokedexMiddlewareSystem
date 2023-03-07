namespace PokedexMiddlewareSystem.Models.Entity
{
    public class Double_damage_from
    {
        public string name { get; set; }
        public string url { get; set; }

    }
    public class Double_damage_to
    {
        public string name { get; set; }
        public string url { get; set; }

    }
    public class Half_damage_from
    {
        public string name { get; set; }
        public string url { get; set; }

    }
    public class Half_damage_to
    {
        public string name { get; set; }
        public string url { get; set; }

    }
    public class No_damage_from
    {
        public string name { get; set; }
        public string url { get; set; }

    }
    public class Damage_relations
    {
        public IList<Double_damage_from> double_damage_from { get; set; }
        public IList<Double_damage_to> double_damage_to { get; set; }
        public IList<Half_damage_from> half_damage_from { get; set; }
        public IList<Half_damage_to> half_damage_to { get; set; }
        public IList<No_damage_from> no_damage_from { get; set; }
        public IList<object> no_damage_to { get; set; }

    }
    public class Language
    {
        public string name { get; set; }
        public string url { get; set; }

    }
    public class Names
    {
        public Language language { get; set; }
        public string name { get; set; }

    }
    public class Pokemon
    {
        public string name { get; set; }
        public string url { get; set; }

    }

    public class MoveDamageClass
    {
        public string name { get; set; }
        public string url { get; set; }

    }

    public class PokemonTypeDetail
    {
        public Damage_relations damage_relations { get; set; }
        public IList<Game_indices> game_indices { get; set; }
        public Generation generation { get; set; }
        public int id { get; set; }
        public MoveDamageClass move_damage_class { get; set; }
        public IList<object> moves { get; set; }
        public string name { get; set; }
        public IList<Names> names { get; set; }
        public IList<object> past_damage_relations { get; set; }
        public IList<object> pokemon { get; set; }

    }
}
