class WeighingMachine
{
    public int Precision {get; private set;}
    private double _weight;
    public double Weight 
    {
        get => _weight;
        set 
        { 
            if (value < 0) throw new ArgumentOutOfRangeException();
            _weight = value;
        }
    }

    public double TareAdjustment {get; set;} = 5.0;

    public string DisplayWeight{get => $"{(Weight - TareAdjustment).ToString($"F{Precision}")} kg";}

    public WeighingMachine(int precision)
    {
        Precision = precision;
    }
}
