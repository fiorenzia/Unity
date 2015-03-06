using UnityEngine;
using System.Collections;

public class Ganerate : MonoBehaviour {
	public GameObject myPrefub;
	int generatetime=120;
	int timecount=0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timecount++;
		Vector3 offs=new Vector3(Mathf.Sin(Time.time*0.5f),0,0);
		if(generatetime==timecount){
		Instantiate (myPrefub,transform.position+offs,Quaternion.identity);
		timecount=0;
		}
	}
}