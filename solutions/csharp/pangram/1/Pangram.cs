public static class Pangram
{
    public static bool IsPangram(string input)
    {
        HashSet<char> uniqueLetters = new HashSet<char>();
        foreach (char letter in input.ToLower())
            if (Char.IsLetter(letter))
                uniqueLetters.Add(letter);
        return uniqueLetters.Count == 26 ? true : false;
    }
}
