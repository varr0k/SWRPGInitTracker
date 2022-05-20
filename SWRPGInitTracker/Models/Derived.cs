using System.Text.Json.Serialization;

namespace SWRPGInitTracker.Models
{
    public class Derived
    {
        [JsonPropertyName("soak")]
        public int Soak { get; set; }

        [JsonPropertyName("wounds")]
        public int Wounds { get; set; }

        [JsonPropertyName("strain")]
        public int? Strain { get; set; }

        [JsonPropertyName("defence")]
        public List<int> Defence { get; set; }

        public Derived() { }

        public override string ToString()
        {
            string returnString = $"Soak: {Soak}, Wounds: {Wounds}";
            if (Strain.HasValue)
            {
                returnString += $", Strain: {Strain}";
            }
            if (Defence != null)
            {
                returnString += $", M/R Defence {Defence[0]}/{Defence[1]}";
            }
            return returnString;
        }

        public int MeleeDefence
            => Defence == null ? 0 : Defence[0];
        public int RangedDefence
            => Defence == null ? 0 : Defence[1];
    }
}
