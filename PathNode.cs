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
    public string Path { get; }
    
    /// <summary>
    /// The optional alias of the path. Used when compiling to target language as reference.
    /// </summary>
    public string? Alias { get; }
    
    /// <summary>
    /// An array of query parameters that are used in the path.
    /// </summary>
    public QueryParameterNode[] QueryParameters { get; }
    
    [JsonConstructor]
    internal PathNode(string path, string? alias, QueryParameterNode[] queryParameters)
    {
        Path = path;
        Alias = alias;
        QueryParameters = queryParameters;
    }
}