namespace NoorERP.Core.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }

        // Metadata Properties
        public required string ModelName { get; set; }
        public required string TableName { get; set; }
        public bool IsAbstract { get; set; } = true;
        public bool IsTransient { get; set; } = false;
        public bool IsCustom { get; set; } = false;
        public string DisplayName { get; set; } = string.Empty;
    }
}

