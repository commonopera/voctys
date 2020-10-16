using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_unfocused_pause : MonoBehaviour {

	//(this was to test something but im ending up not using it
	//if youre reading this, uhh... proceed with caution! unproven! unused!)

	AudioSource theaudio;

	// Use this for initialization
	void Start () {
		theaudio = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnApplicationFocus()
    {
        theaudio.UnPause();
    }

    void OnApplicationPause()
    {
        theaudio.Pause();
    }
}
