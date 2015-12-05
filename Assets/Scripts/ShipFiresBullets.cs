using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShipFiresBullets : MonoBehaviour {
	public Button Lips;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

public void shoot () {
	//CharacterController.detectCollisions
	//Rigidbody2D.velocity
	//CharacterController.OnControllerColliderHit(ControllerColliderHit hit)
	}
//public void CharacterController.SimpleMove() {
public void OnCollisionEnter2D(Collision2D coll) {

	if (coll.gameObject.tag == "Lip")
    	print ("ApplyDamage");
	}

}
