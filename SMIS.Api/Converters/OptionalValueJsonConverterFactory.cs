using System.Text.Json;
using System.Text.Json.Serialization;
using SMIS.Application.Common.Models;

namespace SMIS.Api.Converters;

/// <summary>
/// API-only adapter that teaches System.Text.Json how to deserialize OptionalValue&lt;T&gt;.
/// The wrapper itself belongs to Application; JSON is an HTTP transport concern, so the converter stays here.
/// </summary>
public sealed class OptionalValueJsonConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(
        Type typeToConvert
    ) =>
        typeToConvert.IsGenericType
        && typeToConvert.GetGenericTypeDefinition() == typeof(OptionalValue<>);

    public override JsonConverter CreateConverter(
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        var valueType = typeToConvert.GetGenericArguments()[0];
        var converterType = typeof(OptionalValueJsonConverter<>).MakeGenericType(valueType);

        return (JsonConverter)Activator.CreateInstance(converterType)!;
    }

    private sealed class OptionalValueJsonConverter<T> : JsonConverter<OptionalValue<T>>
    {
        public override bool HandleNull => true;

        public override OptionalValue<T> Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var value = JsonSerializer.Deserialize<T>(ref reader, options);
            return new OptionalValue<T>(value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            OptionalValue<T> value,
            JsonSerializerOptions options
        ) => JsonSerializer.Serialize(writer, value.Value, options);
    }
}