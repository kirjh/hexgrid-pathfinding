namespace HexGrid;
public class HexTile : Hex
{
  private int _type { get; set; }
  private int _level { get; set; }
  public int Type { get { return _type; } }
  public int Level { get { return _level; } }

  public HexTile(Hex hex, int type, int level) : base(hex.Q, hex.R)
  {
    _type = type;
    _level = level;
  }
  public HexTile(int q, int r, int type, int level) : base(q, r)
  {
    _type = type;
    _level = level;
  }

  // Overrides
  public override string ToString() 
  {
    return $"<HexTile[{Q}, {R}, {S}] type={_type} level={_level}>";
  }
  public override bool Equals(object? obj)
  {
    if (obj is not HexTile hextile) return false;

    return Q == hextile.Q && R == hextile.R && Type == hextile.Type && Level == hextile.Level;
  }
  public override int GetHashCode()
  {
    return (Q, R, Type, Level).GetHashCode();
  }
}