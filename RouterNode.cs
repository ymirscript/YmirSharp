using System.Text.Json.Serialization;

namespace YmirSharp;

/// <summary>
/// The router node describes a router in the project. It holds routes, middlewares and other information.
/// </summary>
public class RouterNode : SyntaxNode
{
    /// <summary>
    /// The base path of the router.
    /// </summary>
    [JsonPropertyName("path")]
    public PathNode Path { get; }
    
    /// <summary>
    /// All routers that are children of this router.
    /// </summary>
    [JsonPropertyName("routers")]
    public RouterNode[] Routers { get; }
    
    /// <summary>
    /// All routes that are children of this router.
    /// </summary>
    [JsonPropertyName("routes")]
    public RouteNode[] Routes { get; }
    
    /// <summary>
    /// Optional header validation schema defined through middleware options.
    ///
    /// <remarks>
    /// Every route in this router will inherit this header validation schema. If a route has its own header validation schema, it will be merged with this one.
    /// </remarks>
    /// </summary>
    [JsonPropertyName("header")]
    public MiddlewareOptions? Header { get; }
    
    /// <summary>
    /// Optional body validation schema defined through middleware options.
    ///
    /// <remarks>
    /// Every route in this router will inherit this body validation schema. If a route has its own body validation schema, it will be merged with this one.
    /// </remarks>
    /// </summary>
    [JsonPropertyName("body")]
    public MiddlewareOptions? Body { get; }
    
    /// <summary>
    /// The authenticator that is used for this route.
    /// </summary>
    [JsonPropertyName("authenticate")]
    public AuthenticateClauseNode? Authenticate { get; }
    
    [JsonConstructor]
    internal RouterNode(PathNode path, RouterNode[] routers, RouteNode[] routes, MiddlewareOptions? header, MiddlewareOptions? body, AuthenticateClauseNode? authenticate)
    {
        Path = path;
        Routers = routers;
        Routes = routes;
        Header = header;
        Body = body;
        Authenticate = authenticate;
    }
}