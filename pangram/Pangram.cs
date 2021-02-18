using System.Linq;

public static class Pangram
{
    private static readonly string Alphabet = "abcdefghijklmnopqrstuvwxyz";

    public static bool IsPangram(string input) => Alphabet.All(c => input.ToLower().Contains(c));
}
