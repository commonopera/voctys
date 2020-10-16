using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seq_special_cases : MonoBehaviour {

	//triggers something when created under specific circumstances

	public bool komlin_pray1, komlin_pray2, poemgot, poemread, shabsai_good;

	void Update () {
		if(komlin_pray1){
			if(PlayerPrefs.GetInt("seq_komlin") == 6){
				PlayerPrefs.SetInt("seq_komlin", 7);
			}
		}
		if(komlin_pray2){
			if(PlayerPrefs.GetInt("seq_komlin") == 79){
				PlayerPrefs.SetInt("seq_komlin", 80);
			}
		}
		if(poemgot){
			if(PlayerPrefs.GetInt("seq_uri") == 9	|| PlayerPrefs.GetInt("seq_uri") == 10){
				PlayerPrefs.SetInt("seq_sulam", 51);
			}
		}
		if(poemread){
			if(PlayerPrefs.GetInt("seq_uri") == 9 || PlayerPrefs.GetInt("seq_uri") == 10){
				PlayerPrefs.SetInt("seq_uri", 11);
			}
		}
		if(shabsai_good){
			if(PlayerPrefs.GetInt("win_chelbo") == 1 && PlayerPrefs.GetInt("win_elazar") == 1
			&& PlayerPrefs.GetInt("win_komlin") == 1 && PlayerPrefs.GetInt("win_machir") == 1
			&& PlayerPrefs.GetInt("win_meir") == 1 && PlayerPrefs.GetInt("win_natronai") == 1
			&& PlayerPrefs.GetInt("win_sulam") == 1 && PlayerPrefs.GetInt("win_uri") == 1
			&& PlayerPrefs.GetInt("win_zuiskind") == 1){
				PlayerPrefs.SetInt("seq_shabsai", 75);
				Destroy(gameObject);
			}
		}
	}
}
