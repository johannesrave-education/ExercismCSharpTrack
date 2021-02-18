using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        phrase = phrase.Replace("-", " ").ToUpper();
        string normalized = Regex.Replace(phrase, "[^A-Z0-9 ]", string.Empty);
        return new string(normalized.Split(" ").Where(s =>s != string.Empty).Select(s => s[0]).ToArray());
    }
}