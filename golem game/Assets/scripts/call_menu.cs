using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class call_menu : MonoBehaviour {

	//calls a menu
	//this probably couldve been same script as 'take_object'
	//"praywait" also used for lookwait, workwait, honewait
	//but i didnt wanna be confusing @___@

	bool inZone = false;
	public bool namegive, namemix, restwait, praywait;
	public float menux, menuy, textx, texty;
	public GameObject menu, denytext;

	void Update () {
		if(inZone && Input.GetKeyDown("space")){
			if(PlayerPrefs.GetInt("frozen") != 1){
				if (namegive){
					if (PlayerPrefs.GetInt("chosenname") == 0){
						Instantiate(menu, new Vector2(menux, menuy), Quaternion.identity);
					}
					else{
						Instantiate(denytext, new Vector2(textx, texty), Quaternion.identity);
					}
				}
				if (namemix || restwait || praywait){
					Instantiate(menu, new Vector2(menux, menuy), Quaternion.identity);
				}
			}
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
