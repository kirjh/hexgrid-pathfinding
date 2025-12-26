namespace HexTests;
using HexGrid;

[TestClass]
public sealed class HexClassTests 
{

  // Test constructor with standard values
  [TestMethod]
  public void TestClassConstructor1() {
    Hex hex = new Hex(1, 2);

    Assert.IsTrue(hex.q == 1, "q was not set correctly");
  }
}
