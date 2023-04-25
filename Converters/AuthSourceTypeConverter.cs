using System.Text.Json;

namespace YmirSharp.Converters;

internal sealed class AuthSourceTypeConverter : EnumTypeConverter<AuthSource>
{
    protected override AuthSource GetEnum(string type)
    {
        return type switch
        {
            "header" => AuthSource.Header,
            "body" => AuthSource.Body,
            "query" => AuthSource.Query,
            _ => throw new JsonException($"Unknown auth source type: {type}")
        };
    }
}