using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinLosePage : MonoBehaviour {
	public int LipsHit;
	// Use this for initialization
	void Start () {
		LipsHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(LipsHit == 21)
		Application.LoadLevel(4);
	}

public void OnCollisionEnter2D(Collision2D coll) {
	if(coll.gameObject.tag == "Lip") {
    	coll.gameObject.SetActive(false);
		this.gameObject.SetActive(false);
		Destroy(this.gameObject);
		Destroy(coll.gameObject);
		Application.LoadLevel(2);
		}
	}

public void EveryLipHit() {
	LipsHit += 1;
	print("I hit a lip");
}
}