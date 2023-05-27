namespace SWRPGInitTracker.Models
{
    public static class Sources
    {

        public static List<Source> GetAdversaryList() =>
            new List<Source>
            {
                //Add adversary sources
                new Source("Imperial Military", "/data/adversaries/imperial-military.json", true),
                new Source("Imperial Bureaucracy", "/data/adversaries/imperial-bureaucracy.json", true),
                new Source("Civilians", "/data/adversaries/civilians.json", true),
                new Source("Creatures", "/data/adversaries/creatures.json", true),
                new Source("Droids", "/data/adversaries/droids.json", true),
                new Source("Rebel Alliance", "/data/adversaries/rebel-alliance.json", true),
            };

        public static List<Source> GetCritsList() =>
            new List<Source>
            {
                new Source("crits", "/data/crits.json", true)
            };

        public static List<Source> GetVehicleCritsList() =>
            new List<Source>
            {
                new Source("crits", "/data/vehiclecrits.json", true)
            };
    }

    public class Source
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Selected { get; set; }
        public string Url { get; set; }

        public Source(string name, string url, bool selected)
        {
            Id = Guid.NewGuid();
            Name = name;
            Selected = selected;
            Url = url;
        }
    }
}
