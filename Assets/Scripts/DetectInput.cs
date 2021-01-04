using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DetectInput : MonoBehaviour, IPointerDownHandler {
    public Image border;
    EventHandler eventHandler;

    void Awake() {
        eventHandler = FindObjectOfType<EventHandler>();
    }

    void Start() {
        eventHandler.TileSelected.AddListener(DeSelect);
    }

    void OnDestroy() {
        eventHandler.TileSelected.RemoveListener(DeSelect);
    }

    public void OnPointerDown(PointerEventData eventData) {
        eventHandler.TileSelected.Invoke();
        border.enabled = true;
    }

    void DeSelect() {
        border.enabled = false;
    }
}
