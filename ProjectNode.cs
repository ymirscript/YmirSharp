using System.Text.Json.Serialization;

namespace YmirSharp;

/// <summary>
/// The project node is the root node of the syntax tree.
/// </summary>
public sealed class ProjectNode : RouterNode
{
    /// <summary>
    /// The target language of the compiled project.
    /// </summary>
    public string Target  { get; set; }
    
    /// <summary>
    /// The authenticators that are used in the project.
    /// </summary>
    [JsonPropertyName("authBlocks")]
    public Dictionary<string, AuthBlockNode> AuthBlocks  { get; set; }
    
    /// <summary>
    /// The middlewares that are used in this router.
    /// </summary>
    [JsonPropertyName("middlewares")]
    public MiddlewareNode[] Middlewares  { get; set; }
}