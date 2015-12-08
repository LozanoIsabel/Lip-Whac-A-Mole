using UnityEngine;
using System.Collections;

public class Syringe : MonoBehaviour {
	public GameObject Bullet;
	public Canvas canvas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	respawnBullets();
	}

public void respawnBullets () {

	if (Input.GetKeyDown("up"))
            print("up arrow key is held down");
        
    if (Input.GetKeyDown("space"))
    	{
    	GameObject myBullet;

    		myBullet = Instantiate(Bullet, this.gameObject.transform.position, Quaternion.identity) as GameObject;
    		myBullet.transform.SetParent(canvas.transform);
        }
	}

public void moveSyringe () {
	Input.GetKeyDown("RightArrow");
	}
}