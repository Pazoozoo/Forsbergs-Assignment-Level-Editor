using UnityEngine;

public class MouseInput : MonoBehaviour {
    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            var hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null) {
                Debug.Log("Something was clicked on " + hit.collider.gameObject.name);
            }
        }
    }
}
