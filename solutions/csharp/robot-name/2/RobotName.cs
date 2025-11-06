public class Robot
{
    private static readonly Random rnd = new Random();
    private static HashSet<string> uniqueNames = new HashSet<string>();
    private string _name;
    public string Name
    {
        get 
        {
            if (_name is null)
                _GetUniqueName();
            return _name;
        }
    }

    public void Reset() => _GetUniqueName();

    private void _GetUniqueName()
    {
        do
        {
            _name = _GetRandomName();
        }
        while (!uniqueNames.Add(_name));
    }

    private string _GetRandomName()
    {
        char[] result = new char[5];
        for (int i = 0; i < 2; i ++)
            result[i] = (char)rnd.Next('A', 'Z' + 1);
        for (int i = 2; i < 5; i ++)
            result[i] = (char)rnd.Next('0', '9' + 1);
        return new string(result);
    }
}