using System.Text.Json.Serialization;

namespace ConohaVPS.HTTPRequests.Identify.JsonStructs;


public readonly struct RequestTokenDeserializeRoot
{
    [JsonInclude]
    [JsonPropertyName("access")]
    public Access? Access { get; init; }

    [JsonConstructor]
    public RequestTokenDeserializeRoot(Access access) => Access = access;

}
public class Access
{
    [JsonInclude]
    [JsonPropertyName("token")]
    public Token? Token { get; init; }

    [JsonInclude]
    [JsonPropertyName("serviceCatalog")]
    public Servicecatalog[]? ServiceCatalog { get; init; }

    [JsonInclude]
    [JsonPropertyName("user")]
    public User? User { get; init; }

    [JsonInclude]
    [JsonPropertyName("metadata")]
    public Metadata? Metadata { get; init; }
}
public class Token
{
    [JsonInclude]
    [JsonPropertyName("issued_at")]
    public DateTime Issued_at { get; init; }

    [JsonInclude]
    [JsonPropertyName("expires")]
    public DateTime Expires { get; init; }

    [JsonInclude]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonInclude]
    [JsonPropertyName("tenant")]
    public Tenant? Tenant { get; init; }

    [JsonInclude]
    [JsonPropertyName("audit_ids")]
    public string[]? Audit_ids { get; init; }
}
public class Tenant
{
    [JsonInclude]
    [JsonPropertyName("domain_id")]
    public string? Domain_id { get; init; }

    [JsonInclude]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonInclude]
    [JsonPropertyName("enabled")]

    public bool Enabled { get; init; }

    [JsonInclude]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonInclude]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
public class User
{
    [JsonInclude]
    [JsonPropertyName("username")]
    public string? Username { get; init; }

    [JsonInclude]
    [JsonPropertyName("roles_links")]
    public object[]? Roles_links { get; init; }

    [JsonInclude]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonInclude]
    [JsonPropertyName("roles")]
    public Role[]? Roles { get; init; }

    [JsonInclude]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
public class Role
{
    [JsonInclude]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
public class Metadata
{
    [JsonInclude]
    [JsonPropertyName("is_admin")]
    public int Is_admin { get; init; }

    [JsonInclude]
    [JsonPropertyName("roles")]
    public string[]? Roles { get; init; }
}
public class Servicecatalog
{
    [JsonInclude]
    [JsonPropertyName("endpoints")]
    public Endpoint[]? Endpoints { get; init; }

    [JsonInclude]
    [JsonPropertyName("endpoints_links")]
    public object[]? Endpoints_links { get; init; }

    [JsonInclude]
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonInclude]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
public class Endpoint
{
    [JsonInclude]
    [JsonPropertyName("region")]
    public string? Region { get; init; }

    [JsonInclude]
    [JsonPropertyName("publicURL")]
    public string? PublicURL { get; init; }
}