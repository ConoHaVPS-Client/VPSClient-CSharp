using System.Text.Json.Serialization;

namespace ConohaVPS.HTTPRequests.Identify.JsonStructs;

public readonly struct RequestTokenSerializeRoot
{
    [JsonInclude]
    [JsonPropertyName("auth")]
    public Auth? Auth { get; init; }

    [JsonConstructor]
    public RequestTokenSerializeRoot(Auth auth) => Auth = auth;
}

public class Auth
{
    [JsonInclude]
    [JsonPropertyName("passwordCredentials")]
    public PasswordCredentials? PasswordCredentials { get; init; }

    [JsonInclude]
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; init; }
}

public class PasswordCredentials
{
    [JsonInclude]
    [JsonPropertyName("username")]
    public string? Username { get; init; }

    [JsonInclude]
    [JsonPropertyName("password")]
    public string? Password { get; init; }
}