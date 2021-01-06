using UnityEngine;

[RequireComponent(typeof(TileSettings))]
public class TileInput : MonoBehaviour {
    void OnMouseDown() {
        SendMessage("ChangeIndex", SendMessageOptions.DontRequireReceiver);
        SendMessage("ChangeMaterial", SendMessageOptions.DontRequireReceiver);
    }
}
