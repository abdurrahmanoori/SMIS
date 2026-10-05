namespace SMIS.Application.Common.Models;

/// <summary>
/// Represents a value in a partial update where "not sent" and "sent as null" must be different.
/// Default(OptionalValue&lt;T&gt;) means the client did not provide the property; constructing it means
/// the client did provide the property, even when the provided value is null.
/// </summary>
public readonly struct OptionalValue<T>
{
    public OptionalValue(
        T? value
    )
    {
        IsSpecified = true;
        Value = value;
    }

    /// <summary>
    /// True when the property was explicitly supplied by the caller.
    /// </summary>
    public bool IsSpecified { get; }

    /// <summary>
    /// The supplied value. This can intentionally be null when IsSpecified is true.
    /// </summary>
    public T? Value { get; }

    public static implicit operator OptionalValue<T>(
        T? value
    ) => new(value);
}