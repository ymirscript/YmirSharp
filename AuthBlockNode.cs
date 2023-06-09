﻿using System.Text.Json.Serialization;
using YmirSharp.Converters;

namespace YmirSharp;

/// <summary>
/// The auth block node describes the basic information about the authentication process.
/// </summary>
public sealed class AuthBlockNode : SyntaxNode
{
    /// <summary>
    /// The alias of the authenticator that is used.
    /// </summary>
    [JsonPropertyName("alias")]
    public string? Alias  { get; set; }
    
    /// <summary>
    /// The type of the authentication process.
    /// </summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(AuthTypeConverter))]
    public AuthType Type  { get; set; }
    
    /// <summary>
    /// The source from which the authentication information is taken.
    /// </summary>
    [JsonPropertyName("source")]
    [JsonConverter(typeof(AuthSourceTypeConverter))]
    public AuthSource Source  { get; set; }
    
    /// <summary>
    /// The name of the field that is used for authentication.
    /// </summary>
    [JsonPropertyName("field")]
    public string Field  { get; set; }
    
    /// <summary>
    /// Whether the default access is public or not.
    /// </summary>
    [JsonPropertyName("isDefaultAccessPublic")]
    public bool? IsDefaultAccessPublic  { get; set; }
    
    /// <summary>
    /// Whether the authorization is in use or not.
    /// </summary>
    [JsonPropertyName("isAuthorizationInUse")]
    public bool IsAuthorizationInUse { get; set; }
}