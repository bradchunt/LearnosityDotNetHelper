using Newtonsoft.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json.Converters;

namespace LearnosityDotNetHelper;

[JsonConverter(typeof(StringEnumConverter))]
public enum Statuses
{   
    [EnumMember(Value="published")]
    Published,

    [EnumMember(Value="unpublished")]
    Unpublished,

    [EnumMember(Value="archived")]
    Archived
}

    