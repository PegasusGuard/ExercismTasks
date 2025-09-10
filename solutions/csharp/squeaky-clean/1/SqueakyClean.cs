using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        // creating a new StringBuilder
        StringBuilder finalString = new StringBuilder(identifier);
        //Replacing all the Whitespaces with underscores
        finalString.Replace(' ', '_');

        //Replacing all control characters witth "CTRL"
        for (int i = 0; i < finalString.Length; i++)
        {
            if (Char.IsControl(finalString[i]))
            {
                finalString.Remove(i, 1);
                finalString.Insert(i, "CTRL");
            }
        }

        //Converting kebab-case to camelCase
        for (int i = 0; i < finalString.Length - 1; i++)
        {
            if (finalString[i] == '-')
            {
                finalString.Remove(i, 1);
                finalString[i] = Char.ToUpper(finalString[i]);
                i--;
            }
        }

        //Omitting all non-letters aand greek lower-case
        for (int i = 0; i < finalString.Length; i++)
        {
            if ((!Char.IsLetter(finalString[i]) && finalString[i] != '_') || (finalString[i] >= 'α' && finalString[i] <= 'ω'))
            {
                finalString.Remove(i, 1);
                i--;
            }
        }

        return finalString.ToString(); 
    }
}
