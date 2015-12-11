using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timefallulageller : MonoBehaviour {
	public float Timer;
	public Text TimerText;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Timer -= Time.deltaTime;
		TimerText.text = Timer.ToString ();
		TimesUp();
	}

public void TimesUp () {
	if(Timer <= 0)
		Application.LoadLevel(3);
	}
}
