using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HudTileInput : MonoBehaviour, IPointerDownHandler {
    public Material tileMaterial;
    public Image border;

    public void OnPointerDown(PointerEventData eventData) {
        SelectThisTile();
    }

    void Start() {
        FindObjectOfType<EventManager>().tileSelected.AddListener(DisableHighlight);
    }

    void OnDestroy() {
        FindObjectOfType<EventManager>().tileSelected.RemoveListener(DisableHighlight);
    }

    void SelectThisTile() {
        FindObjectOfType<GameManager>().selectedMaterial = tileMaterial;
        FindObjectOfType<EventManager>().tileSelected.Invoke();
        border.enabled = true;
    }

    void DisableHighlight() {
        border.enabled = false;
    }
}
