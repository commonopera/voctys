using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_on_create : MonoBehaviour {

	//object creates another accompanying object upon being created
	//(useful for spawning sfx/animations that should accompany an object's arrival
	//then get out of the way once theyve done their thing)

	//(i could also probably just attach whatever im trying to make to the object
	//as a child, but this way is a little bit more convenient without like
	//being able to change nested prefabs >____>)

	public GameObject accompaniment;
	public bool differentspot;
	public float posx, posy, posz;

	void Start () {
		if(differentspot){
			Instantiate(accompaniment, new Vector3(posx, posy, posz), Quaternion.identity);
		}
		else{
			Instantiate(accompaniment, transform.position, Quaternion.identity);
		}
	}
}
