using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HudTileSettings : MonoBehaviour {
    public Image border;
    Material _tileMaterial;
    public int MaterialIndex { get; private set; }

    public void SetUp(int index) {
        var mm = FindObjectOfType<MaterialManager>();
        MaterialIndex = Mathf.Clamp(index, 0, mm.materials.Length);
        _tileMaterial = mm.materials[MaterialIndex];
        GetComponent<Image>().color = _tileMaterial.color;
    }

    public void EnableHighlight() {
        border.enabled = true;
    }

    void Start() {
        FindObjectOfType<EventManager>().tileSelected.AddListener(DisableHighlight);
    }

    void OnDestroy() {
        var eventManager = FindObjectOfType<EventManager>();
        if (eventManager != null)
            eventManager.tileSelected.RemoveListener(DisableHighlight);
    }

    void DisableHighlight() {
        border.enabled = false;
    }
}
