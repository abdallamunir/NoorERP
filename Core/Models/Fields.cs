using System.Text.Json.Serialization;

namespace NoorERP.Core.Models
{
    public class AutoNumberField : BaseField
    {
        [JsonPropertyName("field_type")]
        public override FieldTypes FieldType => FieldTypes.AutoNumber;

        public override object? GetDefaultValue()
        {
            return 0;
        }

        [JsonPropertyName("starting_number")]
        public int StartingNumber { get; set; } = 0;


    }

    public class GuidField : BaseField
    {
        [JsonPropertyName("field_type")]
        public override FieldTypes FieldType => FieldTypes.Guid;

        public override object? GetDefaultValue()
        {
            return Guid.Empty;
        }
    }
}