using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class furniture_killer : MonoBehaviour {

	//fades out gobehind components when room is exited

	public GameObject fade;

	void Update () {
		if(PlayerPrefs.GetInt("fadereset") == 1){
			Instantiate(fade, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
	}

/*	void OnDestroy(){
		Instantiate(fade, transform.position, Quaternion.identity);
	}*/
}
