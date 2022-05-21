using SWRPGInitTracker.Json;
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
        [JsonConverter(typeof(SkillConverter))]
        public List<Skill> Skills { get; set; }

        [JsonPropertyName("weapons")]
        [JsonConverter(typeof(WeaponConverter))]
        public List<Weapon> Weapons { get; set; }

        [JsonPropertyName("gear")]
        [JsonConverter(typeof(GearConverter))]
        public List<Gear> Gear { get; set; }

        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }

        [JsonPropertyName("talents")]
        public List<string> Talents { get; set; }

        [JsonPropertyName("abilities")]
        [JsonConverter(typeof(AbilityConverter))]
        public List<Ability> Abilities { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("notes")]
        public string Notes { get; set; }

        public Adversary() 
        {
            Id = Guid.NewGuid();
        }

        public string SkillString()
        {
            var skillStrs = Skills
                .Select(s => s.Ranks.HasValue ? $"{s.Name} {s.Ranks}" : $"{s.Name}")
                .ToList();
            return string.Join(", ", skillStrs);
        }

        public string AbilityString()
        {
            var abilityStrs = Abilities
                .Select(s => s.Name)
                .ToList();
            return string.Join(", ", abilityStrs);
        }

        public string WeaponString()
        {
            var weaponStrs = Weapons
                .Select(w => w.Name)
                .ToList();
            return string.Join(", ", weaponStrs);
        }

        public string GearString()
        {
            var gearStrs = Gear
                .Select(w => w.Name)
                .ToList();
            return string.Join(", ", gearStrs);
        }

        public string TalentString() => string.Join(", ", Talents);

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
