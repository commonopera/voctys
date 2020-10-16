using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud_spawn : MonoBehaviour {

	//spawns clouds at random rate within set parameters 

	public GameObject cloud;
	bool ready = true;
	int frequency;
	public int minrange, maxrange;

	void Update () {
		if(ready){
			ready = false;
			Instantiate(cloud, transform.position, Quaternion.identity);
			StartCoroutine(Doitagain());
		}
	}

	IEnumerator Doitagain(){
		frequency = Random.Range(minrange, maxrange);
		yield return new WaitForSeconds(frequency);
		ready = true;
	}
}
