using UnityEngine;
using System.Collections;

public class Syringe : MonoBehaviour {
	public GameObject SyringeBullet;
	public GameObject Dr;
	public GameObject Hand;
	public Canvas canvas;
	public Vector3 DrMovement;
	public float DrSpeed = 1f;
	// Use this for initialization
	void Start () {
	
	DrMovement = new Vector3();

	}
	
	// Update is called once per frame
	void Update () {
	respawnSyringes();

	DrMovement.x = Input.GetAxis("Horizontal");
	DrMovement.y = Input.GetAxis("Vertical");

	Dr.transform.position += DrMovement * DrSpeed ;//* Time.deltaTime;
	}

public void respawnSyringes () {
    if (Input.GetKeyDown("space"))
    	{
    	GameObject mySyringe;
    	mySyringe = Instantiate(SyringeBullet, Hand.transform.position, Quaternion.identity) as GameObject;
    	mySyringe.transform.SetParent(canvas.transform);
        }
	}
}