using SWRPGInitTracker.Models;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SWRPGInitTracker.Json
{
    public class SkillConverter : JsonConverter<List<Skill>>
    {
        private static readonly byte[] s_skillsUtf8 = Encoding.UTF8.GetBytes("skills");
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert == typeof(List<Skill>) || typeToConvert == typeof(List<string>);
        }
        public override List<Skill>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            //put together lists for skills, ranks, and skill names
            List<Skill> skillList = new List<Skill>();
            List<int> ranks = new();
            List<string> names = new();
            bool exit = false;

            //iterate through JSON
            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    //if we reach the end of an array or object, exit the loop
                    case JsonTokenType.EndObject:
                        exit = true;
                        break;
                    case JsonTokenType.EndArray:
                        exit = true;
                        break;
                    //if we reach a property name or a string, treat it as a skill name
                    case JsonTokenType.PropertyName:
                        string? name = reader.GetString();
                        names.Add(name ?? String.Empty);
                        break;
                    case JsonTokenType.String:
                        string? str = reader.GetString();
                        names.Add(str ?? String.Empty);
                        break;
                    //if we reach a number, treat it as a skill rank
                    case JsonTokenType.Number:
                        int intVal = reader.GetInt32();
                        ranks.Add(intVal);
                        break;
                }

                //if we set the exit condition earlier, break on through to the other side
                if (exit)
                {
                    break;
                }
            }

            //assemble and return skill list
            for (int i = 0; i < names.Count; i++)
            {
                bool hasRanks = ranks.Any();
                skillList.Add(new Skill
                {
                    Name = names[i],
                    Ranks = hasRanks ? ranks[i] : null
                });
            }
            return skillList;
        }

        public override void Write(Utf8JsonWriter writer, List<Skill> value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }

    public class AbilityConverter : JsonConverter<List<Ability>>
    {
        public override List<Ability>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            //put together lists
            List<Ability> abilityList = new List<Ability>();
            List<string> names = new();
            List<string> descriptions = new();
            bool exit = false;

            //iterate through JSON
            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    //if we reach the end of the array, exit the loop
                    case JsonTokenType.EndArray:
                        exit = true;
                        break;
                    //if we reach a property name or a string, treat it as a skill name
                    case JsonTokenType.PropertyName:
                        string? name = reader.GetString();
                        names.Add(name ?? String.Empty);
                        break;
                    case JsonTokenType.String:
                        string? str = reader.GetString();
                        names.Add(str ?? String.Empty);
                        break;
                }

                //special case: handle inner object
                if (reader.TokenType == JsonTokenType.StartObject)
                {
                    List<string> innerStrs = new();
                    bool innerExit = false;
                    while (reader.Read())
                    {
                        switch (reader.TokenType)
                        {
                            //if we reach the end of the Object, exit the loop
                            case JsonTokenType.EndObject:
                                innerExit = true;
                                break;
                            case JsonTokenType.String:
                                string? str = reader.GetString();
                                innerStrs.Add(str ?? String.Empty);
                                break;
                        }

                        if (innerExit) break;
                    }

                    //TODO: right now, we just discard the descriptions
                    names.Add(innerStrs[0]);
                }

                //if we set the exit condition earlier, break on through to the other side
                if (exit)
                {
                    break;
                }
            }

            //assemble and return ability list
            for (int i = 0; i < names.Count; i++)
            {
                abilityList.Add(new Ability
                {
                    Name = names[i],
                });
            }
            return abilityList;
        }

        public override void Write(Utf8JsonWriter writer, List<Ability> value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }

    public class WeaponConverter : JsonConverter<List<Weapon>>
    {
        public override List<Weapon>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            //put together lists
            List<Weapon> weaponList = new List<Weapon>();
            List<string> names = new();
            List<string> descriptions = new();
            bool exit = false;

            //iterate through JSON
            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    //if we reach the end of the array, exit the loop
                    case JsonTokenType.EndArray:
                        exit = true;
                        break;
                    //if we reach a property name or a string, treat it as a skill name
                    case JsonTokenType.PropertyName:
                        string? name = reader.GetString();
                        names.Add(name ?? String.Empty);
                        break;
                    case JsonTokenType.String:
                        string? str = reader.GetString();
                        names.Add(str ?? String.Empty);
                        break;
                }

                //special case: handle inner object
                if (reader.TokenType == JsonTokenType.StartObject)
                {
                    List<string> innerStrs = new();
                    bool innerExit = false;
                    while (reader.Read())
                    {
                        switch (reader.TokenType)
                        {
                            //if we reach the end of the Object, exit the loop
                            case JsonTokenType.EndObject:
                                innerExit = true;
                                break;
                            case JsonTokenType.String:
                                string? str = reader.GetString();
                                innerStrs.Add(str ?? String.Empty);
                                break;
                        }

                        if (innerExit) break;
                    }

                    //TODO: right now, we just discard the descriptions
                    names.Add(innerStrs[0]);
                }

                //if we set the exit condition earlier, break on through to the other side
                if (exit)
                {
                    break;
                }
            }

            //assemble and return weapon list
            for (int i = 0; i < names.Count; i++)
            {
                weaponList.Add(new Weapon
                {
                    Name = names[i],
                });
            }
            return weaponList;
        }

        public override void Write(Utf8JsonWriter writer, List<Weapon> value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }

    public class GearConverter : JsonConverter<List<Gear>>
    {
        public override List<Gear>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            //put together lists
            List<Gear> gearList = new List<Gear>();
            List<string> names = new();
            List<string> descriptions = new();
            bool exit = false;

            //iterate through JSON
            while (reader.Read())
            {
                switch (reader.TokenType)
                {
                    //if we reach the end of the array, exit the loop
                    case JsonTokenType.EndArray:
                        exit = true;
                        break;
                    //if we reach a property name or a string, treat it as a skill name
                    case JsonTokenType.PropertyName:
                        string? name = reader.GetString();
                        names.Add(name ?? String.Empty);
                        break;
                    case JsonTokenType.String:
                        string? str = reader.GetString();
                        names.Add(str ?? String.Empty);
                        break;
                }

                //special case: handle inner object
                if (reader.TokenType == JsonTokenType.StartObject)
                {
                    List<string> innerStrs = new();
                    bool innerExit = false;
                    while (reader.Read())
                    {
                        switch (reader.TokenType)
                        {
                            //if we reach the end of the Object, exit the loop
                            case JsonTokenType.EndObject:
                                innerExit = true;
                                break;
                            case JsonTokenType.String:
                                string? str = reader.GetString();
                                innerStrs.Add(str ?? String.Empty);
                                break;
                        }

                        if (innerExit) break;
                    }

                    //TODO: right now, we just discard the descriptions
                    names.Add(innerStrs[0]);
                }

                //if we set the exit condition earlier, break on through to the other side
                if (exit)
                {
                    break;
                }
            }

            //assemble and return weapon list
            for (int i = 0; i < names.Count; i++)
            {
                gearList.Add(new Gear
                {
                    Name = names[i],
                });
            }
            return gearList;
        }

        public override void Write(Utf8JsonWriter writer, List<Gear> value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
