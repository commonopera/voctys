using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fighter_shower : MonoBehaviour {

	//shows arrow over selected character in battle mode

	bool start = true;
	public int whichone;
	SpriteRenderer renderer;

	void Update () {
		if(start){
			start = false;
			renderer = GetComponent<SpriteRenderer>();
		}
		if(PlayerPrefs.GetInt("whosselected") == whichone){
			renderer.enabled = true;
		}
		else{
			renderer.enabled = false;
		}
	}
}
