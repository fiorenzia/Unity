using UnityEngine;
using System.Collections;

public class Ruby : MonoBehaviour 
{
	int dashtime=0;
	// Use this for initialization
	void Start (){
	
	}
	
	// Update is called once per frame
	void Update (){
		Debug.Log(+dashtime);
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (0.005f, 0, 0);
			dashtime++;
			if(dashtime>60){
			transform.Translate (0.05f, 0, 0);
			}
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (-0.005f, 0, 0);
			dashtime++;
			if (dashtime > 60) {
			transform.Translate (-0.05f, 0, 0);
			}
		}
		if (Input.GetKeyUp (KeyCode.D) || Input.GetKeyUp (KeyCode.A)) {
			dashtime=0;
		}
	}
}
