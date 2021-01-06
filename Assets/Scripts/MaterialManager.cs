using UnityEngine;

public class MaterialManager : MonoBehaviour {
    public int selectedIndex;
    public Material[] materials;

    public void SelectMaterial(int materialIndex) {
        var index = Mathf.Clamp(materialIndex, 0, materials.Length);
        selectedIndex = index;
    }
}
