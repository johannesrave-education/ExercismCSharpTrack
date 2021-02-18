using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        word = word.ToLower();
        return !word.Where((c, i) => word.IndexOf(c) != i && char.IsLetter(c)).Any();
    }
}
