public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        string result = "";
        foreach (char letter in text)          
            result += Char.IsLetter(letter) ? (Char.IsUpper(letter) ? (char)((letter-'A' + shiftKey) % 26 + 'A') : (char)((letter-'a' + shiftKey) % 26 + 'a')) : letter;
        return result;
    }
}