﻿using System.Text.Json.Serialization;
using YmirSharp.Converters;

namespace YmirSharp;

/// <summary>
/// The query parameter node describes a query parameter in a route.
/// </summary>
public sealed class QueryParameterNode : SyntaxNode
{
    /// <summary>
    /// The name of the query parameter.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; }

    /// <summary>
    /// The type of the query parameter.
    /// </summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(QueryParameterTypeConverter))]
    public QueryParameterType Type { get; }
    
    [JsonConstructor]
    internal QueryParameterNode(string name, QueryParameterType type)
    {
        Name = name;
        Type = type;
    }
}