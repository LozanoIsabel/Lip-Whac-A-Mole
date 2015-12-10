using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SyringesFired : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate();
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
		Destroy(this.gameObject);
		Destroy(coll.gameObject);
	}
	}

}
