using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GridManager : MonoBehaviour {
    public Transform tilePrefab;
    public Transform gridAnchor;
    List<Transform> _tiles;
    string _savePath;

    void Awake() {
        _tiles = new List<Transform>();
        _savePath = Path.Combine(Application.persistentDataPath, "saveFile");
        DrawNewGrid();
    }

    public void Save() {
        using (
            var writer = new BinaryWriter(File.Open(_savePath, FileMode.Create))
        ) {
            writer.Write(_tiles.Count);
            foreach (var tile in _tiles) {
                var position = tile.localPosition;
                writer.Write(position.x);
                writer.Write(position.y);
                writer.Write(position.z);
                var index = tile.GetComponent<TileSettings>().MaterialIndex;
                writer.Write(index);
            }
        }
    }

    public void Load() {
        ClearGrid();
        using (
            var reader = new BinaryReader(File.Open(_savePath, FileMode.Open))
        ) {
            var count = reader.ReadInt32();
            for (var i = 0; i < count; i++) {
                Vector3 position;
                position.x = reader.ReadSingle();
                position.y = reader.ReadSingle();
                position.z = reader.ReadSingle();
                var index = reader.ReadInt32();
                var tile = Instantiate(tilePrefab, position, Quaternion.identity);
                tile.GetComponent<TileSettings>().LoadMaterial(index);
                _tiles.Add(tile);
            }
        }
    }

    public void Reset() {
        ClearGrid();
        DrawNewGrid();
    }

    void ClearGrid() {
        foreach (var tile in _tiles) {
            Destroy(tile.gameObject);
        }
        _tiles.Clear();
    }
    
    void DrawNewGrid() {
        for (var y = 0; y > -10; y--) {
            for (var x = 0; x < 10; x++) {
                var position = gridAnchor.position + new Vector3(x, y, 0);
                var tile = Instantiate(tilePrefab, position, Quaternion.identity);
                _tiles.Add(tile);
            }
        }
    }
}
