public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    public static bool operator ==(CurrencyAmount a, CurrencyAmount b) =>
        SameCurrency(a, b) ? a.amount == b.amount : throw new ArgumentException();

    public static bool operator !=(CurrencyAmount a, CurrencyAmount b) =>
        SameCurrency(a, b) ? a.amount != b.amount : throw new ArgumentException();
    
    public static bool operator >(CurrencyAmount a, CurrencyAmount b) =>
        SameCurrency(a, b) ? a.amount > b.amount : throw new ArgumentException();

    public static bool operator <(CurrencyAmount a, CurrencyAmount b) =>
        SameCurrency(a, b) ? a.amount < b.amount : throw new ArgumentException();

    public static CurrencyAmount operator +(CurrencyAmount a, CurrencyAmount b) =>
        SameCurrency(a, b) ? new CurrencyAmount(a.amount + b.amount, a.currency) : throw new ArgumentException();

    public static CurrencyAmount operator -(CurrencyAmount a, CurrencyAmount b) =>
        SameCurrency(a, b) ? new CurrencyAmount(a.amount - b.amount, a.currency) : throw new ArgumentException();
    
    public static CurrencyAmount operator *(CurrencyAmount a, decimal b) =>
        new CurrencyAmount(a.amount * b, a.currency);

    public static CurrencyAmount operator /(CurrencyAmount a, decimal b) =>
        new CurrencyAmount(a.amount / b, a.currency);

    public static implicit operator double(CurrencyAmount a) => (double)a.amount;
    
    public static implicit operator decimal(CurrencyAmount a) => a.amount;

    private static bool SameCurrency(CurrencyAmount a, CurrencyAmount b) =>
        a.currency == b.currency ? true : throw new ArgumentException();

}
