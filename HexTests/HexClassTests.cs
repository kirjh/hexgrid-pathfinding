namespace HexTests;
using HexGrid;

[TestClass]
public sealed class HexClassTests 
{

  // Test Constructor
  [TestMethod]
  public void TestClassConstructor1() {
    Hex hex = new Hex(1, 2);

    Assert.IsTrue(hex.Q + hex.R + hex.S == 0, $"Values incorrect: q({hex.Q}) + r({hex.R}) + s({hex.S}) should sum to 0.");
  }
  // Test Equality
  [TestMethod]
  public void TestEquality1() {
    Hex a = new Hex(1, 2);
    Hex b = new Hex(2, 1);

    Assert.IsTrue(!a.Equals(b), "Equality incorrectly evaluated as true.");
  }
  [TestMethod]
  public void TestEquality2() {
    Hex a = new Hex(-10, 200);
    Hex b = new Hex(-10, 200);

    Assert.IsTrue(a.Equals(b), "Equality incorrectly evaluated as false.");
  }
  // Test HashCode
  [TestMethod]
  public void TestHash() {
    Hex a = new Hex(1, 2);
    Hex b = new Hex(1, 2);

    Assert.IsTrue(a.GetHashCode() == b.GetHashCode(), "Same hashcode expected.");
  }

  // Test basic operations
  [TestMethod]
  public void TestAdd() {
    Hex a = new Hex(2, 4);
    Hex b = new Hex(1, 2);
    
    Hex add = Hex.Add(b, b);
    bool x = add.Equals(a);

    Assert.IsTrue(x, $"Expected: {a}, Actual: {add}");
  }
  [TestMethod]
  public void TestSub() {
    Hex a = new Hex(2, 4);
    Hex b = new Hex(1, 2);

    Hex sub = Hex.Sub(a, b);
    bool x = sub.Equals(b);

    Assert.IsTrue(x, $"Expected: {b}, Actual: {sub}");
  }
  [TestMethod]
  public void TestMult() {
    Hex a = new Hex(2, 4);
    Hex b = new Hex(4, 8);

    Hex mult = Hex.Mult(a, 2);
    bool x = mult.Equals(b);

    Assert.IsTrue(x, $"Expected: {b}, Actual: {mult}");
  }
  [TestMethod]
  public void TestDiv() {
    Hex a = new Hex(2, 4);
    Hex b = new Hex(4, 8);

    Hex mult = Hex.Div(b, 2);
    bool x = mult.Equals(a);

    Assert.IsTrue(x, $"Expected: {a}, Actual: {mult}");
  }

  // Test operands
  [TestMethod]
  public void TestOpAdd() {
    Hex a = new Hex(2, 4);
    Hex b = new Hex(1, 2);
    
    Hex add = b + b;
    bool x = add.Equals(a);

    Assert.IsTrue(x, $"Expected: {a}, Actual: {add}");
  }
  [TestMethod]
  public void TestOpSub() {
    Hex a = new Hex(2, 4);
    Hex b = new Hex(1, 2);

    Hex sub = a - b;
    bool x = sub.Equals(b);

    Assert.IsTrue(x, $"Expected: {b}, Actual: {sub}");
  }
  [TestMethod]
  public void TestOpMult1() {
    Hex a = new Hex(2, 4);
    Hex b = new Hex(4, 8);

    Hex mult = a * 2;
    bool x = mult.Equals(b);

    Assert.IsTrue(x, $"Expected: {b}, Actual: {mult}");
  }
  [TestMethod]
  public void TestOpMult2() {
    Hex a = new Hex(2, 4);
    Hex b = new Hex(4, 8);

    Hex mult = 2 * a;
    bool x = mult.Equals(b);

    Assert.IsTrue(x, $"Expected: {b}, Actual: {mult}");
  }
  [TestMethod]
  public void TestOpDiv() {
    Hex a = new Hex(2, 4);
    Hex b = new Hex(4, 8);

    Hex mult = b / 2;
    bool x = mult.Equals(a);

    Assert.IsTrue(x, $"Expected: {a}, Actual: {mult}");
  }
}
