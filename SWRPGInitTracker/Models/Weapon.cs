using System.Text.Json.Serialization;

namespace SWRPGInitTracker.Models
{
    public class Weapon
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("skill")]
        public string Skill { get; set; }

        [JsonPropertyName("damage")]
        public int Damage { get; set; }

        [JsonPropertyName("critical")]
        public int? Critical { get; set; }

        [JsonPropertyName("range")]
        public string Range { get; set; }

        [JsonPropertyName("qualities")]
        public List<string> Qualities { get; set; }
    }
}
