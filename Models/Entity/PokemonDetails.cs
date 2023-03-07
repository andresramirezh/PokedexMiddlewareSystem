using Newtonsoft.Json;
using PokedexMiddlewareSystem.Entities.Dot;
using PokedexMiddlewareSystem.Models.Entity;

namespace PokedexMiddlewareSystem.Models.Entity
{
    public class Ability
    {
        public string name { get; set; }
        public string url { get; set; }

    }
    public class Abilities
    {
        public bool is_hidden { get; set; }
        public int slot { get; set; }
        public Ability ability { get; set; }

    }
    public class Forms
    {
        public string name { get; set; }
        public string url { get; set; }

    }
    public class Version
    {
        public string name { get; set; }
        public string url { get; set; }

    }
    public class Game_indices
    {
        public int game_index { get; set; }
        public Version version { get; set; }

    }
    public class Item
    {
        public string name { get; set; }
        public string url { get; set; }

    }

    public class Version_details
    {
        public int rarity { get; set; }
        public Version version { get; set; }

    }
    public class Held_items
    {
        public Item item { get; set; }
        public IList<Version_details> version_details { get; set; }

    }
    public class Move
    {
        public string name { get; set; }
        public string url { get; set; }

    }
    public class Version_group
    {
        public string name { get; set; }
        public string url { get; set; }

    }
    public class Move_learn_method
    {
        public string name { get; set; }
        public string url { get; set; }

    }
    public class Version_group_details
    {
        public int level_learned_at { get; set; }
        public Version_group version_group { get; set; }
        public Move_learn_method move_learn_method { get; set; }

    }
    public class Moves
    {
        public Move move { get; set; }
        public IList<Version_group_details> version_group_details { get; set; }

    }
    public class Species
    {
        public string name { get; set; }
        public string url { get; set; }

    }
    public class Dream_world
    {
        public string front_default { get; set; }
        public IList<object> front_female { get; set; }

    }
    public class Home
    {
        public string front_default { get; set; }
        public IList<object> front_female { get; set; }
        public string front_shiny { get; set; }
        public IList<object> front_shiny_female { get; set; }

    }
    public class OfficialArtwork
    {
        public string front_default { get; set; }

    }
    public class Other
    {
        public Dream_world dream_world { get; set; }
        public Home home { get; set; }
        [JsonProperty("official-artwork")]
        public OfficialArtwork officialArtwork { get; set; }

}
public class RedBlue
{
    public string back_default { get; set; }
    public string back_gray { get; set; }
    public string front_default { get; set; }
    public string front_gray { get; set; }

}
public class Yellow
{
    public string back_default { get; set; }
    public string back_gray { get; set; }
    public string front_default { get; set; }
    public string front_gray { get; set; }

}
public class GenerationI
{
        [JsonProperty("red-blue")]
        public RedBlue redBlue { get; set; }
public Yellow yellow { get; set; } 

}
public class Crystal
{
    public string back_default { get; set; }
    public string back_shiny { get; set; }
    public string front_default { get; set; }
    public string front_shiny { get; set; }

}
public class Gold
{
    public string back_default { get; set; }
    public string back_shiny { get; set; }
    public string front_default { get; set; }
    public string front_shiny { get; set; }

}
public class Silver
{
    public string back_default { get; set; }
    public string back_shiny { get; set; }
    public string front_default { get; set; }
    public string front_shiny { get; set; }

}
public class GenerationIi
{
    public Crystal crystal { get; set; }
    public Gold gold { get; set; }
    public Silver silver { get; set; }

}
public class Emerald
{
    public string front_default { get; set; }
    public string front_shiny { get; set; }

}
public class FireredLeafgreen
{
    public string back_default { get; set; }
    public string back_shiny { get; set; }
    public string front_default { get; set; }
    public string front_shiny { get; set; }

}
public class RubySapphire
{
    public string back_default { get; set; }
    public string back_shiny { get; set; }
    public string front_default { get; set; }
    public string front_shiny { get; set; }

}
public class GenerationIii
{
    public Emerald emerald { get; set; }
        [JsonProperty("firered-leafgreen")]
        public FireredLeafgreen fireredleafgreen { get; set; }
        [JsonProperty("ruby-sapphire")]
        public RubySapphire rubysapphire { get; set; } 

}
public class DiamondPearl
{
    public string back_default { get; set; }
    public IList<object> back_female { get; set; }
    public string back_shiny { get; set; }
    public IList<object> back_shiny_female { get; set; }
    public string front_default { get; set; }
    public IList<object> front_female { get; set; }
    public string front_shiny { get; set; }
    public IList<object> front_shiny_female { get; set; }

}
public class HeartgoldSoulsilver
{
    public string back_default { get; set; }
    public IList<object> back_female { get; set; }
    public string back_shiny { get; set; }
    public IList<object> back_shiny_female { get; set; }
    public string front_default { get; set; }
    public IList<object> front_female { get; set; }
    public string front_shiny { get; set; }
    public IList<object> front_shiny_female { get; set; }

}
public class Platinum
{
    public string back_default { get; set; }
    public IList<object> back_female { get; set; }
    public string back_shiny { get; set; }
    public IList<object> back_shiny_female { get; set; }
    public string front_default { get; set; }
    public IList<object> front_female { get; set; }
    public string front_shiny { get; set; }
    public IList<object> front_shiny_female { get; set; }

}
public class GenerationIv
{
    [JsonProperty("diamond-pearl")]
    public DiamondPearl diamondPearl { get; set; }
    [JsonProperty("heartgold-soulsilver")]
    public HeartgoldSoulsilver heartgoldsoulsilver { get; set; }
    public Platinum platinum { get; set; } 

}
public class Animated
{
    public string back_default { get; set; }
    public IList<object> back_female { get; set; }
    public string back_shiny { get; set; }
    public IList<object> back_shiny_female { get; set; }
    public string front_default { get; set; }
    public IList<object> front_female { get; set; }
    public string front_shiny { get; set; }
    public IList<object> front_shiny_female { get; set; }

}
public class BlackWhite
{
    public Animated animated { get; set; }
    public string back_default { get; set; }
    public IList<object> back_female { get; set; }
    public string back_shiny { get; set; }
    public IList<object> back_shiny_female { get; set; }
    public string front_default { get; set; }
    public IList<object> front_female { get; set; }
    public string front_shiny { get; set; }
    public IList<object> front_shiny_female { get; set; }

}
public class GenerationV
{
        [JsonProperty("black-white")]
        public BlackWhite blackwhite { get; set; } 

}
public class OmegarubyAlphasapphire
{
    public string front_default { get; set; }
    public IList<object> front_female { get; set; }
    public string front_shiny { get; set; }
    public IList<object> front_shiny_female { get; set; }

}
public class XY
{
    public string front_default { get; set; }
    public IList<object> front_female { get; set; }
    public string front_shiny { get; set; }
    public IList<object> front_shiny_female { get; set; }

}
public class GenerationVi
{
        [JsonProperty("omegaruby-alphasapphire")]
        public OmegarubyAlphasapphire omegarubyAlphasapphire { get; set; }
        [JsonProperty("x-y")]
        public XY xy { get; set; } 

}
public class Icons
{
    public string front_default { get; set; }
    public IList<object> front_female { get; set; }

}
public class UltraSunUltraMoon
{
    public string front_default { get; set; }
    public IList<object> front_female { get; set; }
    public string front_shiny { get; set; }
    public IList<object> front_shiny_female { get; set; }

}
public class GenerationVii
{
    public Icons icons { get; set; }
        [JsonProperty("ultra-sun-ultra-moon")]
        public UltraSunUltraMoon ultraSunUltraMoon { get; set; } 

}

public class GenerationViii
{
    public Icons icons { get; set; }

}
public class Versions
{
    [JsonProperty("generation-i")]
    public GenerationI generationi { get; set; }
    [JsonProperty("generation-ii")]
    public GenerationIi generationii { get; set; }
    [JsonProperty("generation-iii")]
    public GenerationIii generationiii { get; set; }
    [JsonProperty("generation-iv")]
    public GenerationIv generationiv { get; set; }
    [JsonProperty("generation-v")]
    public GenerationV generationv { get; set; }
    [JsonProperty("generation-vi")]
    public GenerationVi generationvi { get; set; }
    [JsonProperty("generation-vii")]
    public GenerationVii generationvii { get; set; }
    [JsonProperty("generation-viii")]
    public GenerationViii generationviii { get; set; } 

}
public class Sprites
{
    public string back_default { get; set; }
    public IList<object> back_female { get; set; }
    public string back_shiny { get; set; }
    public IList<object> back_shiny_female { get; set; }
    public string front_default { get; set; }
    public IList<object> front_female { get; set; }
    public string front_shiny { get; set; }
    public IList<object> front_shiny_female { get; set; }
    public Other other { get; set; }
    public Versions versions { get; set; }

}
public class Stat
{
    public string name { get; set; }
    public string url { get; set; }

}
public class Stats
{
    public int base_stat { get; set; }
    public int effort { get; set; }
    public Stat stat { get; set; }

}
public class Type
{
    public string name { get; set; }
    public string url { get; set; }

}
public class Types
{
    public int slot { get; set; }
    public Type type { get; set; }

}
public class Generation
{
    public string name { get; set; }
    public string url { get; set; }

}

public class Past_types
{
    public Generation generation { get; set; }
    public IList<Types> types { get; set; }

}
public class PokemonDetails
{
    public int id { get; set; }
    public string name { get; set; }
    public int base_experience { get; set; }
    public int height { get; set; }
    public bool is_default { get; set; }
    public int order { get; set; }
    public int weight { get; set; }
    public IList<Abilities> abilities { get; set; }
    public IList<Forms> forms { get; set; }
    public IList<Game_indices> game_indices { get; set; }
    public IList<Held_items> held_items { get; set; }
    public string location_area_encounters { get; set; }
    public IList<object> moves { get; set; }
    public Species species { get; set; }
    public Sprites sprites { get; set; }
    public IList<Stats> stats { get; set; }
    public IList<Types> types { get; set; }
    public IList<Past_types> past_types { get; set; }

}
}
