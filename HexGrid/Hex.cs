namespace HexGrid;

public class Hex
{
  private int _q { get; set; }
  private int _r { get; set; }
  public int Q { get { return _q; } }
  public int R { get { return _r; } }
  public int S { get { return - _q - _r; } }

  // Axial Constructor
  public Hex(int Q, int R)
  {
    _q = Q;
    _r = R;
  }

  // Distance
  public static int Distance(Hex A, Hex B)
  {
    int[] x = [Math.Abs(A.Q - B.Q), Math.Abs(A.R - B.R), Math.Abs(A.S - B.S)];
    return x.Max();
  }

  // Overrides
  public override string ToString() 
  {
    return $"[{Q}, {R}, {S}]";
  }
  public override bool Equals(object? obj)
  {
    if (obj is not Hex hex) return false;

    return _q == hex.Q && _r == hex.R;
  }
  public override int GetHashCode()
  {
    return (_q, _r).GetHashCode();
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
  public static Hex operator +(Hex left, Hex right) => Add(left, right);
  public static Hex operator -(Hex left, Hex right) => Sub(left, right);
  public static Hex operator *(Hex left, int right) => Mult(left, right);
  public static Hex operator *(int left, Hex right) => Mult(left, right);
  public static Hex operator /(Hex left, int right) => Div(left, right);
}
