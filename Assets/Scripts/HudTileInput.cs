using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(HudTileSettings))]
public class HudTileInput : MonoBehaviour, IPointerDownHandler {
    
    public void OnPointerDown(PointerEventData eventData) {
        SelectThisTile();
    }
    
    void SelectThisTile() {
        var hudTile = GetComponent<HudTileSettings>();
        FindObjectOfType<MaterialManager>().SelectMaterial(hudTile.MaterialIndex);
        FindObjectOfType<EventManager>().tileSelected.Invoke();
        hudTile.EnableHighlight();
    }
}
