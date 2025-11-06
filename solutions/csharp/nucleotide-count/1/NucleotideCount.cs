public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        IDictionary<char, int> nCount = new Dictionary<char, int>
        {
            {'A', 0},
            {'C', 0},
            {'G', 0},
            {'T', 0}
        };
        foreach (char nucleotide in sequence)
        {
            if (nCount.ContainsKey(nucleotide))
                nCount[nucleotide]++;
            else
                throw new ArgumentException();
        }
        return nCount;
    }
}