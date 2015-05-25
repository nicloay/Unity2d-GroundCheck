using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour {
	public LayerMask	GroundLayers;
	public Collider2D 	GroundCheckCollider;
	public bool IsGrounded{
		get{
			return _isGrounded;
		}
	}

	bool _isGrounded;

	void FixedUpdate () {
		_isGrounded = GroundCheckCollider.IsTouchingLayers(GroundLayers.value);
	}
#if UNITY_EDITOR
	void OnDrawGizmos(){
		UnityEditor.Handles.BeginGUI();
		GUI.Label(new Rect(10,10,150,20), "isGrounded: " + IsGrounded);
		UnityEditor.Handles.EndGUI();	
	}
#endif
}
