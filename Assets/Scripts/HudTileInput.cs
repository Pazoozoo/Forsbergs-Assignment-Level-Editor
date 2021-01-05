using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HudTileInput : MonoBehaviour, IPointerDownHandler {
    Material _tileMaterial;
    public Image border;

    public void SetUp(Material mat) {
        _tileMaterial = mat;
        GetComponent<Image>().color = mat.color;
    }
    public void OnPointerDown(PointerEventData eventData) {
        SelectThisTile();
    }

    void Start() {
        FindObjectOfType<EventManager>().tileSelected.AddListener(DisableHighlight);
    }

    void OnDestroy() {
        var eventManager = FindObjectOfType<EventManager>();
        if (eventManager != null)
            eventManager.tileSelected.RemoveListener(DisableHighlight);
    }

    void SelectThisTile() {
        FindObjectOfType<GameManager>().selectedMaterial = _tileMaterial;
        FindObjectOfType<EventManager>().tileSelected.Invoke();
        border.enabled = true;
    }

    void DisableHighlight() {
        border.enabled = false;
    }
}
