public class CircularBuffer<T>
{
    private int _capacity; 
    private List<T> _buffer;
    
    public CircularBuffer(int capacity)
    {
        _buffer = new List<T>(capacity);
        _capacity = capacity;
    }

    public T Read() 
    {
        if (_buffer.Count == 0) throw new InvalidOperationException("Nothing to read. The buffer is empty");

        var result = _buffer[0];
        _buffer.RemoveAt(0);
        return result;
    }

    public void Write(T value) 
    {
       if (_buffer.Count == _capacity) throw new InvalidOperationException("Can't write. The buffer is full");
        _buffer.Add(value);
    }

    public void Overwrite(T value)
    {
        try
        {
            Write(value);
        }
        catch (InvalidOperationException)
        {
            _buffer.RemoveAt(0);
            Write(value);
        }
    }

    public void Clear() => _buffer.Clear();
}