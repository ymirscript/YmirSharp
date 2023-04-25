using System.Text.Json;
using System.Text.Json.Serialization;

namespace YmirSharp.Converters;

internal abstract class EnumTypeConverter<T> : JsonConverter<T> where T : Enum
{
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var type = reader.GetString();
        
        if (type is null)
            throw new JsonException("Expected a string.");
        
        return GetEnum(type);
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        throw new NotSupportedException("This converter is only used for deserialization.");
    }
    
    protected abstract T GetEnum(string type);
}