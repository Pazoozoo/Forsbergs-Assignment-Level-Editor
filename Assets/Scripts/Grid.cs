using UnityEngine;

public class Grid : MonoBehaviour {
    public GameObject tilePrefab;

    void Awake() {
        for (var y = 0; y > -10; y--) {
            for (var x = 0; x < 10; x++) {
                var position = transform.position + new Vector3(x, y, 0);
                Instantiate(tilePrefab, position, Quaternion.identity);
            }
        }
    }
}
