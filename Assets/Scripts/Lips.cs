using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lips : MonoBehaviour {
	public Button b;

 //private Vector3 zeroSize = new Vector3(0,0,0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

void dissappearLips () {

gameObject.GetComponent<Button>().interactable = false;

}

public void turnRed () {
	GetComponent<Image>().color = Color.red;
	//GetComponent<Button>().color = Color.white;
	//GetComponent<Button>().color = Color.white;
	Button b = GetComponent<Button>(); 
 	ColorBlock cb = b.colors;
 	cb.normalColor = Color.white;
 	cb.highlightedColor = Color.white;
 	b.colors = cb;
}

public void sizeUp () {
	//this.gameObject.Size
	
 		transform.localScale += new Vector3(.5F, 1, 2);
 	

}

public void sizeDown () {
	//if(transform.localScale > zeroSize)
	transform.localScale = new Vector3(transform.localScale.x*.2F, transform.localScale.y*.2F, 0);
}
public class BigLips : Lips {

	void wiggle () {

	}
}
}