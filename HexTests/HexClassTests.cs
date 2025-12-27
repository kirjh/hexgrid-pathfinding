namespace HexTests;
using HexGrid;

[TestClass]
public sealed class HexClassTests 
{

  // Test constructor with standard values
  [TestMethod]
  public void TestClassConstructor1() {
    Hex hex = new Hex(1, 2);

    Assert.IsTrue(hex.Q + hex.R + hex.S == 0, "value s incorrect; q + r + s should sum to 0");
  }
  // Test constructor with standard values
  [TestMethod]
  public void TestEquality1() {
    Hex a = new Hex(1, 2);
    Hex b = new Hex(2, 1);

    Assert.IsTrue(!a.Equals(b), "value s incorrect; q + r + s should sum to 0");
  }
  // Test HashCode
  [TestMethod]
  public void TestHash1() {
    Hex a = new Hex(1, 2);
    Hex b = new Hex(1, 2);

    Assert.IsTrue(a.GetHashCode() == b.GetHashCode(), "value s incorrect; q + r + s should sum to 0");
  }
  // Test HashCode
  [TestMethod]
  public void TestHash2() {
    Hex a = new Hex(1, 2);
    Hex b = new Hex(2, 1);

    Assert.IsTrue(a.GetHashCode() != b.GetHashCode(), "value s incorrect; q + r + s should sum to 0");
  }
}
