using System.Text.Json;

namespace YmirSharp.Converters;

internal sealed class MethodTypeConverter : EnumTypeConverter<Method>
{
    protected override Method GetEnum(string type)
    {
        return type.ToUpper() switch
        {
            "GET" => Method.Get,
            "POST" => Method.Post,
            "PUT" => Method.Put,
            "PATCH" => Method.Patch,
            "DELETE" => Method.Delete,
            "OPTIONS" => Method.Options,
            "HEAD" => Method.Head,
            _ => throw new JsonException($"Unknown method type '{type}'.")
        };
    }
}