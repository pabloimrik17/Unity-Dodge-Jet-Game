using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Boundary boundary;
    public Rigidbody stiffBody;
    public float tilt;
    public float speed;
 
    void Update() {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
 
        Vector3 movement = new Vector3(horizontal, vertical, 0f);
        stiffBody.velocity = movement * speed;
 
        stiffBody.position = new Vector3(
            Mathf.Clamp(stiffBody.position.x, boundary.xMin, boundary.xMax),
            Mathf.Clamp(stiffBody.position.y, boundary.yMin, boundary.yMax)
        );
 
        stiffBody.rotation = Quaternion.Euler(0.0f, 0.0f, stiffBody.velocity.x * -tilt);
    }
}
