[Flags]
public enum Allergen : byte
{
    Eggs = 1 << 0,
    Peanuts = 1 << 1,
    Shellfish = 1 << 2,
    Strawberries = 1 << 3,
    Tomatoes = 1 << 4,
    Chocolate = 1 << 5,
    Pollen = 1 << 6,
    Cats = 1 << 7
}

public class Allergies
{
    private Allergen _allergies;
    
    public Allergies(int mask) => _allergies = (Allergen)mask;

    public bool IsAllergicTo(Allergen allergen) => _allergies.HasFlag(allergen);

    public Allergen[] List() => Enum.GetValues(typeof(Allergen)).Cast<Allergen>().Where(c => _allergies.HasFlag(c)).ToArray();
}