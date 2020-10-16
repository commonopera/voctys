using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastwords : MonoBehaviour {

	//multi-use:
	//summons dialogue for proto-battle based on highest ranked monk remaining,
	//destroys proto-battle objects & spawns real battle objects

	public bool are_words, is_oldworld;
	public GameObject endgame, dia_chelbo_a, dia_chelbo_b,
	dia_elazar_a, dia_elazar_b,
	dia_komlin_a, dia_komlin_b,
	dia_machir_a, dia_machir_b,
	dia_meir_a, dia_meir_b,
	dia_natronai_a, dia_natronai_b,
	dia_shabsai_a, dia_shabsai_b,
	dia_sulam_a, dia_sulam_b,
	dia_uri_a, dia_uri_b,
	dia_zuiskind_a, dia_zuiskind_b,
	dia_hero;

	void Start () {
		if(are_words == false){
			if(PlayerPrefs.GetInt("seq_shabsai") != 0){
				if(PlayerPrefs.GetInt("seq_shabsai") == 76 || PlayerPrefs.GetInt("seq_shabsai") == 77
				|| PlayerPrefs.GetInt("seq_shabsai") == 78 || PlayerPrefs.GetInt("seq_shabsai") == 79){
					Instantiate(dia_shabsai_a, new Vector2(0, -2.585f), Quaternion.identity);
				}
				else{
					Instantiate(dia_shabsai_b, new Vector2(0, -2.585f), Quaternion.identity);
				}
			}

			else if(PlayerPrefs.GetInt("seq_zuiskind") != 0){
				if(PlayerPrefs.GetInt("seq_zuiskind") == 79 || PlayerPrefs.GetInt("seq_zuiskind") == 80){
					Instantiate(dia_zuiskind_a, new Vector2(0, -2.585f), Quaternion.identity);
				}
				else{
					Instantiate(dia_zuiskind_b, new Vector2(0, -2.585f), Quaternion.identity);
				}
			}

			else if(PlayerPrefs.GetInt("seq_natronai") != 0){
				if(PlayerPrefs.GetInt("seq_natronai") == 5 || PlayerPrefs.GetInt("seq_natronai") == 6
				|| PlayerPrefs.GetInt("seq_natronai") == 7 || PlayerPrefs.GetInt("seq_natronai") == 8
				|| PlayerPrefs.GetInt("seq_natronai") == 9 || PlayerPrefs.GetInt("seq_natronai") == 10
				|| PlayerPrefs.GetInt("seq_natronai") == 11 || PlayerPrefs.GetInt("seq_natronai") == 50){
					Instantiate(dia_natronai_a, new Vector2(0, -2.585f), Quaternion.identity);
				}
				else{
					Instantiate(dia_natronai_b, new Vector2(0, -2.585f), Quaternion.identity);
				}
			}

			else if(PlayerPrefs.GetInt("seq_sulam") != 0){
				if(PlayerPrefs.GetInt("seq_sulam") == 56 || PlayerPrefs.GetInt("seq_sulam") == 57){
					Instantiate(dia_sulam_a, new Vector2(0, -2.585f), Quaternion.identity);
				}
				else{
					Instantiate(dia_sulam_b, new Vector2(0, -2.585f), Quaternion.identity);
				}
			}

			else if(PlayerPrefs.GetInt("seq_meir") != 0){
				if(PlayerPrefs.GetInt("seq_meir") == 71 || PlayerPrefs.GetInt("seq_meir") == 72){
					Instantiate(dia_meir_a, new Vector2(0, -2.585f), Quaternion.identity);
				}
				else{
					Instantiate(dia_meir_b, new Vector2(0, -2.585f), Quaternion.identity);
				}
			}

			else if(PlayerPrefs.GetInt("seq_machir") != 0){
				if(PlayerPrefs.GetInt("seq_machir") == 78 || PlayerPrefs.GetInt("seq_machir") == 79){
					Instantiate(dia_machir_a, new Vector2(0, -2.585f), Quaternion.identity);
				}
				else{
					Instantiate(dia_machir_b, new Vector2(0, -2.585f), Quaternion.identity);
				}
			}

			else if(PlayerPrefs.GetInt("seq_komlin") != 0){
				if(PlayerPrefs.GetInt("seq_komlin") == 82 || PlayerPrefs.GetInt("seq_komlin") == 83){
					Instantiate(dia_komlin_b, new Vector2(0, -2.585f), Quaternion.identity);
				}
				else{
					Instantiate(dia_komlin_a, new Vector2(0, -2.585f), Quaternion.identity);
				}
			}

			else if(PlayerPrefs.GetInt("seq_uri") != 0){
				if(PlayerPrefs.GetInt("seq_uri") == 55 || PlayerPrefs.GetInt("seq_uri") == 56
				|| PlayerPrefs.GetInt("seq_uri") == 57){
					Instantiate(dia_uri_a, new Vector2(0, -2.585f), Quaternion.identity);
				}
				else{
					Instantiate(dia_uri_b, new Vector2(0, -2.585f), Quaternion.identity);
				}
			}

			else if(PlayerPrefs.GetInt("seq_elazar") != 0){
				if(PlayerPrefs.GetInt("seq_elazar") == 59){
					Instantiate(dia_elazar_a, new Vector2(0, -2.585f), Quaternion.identity);
				}
				else{
					Instantiate(dia_elazar_b, new Vector2(0, -2.585f), Quaternion.identity);
				}
			}

			else if(PlayerPrefs.GetInt("seq_chelbo") != 0){
				if(PlayerPrefs.GetInt("seq_chelbo") == 21 || PlayerPrefs.GetInt("seq_chelbo") == 22){
					Instantiate(dia_chelbo_a, new Vector2(0, -2.585f), Quaternion.identity);
				}
				else{
					Instantiate(dia_chelbo_b, new Vector2(0, -2.585f), Quaternion.identity);
				}
			}
			else{
				Instantiate(dia_hero, new Vector2(0, -2.585f), Quaternion.identity);
			}
		}
	}

	void Update () {
		if(is_oldworld){
			if(PlayerPrefs.GetInt("oldworldkill") == 1){
				PlayerPrefs.SetInt("oldworldkill", 0);
				Destroy(gameObject);
			}
		}
	}

	void OnDestroy(){
		if(are_words){
			PlayerPrefs.SetInt("oldworldkill", 1);
			Instantiate(endgame, new Vector2(-2.25f, 1), Quaternion.identity);
		}
	}
}
