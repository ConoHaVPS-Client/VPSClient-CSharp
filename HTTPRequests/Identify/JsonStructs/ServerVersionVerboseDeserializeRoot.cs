using System.Text.Json.Serialization;


namespace ConohaVPS.HTTPRequests.Identify.JsonStructs;

public readonly struct ServerVersionVerboseDeserializeRoot
{
    [JsonInclude]
    [JsonPropertyName("version")]
    public Version? Version { get; init; }

    [JsonConstructor]
    public ServerVersionVerboseDeserializeRoot(Version version) => Version = version;
}

public class Version
{
    [JsonInclude]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    [JsonInclude]
    [JsonPropertyName("updated")]
    public DateTime Updated { get; init; }

    [JsonInclude]
    [JsonPropertyName("mediatypes")]
    public MediaTypes[]? Mediatypes { get; init; }

    [JsonInclude]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonInclude]
    [JsonPropertyName("links")]
    public Link[]? Links { get; init; }
}
