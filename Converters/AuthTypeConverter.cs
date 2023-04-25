using System.Text.Json;

namespace YmirSharp.Converters;

internal sealed class AuthTypeConverter : EnumTypeConverter<AuthType>
{
    protected override AuthType GetEnum(string type)
    {
        return type switch
        {
            "API-Key" => AuthType.APIKey,
            "Bearer" => AuthType.Bearer,
            _ => throw new JsonException($"Unknown authentication type: {type}")
        };
    }
}