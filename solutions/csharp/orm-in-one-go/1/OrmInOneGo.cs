public class Orm
{
    private Database database;

    public Orm(Database database)
    {
        this.database = database;
    }

    public void Write(string data)
    {
        using (var currentDb = database)
        {
            currentDb.BeginTransaction();
            currentDb.Write(data);
            currentDb.EndTransaction();
        }
    }

    public bool WriteSafely(string data)
    {
        using var currentDb = database;
        try
        {
            currentDb.BeginTransaction();
            currentDb.Write(data);
            currentDb.EndTransaction();
        }
        catch (InvalidOperationException e)
        {
            return false;
        }
        return true;
    }
}
