public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    public bool Equals(FacialFeatures faceB) => faceB != null 
                                                && EyeColor == faceB.EyeColor 
                                                && PhiltrumWidth == faceB.PhiltrumWidth;

     public override int GetHashCode() => HashCode.Combine(EyeColor, PhiltrumWidth);
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }

    public override bool Equals(Object obj) => 
        ReferenceEquals(this, obj) || 
        Equals(obj as Identity);
    
    public bool Equals(Identity other) => 
        other != null && 
        this.Email.Equals(other.Email) && 
        this.FacialFeatures.Equals(other.FacialFeatures);
    
    public override int GetHashCode() => 
        HashCode.Combine(this.Email, this.FacialFeatures);
}

public class Authenticator
{
    private static Identity _admin = new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m));

    private HashSet<Identity> _registeredIdentities = new();
    
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }

    public bool IsAdmin(Identity identity) => identity.Equals(_admin);

    public bool Register(Identity identity) => 
        !IsRegistered(identity) && 
        _registeredIdentities.Add(identity);
    
    public bool IsRegistered(Identity identity) => 
        _registeredIdentities.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB) => ReferenceEquals(identityA, identityB);
}
