using System.Text.Json.Serialization;

namespace YmirSharp;

/// <summary>
/// The path node is used to describe a path in the project.
/// </summary>
public sealed class PathNode : SyntaxNode
{
    /// <summary>
    /// The path of the path.
    /// </summary>
    [JsonPropertyName("path")]
    public string Path  { get; set; }
    
    /// <summary>
    /// The optional alias of the path. Used when compiling to target language as reference.
    /// </summary>
    [JsonPropertyName("alias")]
    public string? Alias  { get; set; }
    
    /// <summary>
    /// An array of query parameters that are used in the path.
    /// </summary>
    [JsonPropertyName("queryParameters")]
    public QueryParameterNode[] QueryParameters  { get; set; }
}