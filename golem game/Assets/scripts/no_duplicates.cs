using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class no_duplicates : MonoBehaviour {

	//destroys gameobject if one with same tag already exists
	//(check "justsound" to turn audiosource off instead of destroying)

	public bool justsound;

	void Awake () {
		if(GameObject.FindGameObjectsWithTag(gameObject.tag).Length > 1){
			if(justsound){
				AudioSource theaudio = GetComponent<AudioSource> ();
				theaudio.enabled = false;
			}
			else{
				Destroy(gameObject);
			}
		}
	}
}
