using UnityEngine;
/// <summary>
/// This script allows the user to choose material directly
/// from the parent object of the HUD_Tile prefab
/// </summary>
public class HudTileMaterial : MonoBehaviour {
    public int materialIndex;

    void Awake() {
        GetComponentInChildren<HudTile>().SetUp(materialIndex);
    }
}
