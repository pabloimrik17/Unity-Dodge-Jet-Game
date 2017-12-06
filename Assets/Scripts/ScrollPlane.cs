using System.Collections;
using UnityEngine;

public class ScrollPlane : MonoBehaviour {

	 public MeshRenderer rend;
 
    private float scrollSpeed = 0.5F;
 
    void Start() {
        rend = GetComponent<MeshRenderer>();
    }
	
    void Update() {
        float offset = -Time.time * scrollSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }

}
