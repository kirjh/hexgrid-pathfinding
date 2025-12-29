namespace HexGrid;

public class Hex
{
  private int q { get; set; }
  private int r { get; set; }
  public int Q { get { return this.q; } }
  public int R { get { return this.r; } }
  public int S { get { return - this.q - this.r; } }

  // Axial Constructor
  public Hex(int Q, int R)
  {
    this.q = Q;
    this.r = R;
  }

  // Overrides
  public override string ToString() 
  {
    return $"[{this.Q}, {this.R}, {this.S}]";
  }
  public override bool Equals(object? obj)
  {
    if (obj is not Hex hex) return false;

    return this.q == hex.q && this.r == hex.r;
  }
  public override int GetHashCode()
  {
    return (this.q, this.r).GetHashCode();
  }
  // Basic Operations
  public static Hex Add(Hex A, Hex B)
  {
    return new Hex(A.Q + B.Q, A.R + B.R);
  }
  public static Hex Sub(Hex A, Hex B)
  {
    return new Hex(A.Q - B.Q, A.R - B.R);
  }
  public static Hex Mult(Hex A, int k)
  {
    return new Hex(A.Q * k, A.R * k);
  }
  public static Hex Mult(int k, Hex A)
  {
    return new Hex(A.Q * k, A.R * k);
  }
  public static Hex Div(Hex A, int k)
  {
    if (A.Q == 0 || A.R == 0 || A.S == 0) throw new DivideByZeroException();
    return new Hex(A.Q / k, A.R / k);
  }
  // Operand Overloads
  public static Hex operator +(Hex right) => right;
  public static Hex operator +(Hex left, Hex right) => Hex.Add(left, right);
  public static Hex operator -(Hex left, Hex right) => Hex.Sub(left, right);
  public static Hex operator *(Hex left, int right) => Hex.Mult(left, right);
  public static Hex operator *(int left, Hex right) => Hex.Mult(left, right);
  public static Hex operator /(Hex left, int right) => Hex.Div(left, right);
}
