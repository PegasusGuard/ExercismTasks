public class GradeSchool
{
    private Dictionary<string, int> roster = new Dictionary<string, int>();
        
    public bool Add(string student, int grade) => roster.TryAdd(student, grade);

    public IEnumerable<string> Roster() => roster.OrderBy(x => x.Value).ThenBy(x => x.Key).ToDictionary().Keys;

    public IEnumerable<string> Grade(int grade) => roster.Where(c => c.Value == grade).ToDictionary().Keys.Order();
}