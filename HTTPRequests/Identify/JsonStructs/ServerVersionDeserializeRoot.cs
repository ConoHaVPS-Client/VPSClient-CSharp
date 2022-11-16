using System.Text.Json.Serialization;


namespace ConohaVPS.HTTPRequests.Identify.JsonStructs;

public readonly struct ServerVersionDeserializeRoot
{
    [JsonInclude]
    [JsonPropertyName("versions")]
    public Versions? Versions { get; init; }

    [JsonConstructor]
    public ServerVersionDeserializeRoot(Versions versions) => Versions = versions;
}

public class Versions
{
    [JsonInclude]
    [JsonPropertyName("values")]
    public Value[]? Values { get; init; }
}

public class Value
{
    [JsonInclude]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonInclude]
    [JsonPropertyName("links")]
    public Link[]? Links { get; init; }

    [JsonInclude]
    [JsonPropertyName("mediatypes")]
    public MediaTypes[]? Mediatypes { get; init; }

    [JsonInclude]
    [JsonPropertyName("status")]
    public string? Status { get; init; }

    [JsonInclude]
    [JsonPropertyName("updated")]
    public DateTime Updated { get; init; }
}

public class Link
{
    [JsonInclude]
    [JsonPropertyName("href")]
    public string? Href { get; init; }

    [JsonInclude]
    [JsonPropertyName("rel")]
    public string? Rel { get; init; }

    [JsonInclude]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}

public class MediaTypes
{
    [JsonInclude]
    [JsonPropertyName("base")]
    public string? Base { get; init; }
}
