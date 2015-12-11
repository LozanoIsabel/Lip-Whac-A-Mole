using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinLosePage : MonoBehaviour {
	public Canvas canvasWin;
	public Canvas canvasLose;
	public int Score;
	public GameObject Dr;
	public GameObject Lips;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	winState ();
	
	}

public void winState () {

}

public void OnCollisionEnter2D(Collision2D coll) {
	if(coll.gameObject.tag == "Lip") {
    	coll.gameObject.SetActive(false);
		this.gameObject.SetActive(false);
		Destroy(this.gameObject);
		Destroy(coll.gameObject);
		print ("YOU LOSE");
		}
	}
}