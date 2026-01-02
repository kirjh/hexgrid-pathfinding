namespace HexTests;
using HexGrid;

[TestClass]
public sealed class HexTileTests
{
  [TestMethod]
  public void TestEqual1()
  {
    HexTile tile1 = new HexTile(0, 0, 1, 2);
    HexTile tile2 = new HexTile(new Hex(0,0), 1, 2);

    bool x = tile1.Equals(tile2);

    Assert.IsTrue(x, $"Expected {tile1} = {tile2}");
  }
  [TestMethod]
  public void TestEqual2()
  {
    HexTile tile1 = new HexTile(0, 0, 2, 2);
    HexTile tile2 = new HexTile(new Hex(0,0), 1, 2);

    bool x = tile1.Equals(tile2);

    Assert.IsFalse(x, $"Expected {tile1} != {tile2}");
  }
  [TestMethod]
  public void TestHashcode()
  {
    HexTile tile1 = new HexTile(1, 2, 3, 4);
    HexTile tile2 = new HexTile(new Hex(1,2), 3, 4);

    bool x = tile1.GetHashCode() == tile2.GetHashCode();

    Assert.IsTrue(x, $"Expected {tile1} and {tile2} to have same hashcode");
  }
}