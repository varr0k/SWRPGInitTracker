using System.Text.Json.Serialization;

namespace SWRPGInitTracker.Models
{
    public class Characteristics
    {
        [JsonPropertyName("Brawn")]
        public int Brawn { get; set; }

        [JsonPropertyName("Agility")]
        public int Agility { get; set; }

        [JsonPropertyName("Intellect")]
        public int Intellect { get; set; }

        [JsonPropertyName("Cunning")]
        public int Cunning { get; set; }

        [JsonPropertyName("Willpower")]
        public int Willpower { get; set; }

        [JsonPropertyName("Presence")]
        public int Presence { get; set; }

        public Characteristics() { }

        public override string ToString() 
            => $"Brawn {Brawn}, Agility {Agility}, Intellect {Intellect}, Cunning {Cunning}, Willpower {Willpower}, Presence {Presence}";

    }
}
