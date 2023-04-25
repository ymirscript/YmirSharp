using System.Text.Json;
using System.Text.Json.Serialization;
using YmirSharp.Converters;

namespace YmirSharp;

/// <summary>
/// The project node is the root node of the syntax tree.
/// </summary>
public sealed class ProjectNode : RouterNode
{
    /// <summary>
    /// The target language of the compiled project.
    /// </summary>
    public string Target { get; }
    
    /// <summary>
    /// The authenticators that are used in the project.
    /// </summary>
    [JsonConverter(typeof(AuthTypeConverter))]
    [JsonPropertyName("authBlocks")]
    public Dictionary<AuthType, AuthBlockNode> AuthBlocks { get; }
    
    /// <summary>
    /// The middlewares that are used in this router.
    /// </summary>
    [JsonPropertyName("middlewares")]
    public MiddlewareNode[] Middlewares { get; }

    [JsonConstructor]
    internal ProjectNode(string target, Dictionary<AuthType, AuthBlockNode> authBlocks, MiddlewareNode[] middlewares, PathNode path, RouterNode[] routers, RouteNode[] routes, MiddlewareOptions? header, MiddlewareOptions? body, AuthenticateClauseNode? authenticate) : base(path, routers, routes, header, body, authenticate)
    {
        Target = target;
        AuthBlocks = authBlocks;
        Middlewares = middlewares;
    }

    /// <summary>
    /// Deserializes a project node from a json string.
    /// </summary>
    public static ProjectNode? Deserialize(string json) => JsonSerializer.Deserialize<ProjectNode>(json,
        new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Converters =
            {
                new AuthTypeConverter()
            }
        });
}