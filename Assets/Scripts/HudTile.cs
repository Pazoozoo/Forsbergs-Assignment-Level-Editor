using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HudTile : MonoBehaviour, IPointerDownHandler {
    public Image border;
    Material _tileMaterial;
    int _materialIndex;

    public void SetUp(int index) {
        var gm = FindObjectOfType<MaterialManager>();
        _materialIndex = Mathf.Clamp(index, 0, gm.materials.Length);
        _tileMaterial = gm.materials[_materialIndex];
        GetComponent<Image>().color = _tileMaterial.color;
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
        FindObjectOfType<MaterialManager>().SelectMaterial(_materialIndex);
        FindObjectOfType<EventManager>().tileSelected.Invoke();
        border.enabled = true;
    }

    void DisableHighlight() {
        border.enabled = false;
    }
}
