using UnityEngine;

public class TileSettings : MonoBehaviour {
    public int MaterialIndex { get; private set; }
    
    public void LoadMaterial(int index) {
        MaterialIndex = index;
        ChangeMaterial();
    }
    
    void OnMouseDown() {
        MaterialIndex = FindObjectOfType<MaterialManager>().selectedIndex;
        ChangeMaterial();
    }

    void ChangeMaterial() {
        var material = FindObjectOfType<MaterialManager>().materials[MaterialIndex];
        GetComponent<Renderer>().sharedMaterial = material;
    }
}
