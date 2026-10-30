public class Anagram
{
    
   private readonly string _baseWord;
    private readonly string _sortedBase;

    public Anagram(string baseWord)
    {
        _baseWord = baseWord;
        _sortedBase = SortLetters(baseWord);
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        return potentialMatches
            .Where(m => !m.Equals(_baseWord, StringComparison.OrdinalIgnoreCase)
                     && SortLetters(m) == _sortedBase)
            .ToArray();
    }

    private static string SortLetters(string word)
    {
        var chars = word.ToLowerInvariant().ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }
}