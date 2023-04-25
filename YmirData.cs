using System.Text.Json.Serialization;

namespace YmirSharp;

/// <summary>
/// The data which is passed from Ymir to the external compiler/target plugin.
/// 
/// <typeparam name="T">The type of the config.</typeparam>
/// </summary>
public sealed class YmirData<T>
{
    /// <summary>
    /// The project node containing all the parsed data.
    /// </summary>
    [JsonPropertyName("project")]
    public ProjectNode Project { get; }
    
    /// <summary>
    /// The special config for the compiler.
    /// </summary>
    [JsonPropertyName("config")]
    public T Config { get; }
    
    /// <summary>
    /// The output directory where the generated files should be placed.
    /// </summary>
    [JsonPropertyName("output")]
    public string Output { get; }
    
    [JsonConstructor]
    internal YmirData(ProjectNode project, T config, string output)
    {
        Project = project;
        Config = config;
        Output = output;
    }
}