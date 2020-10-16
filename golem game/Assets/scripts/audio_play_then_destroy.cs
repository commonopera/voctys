using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_play_then_destroy : MonoBehaviour {

	//attach to an audiosource to make it destroy itself once its clip has been played

	AudioSource theaudio;

	void Start () {
		theaudio = GetComponent<AudioSource>();
	}

	void Update () {
		if(theaudio.time >= theaudio.clip.length - .1f){
			Destroy(gameObject);
		}
	}
}
