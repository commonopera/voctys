using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_priority_fade : MonoBehaviour {

	//attach to an audiosource to make its priority get less and less the longer it exists
	//used for dialogue with per-letter sound effects to make sure the newest-spawned
	//letters are always higher priority than the older ones
	//so as not to get clogged up and have their audio stop playing after the max
	//count of 32 active audiosources has been reached

	AudioSource theaudio;

	void Start () {
		theaudio = GetComponent<AudioSource>();
	}

	void Update () {
		if(theaudio.priority < 255){
			theaudio.priority += 1;
		}
	}
}
