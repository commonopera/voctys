using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leavebydoor : MonoBehaviour {

	//moves castle cursor based on which exit you leave room via

	public int leadsto;

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "player"){
			PlayerPrefs.SetInt("room", leadsto);
		}
	}
}
