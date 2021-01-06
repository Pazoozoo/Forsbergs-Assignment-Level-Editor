using UnityEngine;

public class TileSettings : MonoBehaviour {
    public int MaterialIndex { get; set; }
    
    public void LoadMaterial(int index) {
        MaterialIndex = index;
        ChangeMaterial();
    }
    
    void ChangeMaterial() {
        var material = FindObjectOfType<MaterialManager>().materials[MaterialIndex];
        GetComponent<Renderer>().sharedMaterial = material;
    }

    void ChangeIndex() {
        MaterialIndex = FindObjectOfType<MaterialManager>().selectedIndex;
    }
}
