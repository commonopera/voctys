using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alter_playerpref : MonoBehaviour {

	//when an object bearing this script is created, the associated playerpref changes
	//(mostly intended to be placed on dialogue objects to advance plot state)
	//"after" sets the transition to happen on destroy rather than on start

	public string playerpref_title;
	public int set_to;
	public bool after;

	void Start () {
		if(!after){
			PlayerPrefs.SetInt(playerpref_title, set_to);
		}
	}

	void OnDestroy(){
		if(after){
			PlayerPrefs.SetInt(playerpref_title, set_to);
		}
	}
}
