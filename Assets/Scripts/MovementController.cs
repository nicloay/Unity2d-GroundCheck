using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementController : MonoBehaviour {
	public float HorizontalForce = 1000.0f;
	public float JumpForce = 500.0f;
	Rigidbody2D rBoby;

	void Start(){
		rBoby = GetComponent<Rigidbody2D>();
	}

	void Update () {
		float x = Input.GetAxis("Horizontal");
		float y = 0.0f;
		if (Input.GetButtonDown("Jump")){
			y = JumpForce;
		}
		rBoby.AddForce(new Vector2(x*HorizontalForce*Time.deltaTime, y));
	}
}
