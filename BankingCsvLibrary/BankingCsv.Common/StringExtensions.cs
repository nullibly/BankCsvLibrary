namespace BankingCsv.Common
{
    public static class StringExtensions
    {
        public static string StripQuotes(this string value)
        {
            var strippedEntry = value;

            if (strippedEntry.StartsWith("\""))
                strippedEntry = strippedEntry.Substring(1, strippedEntry.Length - 1);

            if (strippedEntry.EndsWith("\""))
                strippedEntry = strippedEntry.Substring(0, strippedEntry.Length - 1);

            return strippedEntry;
        }
    }
}
