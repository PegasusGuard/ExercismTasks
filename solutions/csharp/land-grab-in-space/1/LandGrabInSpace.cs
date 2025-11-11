public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }
}

public struct Plot
{
    private Coord _rightTop, _leftTop, _leftBottom, _rightBottom;
    
    public Plot(Coord rightTop, Coord leftTop, Coord leftBottom, Coord rightBottom)
    {
        (_rightTop, _leftTop, _leftBottom, _rightBottom) = (rightTop, leftTop, leftBottom, rightBottom);
    }
    public uint MaxSide() 
    {
        ushort[] sides = new ushort[4]
        {
            (ushort)Math.Sqrt(Math.Pow(_rightTop.X-_leftTop.X, 2) + Math.Pow(_rightTop.Y-_leftTop.Y, 2)),
            (ushort)Math.Sqrt(Math.Pow(_leftTop.X-_leftBottom.X, 2) + Math.Pow(_leftTop.Y-_leftBottom.Y, 2)),
            (ushort)Math.Sqrt(Math.Pow(_leftBottom.X-_rightBottom.X, 2) + Math.Pow(_leftBottom.Y-_rightBottom.Y, 2)),
            (ushort)Math.Sqrt(Math.Pow(_rightBottom.X-_rightTop.X, 2) + Math.Pow(_rightBottom.Y-_rightTop.Y, 2))
        };
        return sides.Max();
    }
}


public class ClaimsHandler
{
    private static HashSet<Plot> _claims = new HashSet<Plot>();

    private Plot lastStake; 
    
    public void StakeClaim(Plot plot) => _claims.Add(lastStake = plot);

    public bool IsClaimStaked(Plot plot) => _claims.Contains(plot);

    public bool IsLastClaim(Plot plot) => Plot.Equals(lastStake, plot);

    public Plot GetClaimWithLongestSide() => _claims.OrderByDescending(plot => plot.MaxSide()).First();
}
