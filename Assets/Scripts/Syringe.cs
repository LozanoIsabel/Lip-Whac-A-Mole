using UnityEngine;
using System.Collections;

public class Syringe : MonoBehaviour {
	public GameObject Bullet;
	public GameObject SyringeGun;
	public Canvas canvas;
	public Vector3 SyringeMovement;
	public float SyringeGunSpeed = 10f;
	// Use this for initialization
	void Start () {
	
	SyringeMovement = new Vector3();

	}
	
	// Update is called once per frame
	void Update () {
	respawnBullets();

	SyringeMovement.x = Input.GetAxis("Horizontal");
	SyringeMovement.y = Input.GetAxis("Vertical");

	SyringeGun.transform.position += SyringeMovement * SyringeGunSpeed * Time.deltaTime;
	}

public void respawnBullets () {
    if (Input.GetKeyDown("space"))
    	{
    	GameObject myBullet;

    	myBullet = Instantiate(Bullet, this.gameObject.transform.position, Quaternion.identity) as GameObject;
    	myBullet.transform.SetParent(canvas.transform);
        }
	}
}