using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenclear : MonoBehaviour {

	//clears multiple objects at once
	//only set one object to 'setter' per use
	//spawns next object and its own fadeout
	//if killdialogue, resets "frozen" to 0

	public bool setter, killdialogue, spawnnext;
	public GameObject spawninplace, fade;
	public float spawnx, spawny;

	void Update () {
		if(PlayerPrefs.GetInt("screenclear") == 1){
			if(setter){
				StartCoroutine(TurnItOff());
			}
			else{
				Destroy(gameObject);
			}
		}
	}

	IEnumerator TurnItOff(){
		yield return new WaitForSeconds(.2f);
		PlayerPrefs.SetInt("screenclear", 0);
		if(spawnnext){
			Instantiate(spawninplace, new Vector2(spawnx, spawny), Quaternion.identity);
		}
		Instantiate(fade, transform.position, Quaternion.identity);
		if(killdialogue){
			PlayerPrefs.SetInt("frozen", 0);
		}
		Destroy(gameObject);
	}
}
