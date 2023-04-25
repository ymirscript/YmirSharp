using System.Text.Json.Serialization;

namespace YmirSharp;

/// <summary>
/// The middleware node describes a middleware in the project. It can be used in routers and routes by the "use" keyword.
/// </summary>
public sealed class MiddlewareNode : SyntaxNode
{
    /// <summary>
    /// The name of the middleware that is used.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name  { get; set; }
    
    /// <summary>
    /// The options that are used in the middleware.
    /// </summary>
    [JsonPropertyName("options")]
    public MiddlewareOptions Options  { get; set; }
}