using System.Text;
using System.Text.Json;
using YmirSharp.Converters;

namespace YmirSharp;

public static class Extensions
{
    /// <summary>
    /// Extracts the <see cref="YmirData"/> from the passed argument array. The first argument is expected to be the serialized <see cref="YmirData"/> as base64 encoded JSON string.
    /// </summary>
    public static YmirData? GetYmirData(this string[] args)
    {
        var json = Encoding.UTF8.GetString(Convert.FromBase64String(args[0]));

        return JsonSerializer.Deserialize<YmirData>(json,
            new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Converters =
                {
                    new AuthTypeConverter()
                }
            });
    }
}