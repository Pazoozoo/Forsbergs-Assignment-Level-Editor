using UnityEngine;

[RequireComponent(typeof(TileSettings))]
public class TileInput : MonoBehaviour {
    void OnMouseDown() {
        var settings = GetComponent<TileSettings>();
        settings.MaterialIndex = FindObjectOfType<MaterialManager>().selectedIndex;
        settings.ChangeMaterial();
    }
}
