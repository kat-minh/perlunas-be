using System.Text.Json.Serialization;

namespace Cms.Repository.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TaxonomyGroup
{
    City,
    StayType,
    Region
}
