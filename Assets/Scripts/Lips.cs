using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lips : MonoBehaviour {
	public GameObject Dr;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

public void OnCollisionEnter2D(Collision2D coll) {
	
	if(coll.gameObject.tag == "Lip") {
    	coll.gameObject.SetActive(false);
		this.gameObject.SetActive(false);
		Destroy(this.gameObject);
		Destroy(coll.gameObject);
	}
}

}