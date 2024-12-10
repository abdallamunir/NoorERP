namespace NoorERP.Core.Models
{
    public class ModuleRegistry
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public List<string> Dependencies { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }

        // Optional properties:
        public string Category { get; set; }
        public string IconPath { get; set; }
        public object ConfigurationSettings { get; set; }
        public int InitializationOrder { get; set; }
        public int ShutdownOrder { get; set; }
    }
}

