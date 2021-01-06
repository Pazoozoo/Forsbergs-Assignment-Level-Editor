using UnityEngine;

public class TileSettings : MonoBehaviour {
    public int MaterialIndex { get; private set; }
    
    public void LoadMaterial(int index) {
        var material = FindObjectOfType<MaterialManager>().materials[index];
        ChangeMaterial(material);
    }
    
    void OnMouseDown() {
        var mm = FindObjectOfType<MaterialManager>();
        MaterialIndex = mm.selectedIndex;
        ChangeMaterial(mm.materials[MaterialIndex]);
    }

    void ChangeMaterial(Material material) {
        GetComponent<Renderer>().sharedMaterial = material;
    }
}
