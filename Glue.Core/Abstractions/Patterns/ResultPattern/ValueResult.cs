namespace Glue.Core.Abstractions.Patterns.ResultPattern;

public class ValueResult<T> {
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public Error Error { get; }
    public T? Value { get; }
    public static ValueResult<T> Success(T value) => new(true, Error.None, value);
    public static ValueResult<T> Failure(Error error) => new(false, error, default);

    private ValueResult(bool isSuccess, Error error, T? value) {
        if (isSuccess && error != Error.None || !isSuccess && error == Error.None) {
            throw new ArgumentException("Invalid error", nameof(error));
        }

        if (isSuccess && value is null) {
            throw new ArgumentNullException(nameof(value), "Successfull results must have a value.");
        }

        IsSuccess = isSuccess;
        Error = error;
        Value = value;
    }
}
