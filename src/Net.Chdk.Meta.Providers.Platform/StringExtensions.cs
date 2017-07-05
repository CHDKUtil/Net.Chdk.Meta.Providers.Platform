namespace Net.Chdk.Meta.Providers.Platform
{
    static class StringExtensions
    {
        public static string TrimStart(this string str, string value)
        {
            return str.StartsWith(value)
                ? str.Substring(value.Length)
                : str;
        }

        public static string TrimEnd(this string str, string value)
        {
            return str.EndsWith(value)
                ? str.Substring(0, str.Length - value.Length)
                : str;
        }
    }
}
