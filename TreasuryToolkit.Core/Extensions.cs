namespace TreasuryToolkit.Core;

public static class Extensions
{
    public static bool In<TSource>(this TSource source, params TSource[] list)
        => list.Contains(source);

    public static bool In<TSource>(this TSource source, IEnumerable<TSource> collection)
        => collection.Contains(source);
}