using System.Text.Json.Serialization;

namespace SWRPGInitTracker.Models
{
    public class Crit
    {
        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonPropertyName("roll")]
        public string Roll { get; set; }

        [JsonPropertyName("severity")]
        public int Severity { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("effect")]
        public string Effect { get; set; }
    }
}
