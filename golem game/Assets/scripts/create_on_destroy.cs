using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_on_destroy : MonoBehaviour {

	//object replaces self with a new object upon its own destruction

	public GameObject replacement;
	//object to replace with

	public float posx, posy, posz;
	public bool samespot;
	//coordinates for new object to be spawned at

	void OnDestroy(){
		if(samespot){
			Instantiate(replacement, transform.position, Quaternion.identity);
		}
		else{
			Instantiate(replacement, new Vector3(posx, posy, posz), Quaternion.identity);
		}
	}
}
