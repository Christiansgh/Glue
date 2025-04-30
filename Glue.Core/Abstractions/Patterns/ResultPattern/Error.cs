namespace Glue.Core.Abstractions.Patterns.ResultPattern;
public sealed record Error(string ErrorCode, string Description) {
    public static readonly Error None = new(string.Empty, string.Empty);
}
