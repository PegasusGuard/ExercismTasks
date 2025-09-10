public class Player
{
    public int RollDie()
    {
        var random = new System.Random();
        return random.Next(1, 18);
    }

    public double GenerateSpellStrength()
    {
        var random = new System.Random();
        return random.NextDouble() * 100;
    }
}
