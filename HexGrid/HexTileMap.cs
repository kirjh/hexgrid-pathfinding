namespace HexGrid;

public class HexTileMap
{
  private Dictionary<Hex, HexTile> _dict;

  public HexTileMap()
  {
    _dict = new Dictionary<Hex, HexTile>();
  }

  // Attempts to add a tile to the map
  // Returns true is successful, false otherwise
  public bool Add(HexTile tile)
  {
    return _dict.TryAdd(new Hex(tile.Q, tile.R), tile);
  }
  // Attempts to remove a tile from the map
  // Returns true is successful, false otherwise
  public bool Remove(Hex hex)
  {
    return _dict.Remove(hex);
  }
  public bool Remove(int q, int r)
  {
    return _dict.Remove(new Hex(q, r));
  }

  public HexTile Get(Hex hex)
  {
    return _dict[hex];
  }
  public HexTile Get(int q, int r)
  {
    return _dict[new Hex(q, r)];
  }
  public Dictionary<Hex, HexTile>.KeyCollection Keys()
  {
    return _dict.Keys;
  }
}