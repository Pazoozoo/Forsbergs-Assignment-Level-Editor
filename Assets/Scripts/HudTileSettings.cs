using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This script allows the user to change settings directly
/// from the parent object of the HUD_Tile prefab
/// </summary>

public class HudTileSettings : MonoBehaviour {
    public int materialIndex;
    public string tileName;

    void Awake() {
        GetComponentInChildren<HudTile>().SetUp(materialIndex);
        GetComponent<Text>().text = tileName;
    }
}
