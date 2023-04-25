using System.Text.Json;

namespace YmirSharp.Converters;

internal sealed class QueryParameterTypeConverter : EnumTypeConverter<QueryParameterType>
{
    protected override QueryParameterType GetEnum(string type)
    {
        return type.ToLower() switch
        {
            "any" => QueryParameterType.Any,
            "string" => QueryParameterType.String,
            "int" => QueryParameterType.Int,
            "float" => QueryParameterType.Float,
            "bool" => QueryParameterType.Bool,
            "date" => QueryParameterType.Date,
            "datetime" => QueryParameterType.DateTime,
            "time" => QueryParameterType.Time,
            _ => throw new JsonException($"Unknown query parameter type '{type}'.")
        };
    }
}