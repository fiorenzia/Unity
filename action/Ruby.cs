using UnityEngine;
using System.Collections;
public class Ruby : MonoBehaviour
{
	bool rightleft=false;

	//Use this for initialization
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

		}
		if (Input.GetKey (KeyCode.A)) 
		{
			transform.Translate (-0.1f, 0, 0);
			dashtime++;
			rightleft=true; // left side
		}

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
