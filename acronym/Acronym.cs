using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        return phrase
            .ToUpper()
            .Select(c => (c == '-') ? ' ' : c)
            .Where(c => (('A' <= c && c <= 'Z') || c == ' '))
            .ToArray().convertToString()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(s => s[0])
            .ToArray().convertToString();
    }

    private static string convertToString(this char[] array) => new string(array);
}