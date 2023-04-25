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
    public PathNode Path  { get; set; }
    
    /// <summary>
    /// All routers that are children of this router.
    /// </summary>
    [JsonPropertyName("routers")]
    public RouterNode[] Routers  { get; set; }
    
    /// <summary>
    /// All routes that are children of this router.
    /// </summary>
    [JsonPropertyName("routes")]
    public RouteNode[] Routes  { get; set; }
    
    /// <summary>
    /// Optional header validation schema defined through middleware options.
    ///
    /// <remarks>
    /// Every route in this router will inherit this header validation schema. If a route has its own header validation schema, it will be merged with this one.
    /// </remarks>
    /// </summary>
    [JsonPropertyName("header")]
    public MiddlewareOptions? Header  { get; set; }
    
    /// <summary>
    /// Optional body validation schema defined through middleware options.
    ///
    /// <remarks>
    /// Every route in this router will inherit this body validation schema. If a route has its own body validation schema, it will be merged with this one.
    /// </remarks>
    /// </summary>
    [JsonPropertyName("body")]
    public MiddlewareOptions? Body  { get; set; }
    
    /// <summary>
    /// The authenticator that is used for this route.
    /// </summary>
    [JsonPropertyName("authenticate")]
    public AuthenticateClauseNode? Authenticate  { get; set; }
}