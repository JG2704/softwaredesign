namespace DUA.Application.Mappers;

public static class PlaceholderMapper
{
    public static TTarget Map<TTarget>(object source) where TTarget : new() => new();
}
