using UnityEngine;
public class DynamicMove : MonoBehaviour {
    public float speed = 5;
    Rigidbody rb;
    private void Start() {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate() {
        var dx = Input.GetAxisRaw("Horizontal");
        var dz = Input.GetAxisRaw("Vertical");
        var dir = new Vector3(dx, 0, dz).normalized;
        rb.velocity = dir * speed + rb.velocity.y * Vector3.up;
        Debug.LogFormat("mag = {0}", rb.velocity.magnitude);
    }
}
