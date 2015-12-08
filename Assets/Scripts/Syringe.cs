using UnityEngine;
using System.Collections;

public class Syringe : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

public void respawnBullets () {
	if (Input.GetKeyDown("up"))
            print("up arrow key is held down");
        
    if (Input.GetKeyDown("space"))
            print("down arrow key is held down");
	}

public void moveSyringe () {
	Input.GetKeyDown("RightArrow");
	}
}