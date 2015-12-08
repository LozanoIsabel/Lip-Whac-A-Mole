using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BulletsFired : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

public void shoot () {
	//if()
	//CharacterController.detectCollisions
	//CharacterController.OnControllerColliderHit(ControllerColliderHit hit)
	}
//public void CharacterController.SimpleMove() {
public void OnCollisionEnter2D(Collision2D coll) {
	
	if(coll.gameObject.tag == "Lip") {
    	coll.gameObject.SetActive(false);
		this.gameObject.SetActive(false);
	}
	}

}
