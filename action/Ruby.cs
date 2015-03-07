using UnityEngine;
using System.Collections;
public class Ruby : MonoBehaviour
{
	int dashtime=0;
	bool rightleft=false;

	// Use this for initialization
	void Start ()
	{
	
	}
	// Update is called once per frame
	void Update ()
	{
		//move
		if (Input.GetKey (KeyCode.D)) 
		{
			transform.Translate (0.1f, 0, 0);
			dashtime++;
			rightleft=false; // right side
//			if(dashtime>60)
//			{ 
//				transform.Translate (0.08f, 0, 0); //this timecount change dashmode
//			}
		}
		if (Input.GetKey (KeyCode.A)) 
		{
			transform.Translate (-0.1f, 0, 0);
			dashtime++;
			rightleft=true; // left side
//			if (dashtime > 60) 
//			{	//this timecount change dashmode
//				transform.Translate (-0.08f, 0, 0);
//			}
		}
		//walk mode release key
//		if (Input.GetKeyUp (KeyCode.D) || Input.GetKeyUp (KeyCode.A)) 
//		{
//			dashtime=0;
//		}

		if (Input.GetMouseButtonDown (0))//Left Button
		{
			if(rightleft==false)
			{
				transform.Translate (0.5f, 0, 0); //test
			}
			else if(rightleft==true)
			{
				transform.Translate (-0.5f, 0, 0); //test
				
			}
		}
	}
}
