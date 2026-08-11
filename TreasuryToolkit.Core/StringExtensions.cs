namespace TreasuryToolkit.Core
{
    public static class StringExtensions
    {
        extension(string str)
        {
            public bool HasValue => !string.IsNullOrEmpty(str) && str != "";
        }
    }
}