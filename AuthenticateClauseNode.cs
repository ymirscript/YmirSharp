using System.Text.Json.Serialization;

namespace YmirSharp;

/// <summary>
/// The authenticate clause node describes the authenticate for routes and routers.
/// </summary>
public sealed class AuthenticateClauseNode : SyntaxNode
{
    /// <summary>
    /// The alias or type of the auth block to use. If this is undefined, the default auth block is used.
    /// </summary>
    [JsonPropertyName("authBlock")]
    public string AuthBlock  { get; set; }
    
    /// <summary>
    /// The roles that are required to access the route.
    /// </summary>
    [JsonPropertyName("authorization")]
    public string[]? Authorization  { get; set; }
}