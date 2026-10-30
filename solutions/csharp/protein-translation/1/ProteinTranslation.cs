public static class ProteinTranslation
{
    private static readonly Dictionary<string, string> CodonMap = new()
    {
        ["AUG"] = "Methionine",
        ["UUU"] = "Phenylalanine",
        ["UUC"] = "Phenylalanine",
        ["UUA"] = "Leucine",
        ["UUG"] = "Leucine",
        ["UCU"] = "Serine",
        ["UCC"] = "Serine",
        ["UCA"] = "Serine",
        ["UCG"] = "Serine",
        ["UAU"] = "Tyrosine",
        ["UAC"] = "Tyrosine",
        ["UGU"] = "Cysteine",
        ["UGC"] = "Cysteine",
        ["UGG"] = "Tryptophan",
        ["UAA"] = "STOP",
        ["UAG"] = "STOP",
        ["UGA"] = "STOP"
    };
    public static string[] Proteins(string strand)
    {
        string[] parts = Enumerable
         .Range(0, (strand.Length + 2) / 3)
         .Select(i => strand.Substring(i * 3, Math.Min(3, strand.Length - i * 3)))
         .ToArray();
        var result = new List<string>();
        foreach (string u in parts)
        {
            CodonMap.TryGetValue(u, out string v);
            if(v == "STOP")
            {
                break;
            }
            result.Add(v);
        }
        return result.ToArray<string>();


    }
}