using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room_killer : MonoBehaviour {

	//upon entering door or staircase, exits room and fades in overmap

	public GameObject fade, bkgfade;

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "player"){
			PlayerPrefs.SetInt("inroom", 0);
			PlayerPrefs.SetInt("fadereset", 1);
			StartCoroutine(WaitForFurniture());
		}
	}

	IEnumerator WaitForFurniture(){
		yield return new WaitForSeconds(.1f);
		Instantiate(fade, transform.position, Quaternion.identity);
		Instantiate(bkgfade, new Vector2(0, 0), Quaternion.identity);
		Destroy(gameObject);
	}
}
