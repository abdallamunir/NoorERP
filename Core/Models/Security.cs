using System.Text.Json.Serialization;

namespace NoorERP.Core.Models
{
    public class RecordPermissions
    {
        [JsonPropertyName("can_read")]
        public List<Guid> CanRead { get; set; } = new List<Guid>();

        [JsonPropertyName("can_create")]
        public List<Guid> CanCreate { get; set; } = new List<Guid>();

        [JsonPropertyName("can_update")]
        public List<Guid> CanUpdate { get; set; } = new List<Guid>();

        [JsonPropertyName("can_delete")]
        public List<Guid> CanDelete { get; set; } = new List<Guid>();
    }

    public class FieldPermissions
    {
        [JsonPropertyName("can_read")]
        public List<Guid> CanRead { get; set; } = new List<Guid>();

        [JsonPropertyName("can_update")]
        public List<Guid> CanUpdate { get; set; } = new List<Guid>();
    }
}