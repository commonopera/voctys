using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class halo_show : MonoBehaviour {

	//instantiates halos over characters for whom theyve been unlocked

	public GameObject halo;
	public bool BATTLEMODE, chelbo, elazar, komlin, machir, meir, natronai, shabsai, sulam,
	uri, zuiskind;
	bool rauld = true;
	float difference = 0;

	void Start () {
		if(BATTLEMODE){
			difference = .03f;
		}
	}

	void Update () {
		if(rauld){
			if(chelbo){
				if(PlayerPrefs.GetInt("seq_chelbo") == 22){
					PlayerPrefs.SetInt("win_chelbo", 1);
					Instantiate(halo, new Vector2(transform.position.x - difference, transform.position.y),
					Quaternion.identity, transform);
					rauld = false;
				}
			}
			if(elazar){
				if(PlayerPrefs.GetInt("seq_elazar") == 59){
					PlayerPrefs.SetInt("win_elazar", 1);
					Instantiate(halo, new Vector2(transform.position.x - difference, transform.position.y),
					Quaternion.identity, transform);
					rauld = false;
				}
			}
			if(komlin){
				if(PlayerPrefs.GetInt("seq_komlin") == 82 || PlayerPrefs.GetInt("seq_komlin") == 83){
					PlayerPrefs.SetInt("win_komlin", 1);
					Instantiate(halo, new Vector2(transform.position.x - difference, transform.position.y),
					Quaternion.identity, transform);
					rauld = false;
				}
			}
			if(machir){
				if(PlayerPrefs.GetInt("seq_machir") == 78 || PlayerPrefs.GetInt("seq_machir") == 79){
					PlayerPrefs.SetInt("win_machir", 1);
					Instantiate(halo, new Vector2(transform.position.x - difference, transform.position.y),
					Quaternion.identity, transform);
					rauld = false;
				}
			}
			if(meir){
				if(PlayerPrefs.GetInt("seq_meir") == 71 || PlayerPrefs.GetInt("seq_meir") == 72){
					PlayerPrefs.SetInt("win_meir", 1);
					Instantiate(halo, new Vector2(transform.position.x - difference, transform.position.y),
					Quaternion.identity, transform);
					rauld = false;
				}
			}
			if(natronai){
				if(PlayerPrefs.GetInt("seq_natronai") == 5 || PlayerPrefs.GetInt("seq_natronai") == 6
				|| PlayerPrefs.GetInt("seq_natronai") == 7 || PlayerPrefs.GetInt("seq_natronai") == 8
				|| PlayerPrefs.GetInt("seq_natronai") == 9 || PlayerPrefs.GetInt("seq_natronai") == 10
				|| PlayerPrefs.GetInt("seq_natronai") == 11 || PlayerPrefs.GetInt("seq_natronai") == 50){
					PlayerPrefs.SetInt("win_natronai", 1);
					Instantiate(halo, new Vector2(transform.position.x - difference, transform.position.y),
					Quaternion.identity, transform);
					rauld = false;
				}
			}
			if(shabsai){
				if(PlayerPrefs.GetInt("seq_shabsai") == 76 || PlayerPrefs.GetInt("seq_shabsai") == 77
				|| PlayerPrefs.GetInt("seq_shabsai") == 78 || PlayerPrefs.GetInt("seq_shabsai") == 79){
					PlayerPrefs.SetInt("win_shabsai", 1);
					Instantiate(halo, new Vector2(transform.position.x - difference, transform.position.y),
					Quaternion.identity, transform);
					rauld = false;
				}
			}
			if(sulam){
				if(PlayerPrefs.GetInt("seq_sulam") == 56 || PlayerPrefs.GetInt("seq_sulam") == 57){
					PlayerPrefs.SetInt("win_sulam", 1);
					Instantiate(halo, new Vector2(transform.position.x - difference, transform.position.y),
					Quaternion.identity, transform);
					rauld = false;
				}
			}
			if(uri){
				if(PlayerPrefs.GetInt("seq_uri") == 55 || PlayerPrefs.GetInt("seq_uri") == 56
				|| PlayerPrefs.GetInt("seq_uri") == 57){
					PlayerPrefs.SetInt("win_uri", 1);
					Instantiate(halo, new Vector2(transform.position.x - difference, transform.position.y),
					Quaternion.identity, transform);
					rauld = false;
				}
			}
			if(zuiskind){
				if(PlayerPrefs.GetInt("seq_zuiskind") == 79 || PlayerPrefs.GetInt("seq_zuiskind") == 80){
					PlayerPrefs.SetInt("win_zuiskind", 1);
					Instantiate(halo, new Vector2(transform.position.x - difference, transform.position.y),
					Quaternion.identity, transform);
					rauld = false;
				}
			}
		}
	}
}
