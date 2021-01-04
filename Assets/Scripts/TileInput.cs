using UnityEngine;

public class TileInput : MonoBehaviour {
    void OnMouseDown() {
        var material = FindObjectOfType<GameManager>().selectedMaterial;
        if (material != null)
            GetComponent<Renderer>().sharedMaterial = material;
    }
}
