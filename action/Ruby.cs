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
		//move
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (0.01f, 0, 0);
			dashtime++;
			if(dashtime>60){ //this timecount change dashmode
			transform.Translate (0.08f, 0, 0);
			}
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (-0.005f, 0, 0);
			dashtime++;
			if (dashtime > 60) { //this timecount change dashmode
			transform.Translate (-0.05f, 0, 0);
			}
		}

		//walk mode release key
		if (Input.GetKeyUp (KeyCode.D) || Input.GetKeyUp (KeyCode.A)) {
			dashtime=0;
		}

		if (Input.GetMouseButtonDown (0))//Left Button 
		{
			transform.Translate (0.5f, 0, 0); //test
		}
		if (Input.GetMouseButtonDown (1))//Right Button 
		{
			transform.Translate (1.5f, 0, 0); //test
		}
	}
}
