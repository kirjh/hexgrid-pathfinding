namespace HexGrid;

public class Hex
{
  private int q { get; set; }
  private int r { get; set; }
  public int Q { get { return this.q; } }
  public int R { get { return this.r; } }
  public int S { get { return - this.q - this.r; } }

  // Axial Constructor
  public Hex(int q, int r)
  {
    this.q = q;
    this.r = r;
  }

  // Overrides
  public override string ToString() {
    return $"[{this.Q}, {this.R}, {this.S}]";
  }
  public override bool Equals(object obj)
  {
    if (obj is not Hex hex) return false;

    return this.q == hex.q && this.r == hex.r;
  }
  public override int GetHashCode()
  {
    return (this.q, this.r).GetHashCode();
  }
}
