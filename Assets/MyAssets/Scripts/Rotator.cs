using UnityEngine;

// Responsible for rotating the planets and coin
public class Rotator : MonoBehaviour {

    [SerializeField]
    private float speed = 40;

    [SerializeField]
    private float xAngle = 0;

    [SerializeField]
    private float yAngle = 0;

    [SerializeField]
    private float zAngle = 0;

    void Update() {
        transform.Rotate(xAngle * speed * Time.deltaTime, yAngle * speed * Time.deltaTime, zAngle * speed * Time.deltaTime);
    }
}
