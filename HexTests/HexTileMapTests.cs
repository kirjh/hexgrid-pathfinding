namespace HexTests;
using HexGrid;

[TestClass]
public sealed class HexTileMapTests
{
  [TestMethod]
  public void TestAdd1()
  {
    HexTileMap map = new HexTileMap();
    for (int i = 0; i < 10; i++)
    {
      map.Add(new HexTile(i, i+1, i+2, i+3));
    }
    HexTile tile = map.Get(5, 6);

    Assert.IsTrue(tile.Level == 8, $"Expected: 8, Actual: {tile.Level}");
  }
  [TestMethod]
  public void TestAdd2()
  {
    HexTileMap map = new HexTileMap();
    bool x = map.Add(new HexTile(0, 0, 0, 0));
    bool y = map.Add(new HexTile(0, 0, 0, 0));

    bool z = x && !y;

    Assert.IsTrue(z, $"Expected: true, Actual: {z}");
  }
  [TestMethod]
  public void TestRemove1()
  {
    HexTileMap map = new HexTileMap();
    map.Add(new HexTile(0, 0, 0, 0));
    map.Add(new HexTile(1, 1, 1, 1));

    bool x = map.Remove(0,0);

    Assert.IsTrue(x, $"Expected: true, Actual: {x}");
  }
  [TestMethod]
  public void TestRemove2()
  {
    HexTileMap map = new HexTileMap();
    map.Add(new HexTile(0, 0, 0, 0));
    map.Add(new HexTile(1, 1, 1, 1));

    bool x = map.Remove(0,1);

    Assert.IsFalse(x, $"Expected: false, Actual: {x}");
  }
  [TestMethod]
  public void TestKeys()
  {
    HexTileMap map = new HexTileMap();
    for (int i = 0; i < 10; i++)
    {
      map.Add(new HexTile(i, i+1, i+2, i+3));
    }
    int x = 0;
    Dictionary<Hex, HexTile>.KeyCollection keys = map.Keys();
    foreach (Hex key in keys)
    {
      x += key.Q + key.R;
    }

    Assert.IsTrue(x == 100, $"Expected: 100, Failed at: {x}");
  }
}