using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clear_for_fight : MonoBehaviour {

	//clears open rooms and loads battleground when timer runs out

	public bool spawner;
	public GameObject bell;

	void Update () {
		if(PlayerPrefs.GetInt("fighttime") == 1){
			if(spawner){
				Instantiate(bell, new Vector2(0, 0), Quaternion.identity);
			}
			Destroy(gameObject);
		}
	}
}
