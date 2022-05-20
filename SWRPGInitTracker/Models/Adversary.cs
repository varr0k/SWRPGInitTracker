using System.Text.Json.Serialization;

namespace SWRPGInitTracker.Models
{
    public class Adversary
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("characteristics")]
        public Characteristics Characteristics { get; set; }

        [JsonPropertyName("derived")]
        public Derived Derived { get; set; }

        [JsonPropertyName("skills")]
        public object Skills { get; set; }

        //[JsonPropertyName("weapons")]
        [JsonIgnore]
        public List<object> Weapons { get; set; }

        //[JsonPropertyName("gear")]
        [JsonIgnore]
        public List<string> Gear { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        //[JsonPropertyName("talents")]
        [JsonIgnore]
        public List<string> Talents { get; set; }

        //[JsonPropertyName("abilities")]
        [JsonIgnore]
        public List<string> Abilities { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        public Adversary() 
        {
            Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            string returnString = $"{Name} ({Type})\n";

            if (Characteristics != null)
            {
                returnString += $"{Characteristics}\n";
            }
            if (Derived != null)
            {
                returnString += $"{Derived}\n";
            }
            if (Skills != null)
            {
                

                returnString += $"{Skills}\n";
            }
            if (Weapons != null)
            {
                returnString += $"{Weapons}\n";
            }
            if (Gear != null)
            {
                returnString += $"{Gear}\n";
            }
            if (Tags != null)
            {
                returnString += $"{Tags}\n";
            }
            
            return returnString;
        }
    }
}
