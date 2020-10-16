using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go_behind_things : MonoBehaviour {

	//MOVES DESIGNATED OBJECTS TO FOREGROUND WHEN "PLAYER" OBJECT IS "BEHIND" THEM
	//SET OBJECT CONTAINING SPRITE AS CHILD OF GOBEHIND OBJECT & ATTACH TO SCRIPT AS "SPRITE_LAYER"

	//(i wrote the initial version of this script in the marcy branch of the brooklyn
	//public library for the first game i made in unity, 'epilogue simulator'
	//and i was very very proud of it and i still use it in basically everything!)

	Renderer rendering;
	bool inZone = false;
	public GameObject sprite_layer;

	void Start () {
		rendering = sprite_layer.GetComponent<Renderer> ();
	}

	void Update () {
		if(inZone == true){
			rendering.sortingOrder = 1;
		}
		if(inZone == false){
			rendering.sortingOrder = -1;
		}

	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "player"){
			inZone = true;
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if(col.gameObject.tag == "player"){
			inZone = false;
		}
	}
}
