using System;

public class TileMap<T> where T : new() {
  public int Width { get; }
  public int Height { get; }
  private T[,] tiles;

  public TileMap(int size) : this(size, size) {
  }

  public TileMap(int width, int height) {
    Width = width;
    Height = height;
    tiles = new T[Height, Width];
    Map(tile => new T());
  }

  public T Get(int x, int y) {
    return tiles[y, x];
  }

  public void Set(int x, int y, T tile) {
    tiles[y, x] = tile;
  }

  public TileMap<T> ForEach(Action<T> callback) {
    for (var i = 0; i < Height; i++) {
      for (var j = 0; j < Width; j++) {
        callback(tiles[i, j]);
      }
    }

    return this;
  }

  public TileMap<T> Map(Func<T, T> callback) {
    for (var i = 0; i < Height; i++) {
      for (var j = 0; j < Width; j++) {
        tiles[i, j] = callback(tiles[i, j]);
      }
    }

    return this;
  }
}
