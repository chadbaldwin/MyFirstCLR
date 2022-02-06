using Microsoft.SqlServer.Server;
using System.Text.RegularExpressions;

public class CLR
{
    [SqlFunction(IsDeterministic = true, DataAccess = DataAccessKind.None)]
    public static string ReplaceRegex(string input, string pattern, string replacement)
        => (input == null || pattern == null || replacement == null) ? null : Regex.Replace(input, pattern, replacement);

    [SqlFunction(IsDeterministic = true, DataAccess = DataAccessKind.None)]
    public static bool? IsRegexMatch(string input, string pattern)
        => (input == null || pattern == null) ? (bool?)null : Regex.IsMatch(input, pattern, RegexOptions.IgnoreCase);
}
