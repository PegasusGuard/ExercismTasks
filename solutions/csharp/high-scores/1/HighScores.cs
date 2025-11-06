public class HighScores
{
    private List<int> _scores;
    
    public HighScores(List<int> list)
    {
        _scores = list;
    }

    public List<int> Scores() => _scores;

    public int Latest() => _scores.Last();

    public int PersonalBest() => PersonalTopThree()[0];

    public List<int> PersonalTopThree()
    {
        List<int> sorted = new List<int>(_scores);
        sorted.Sort();
        sorted.Reverse();
        return sorted.GetRange(0, 3 < sorted.Count ? 3 : sorted.Count);
    }
}