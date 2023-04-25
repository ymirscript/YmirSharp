using System.Text.Json.Serialization;

namespace YmirSharp;

/// <summary>
/// The data which is passed from Ymir to the external compiler/target plugin.
/// 
/// <typeparam name="T">The type of the config.</typeparam>
/// </summary>
public sealed class YmirData
{
    /// <summary>
    /// The project node containing all the parsed data.
    /// </summary>
    [JsonPropertyName("project")]
    public ProjectNode Project  { get; set; }
    
    /// <summary>
    /// The special config for the compiler.
    /// </summary>
    [JsonPropertyName("config")]
    public Dictionary<string, object> Config  { get; set; }
    
    /// <summary>
    /// The output directory where the generated files should be placed.
    /// </summary>
    [JsonPropertyName("output")]
    public string Output  { get; set; }
}