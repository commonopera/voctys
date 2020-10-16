using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haloadjust : MonoBehaviour {

	//dumb little script to make halos go in front of the background in the endgame
	//plan things out better!!! im going back to tie up loose ends and just adding
	//so many even looser ones structurally to make things work that werent planned!!!

	SpriteRenderer therender;
	public GameObject fade;

	void Start () {
		therender = GetComponent<SpriteRenderer>();
		if(PlayerPrefs.GetInt("endscene") == 1){
			therender.sortingOrder = 10;
		}
	}

	void OnDestroy(){
		if(PlayerPrefs.GetInt("endscene") == 0){
			Instantiate(fade, transform.position, Quaternion.identity);
		}
	}
}
