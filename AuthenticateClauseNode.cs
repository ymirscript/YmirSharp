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
    public string AuthBlock { get; }
    
    /// <summary>
    /// The roles that are required to access the route.
    /// </summary>
    [JsonPropertyName("authorization")]
    public string[]? Authorization { get; }
    
    [JsonConstructor]
    internal AuthenticateClauseNode(string authBlock, string[]? authorization)
    {
        AuthBlock = authBlock;
        Authorization = authorization;
    }
}