using UnityEngine;

public class HudTileSetup : MonoBehaviour {
    public Material tileMaterial;

    void Awake() {
        if (tileMaterial == null)
            Debug.LogError(name + ": Tile Material is not assigned!");
        
        GetComponentInChildren<HudTileInput>().SetUp(tileMaterial);
    }
}
