﻿using System.Text.Json.Serialization;
using YmirSharp.Converters;

namespace YmirSharp;

/// <summary>
/// The route node describes a route in the project. It holds the path, the method and validators/authenticators.
/// </summary>
public sealed class RouteNode : SyntaxNode
{
    /// <summary>
    /// The path of the route.
    /// </summary>
    [JsonPropertyName("path")]
    public PathNode Path  { get; set; }
    
    /// <summary>
    /// The method of the route.
    /// </summary>
    [JsonPropertyName("method")]
    [JsonConverter(typeof(MethodTypeConverter))]
    public Method Method  { get; set; }
    
    /// <summary>
    /// Optional header validation schema defined through middleware options.
    /// </summary>
    [JsonPropertyName("header")]
    public MiddlewareOptions? Header  { get; set; }
    
    /// <summary>
    /// Optional body validation schema defined through middleware options.
    /// </summary>
    [JsonPropertyName("body")]
    public MiddlewareOptions? Body  { get; set; }
    
    /// <summary>
    /// The authenticator that is used for this route.
    /// </summary>
    [JsonPropertyName("authenticate")]
    public AuthenticateClauseNode? Authenticate  { get; set; }
}