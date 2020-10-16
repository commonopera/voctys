using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silence_children : MonoBehaviour {

	//deactivates audiosources on all children an object generates
	//if "turn_off" checked, stops doing it when ("time_needed") seconds have elapsed

	AudioSource itsaudio;
	public bool turn_off;
	public float time_needed = 0;
	bool stillrunning = true;


	void Start () {
		if(turn_off){
			StartCoroutine(Deactivator());
		}
	}

	void Update () {
		if(stillrunning){
			foreach (Transform child in transform){
				itsaudio = child.GetComponent<AudioSource>();
				itsaudio.enabled = false;
			}
		}
	}

	IEnumerator Deactivator(){
		yield return new WaitForSeconds(time_needed);
		stillrunning = false;
	}
}
