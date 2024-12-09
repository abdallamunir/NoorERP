using System.Text.Json.Serialization;

namespace NoorERP.Core.Models
{
    /// <summary>
    /// This is the an abstract class representing Field object
    /// </summary>
    public abstract class BaseField
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("label")]
        public string Label { get; set; } = string.Empty;

        [JsonPropertyName("placeholder_text")]
        public string PlaceholderText { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("help_text")]
        public string? HelpText { get; set; }

        [JsonPropertyName("required")]
        public bool? Required { get; set; }

        [JsonPropertyName("unique")]
        public bool? Unique { get; set; }

        [JsonPropertyName("searchable")]
        public bool? Searchable { get; set; }

        [JsonPropertyName("auditable")]
        public bool? Auditable { get; set; }

        [JsonPropertyName("system")]
        public bool? System { get; set; }

        [JsonPropertyName("permissions")]
        public FieldPermissions Permissions { get; set; } = new FieldPermissions();

        [JsonPropertyName("enable_security")]
        public bool? EnableSecurity { get; set; }

        public abstract FieldTypes FieldType { get; }

        public virtual object? GetDefaultValue() => null;

        // Consider adding validation methods or properties
        public virtual bool IsValid(object value) => true;


        public enum FieldTypes
        {
            AutoNumber,
            CheckBox,
            Currency,
            Date,
            DateTime,
            Email,
            File,
            Formula,
            Geography,
            Guid,
            Html,
            Image,
            MultiLineText,
            MultiSelect,
            Number,
            Password,
            Percent,
            Phone,
            Select,
            Text,
            TreeSelect,
            Url,
            Boolean,
            Binary,
            Char,
            Int,
            Float,
            Decimal,
            Double,


        }

    }
}