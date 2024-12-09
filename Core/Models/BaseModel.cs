# region <--- DIRECTIVES --->
using System.Text.Json.Serialization;

# endregion

namespace NoorERP.Core.Models
{
    public abstract class BaseModel
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("record_permissions")]
        public RecordPermissions RecordPermissions { get; set; } = new RecordPermissions();

        [JsonPropertyName("fields")]
        public List<BaseField> Fields { get; set; } = new List<BaseField>();

    }
}

