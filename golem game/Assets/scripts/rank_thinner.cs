using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rank_thinner : MonoBehaviour {

	//removes characters whose souls have been taken from battle scene

	public bool chelbo, elazar, komlin, machir, meir, natronai, shabsai, sulam,
	uri, zuiskind, golem;

	void Update () {
		if(chelbo){
			if(PlayerPrefs.GetInt("seq_chelbo") == 0 || PlayerPrefs.GetInt("seq_chelbo") == 100){
				Destroy(gameObject);
			}
		}
		if(elazar){
			if(PlayerPrefs.GetInt("seq_elazar") == 0 || PlayerPrefs.GetInt("seq_elazar") == 100){
				Destroy(gameObject);
			}
		}
		if(komlin){
			if(PlayerPrefs.GetInt("seq_komlin") == 0 || PlayerPrefs.GetInt("seq_komlin") == 100){
				Destroy(gameObject);
			}
		}
		if(machir){
			if(PlayerPrefs.GetInt("seq_machir") == 0 || PlayerPrefs.GetInt("seq_machir") == 100){
				Destroy(gameObject);
			}
		}
		if(meir){
			if(PlayerPrefs.GetInt("seq_meir") == 0 || PlayerPrefs.GetInt("seq_meir") == 100){
				Destroy(gameObject);
			}
		}
		if(natronai){
			if(PlayerPrefs.GetInt("seq_natronai") == 0 || PlayerPrefs.GetInt("seq_natronai") == 100){
				Destroy(gameObject);
			}
		}
		if(shabsai){
			if(PlayerPrefs.GetInt("seq_shabsai") == 0 || PlayerPrefs.GetInt("seq_shabsai") == 100){
				Destroy(gameObject);
			}
		}
		if(sulam){
			if(PlayerPrefs.GetInt("seq_sulam") == 0 || PlayerPrefs.GetInt("seq_sulam") == 100){
				Destroy(gameObject);
			}
		}
		if(uri){
			if(PlayerPrefs.GetInt("seq_uri") == 0 || PlayerPrefs.GetInt("seq_uri") == 100){
				Destroy(gameObject);
			}
		}
		if(zuiskind){
			if(PlayerPrefs.GetInt("seq_zuiskind") == 0 || PlayerPrefs.GetInt("seq_zuiskind") == 100){
				Destroy(gameObject);
			}
		}
		if(golem){
			if(PlayerPrefs.GetInt("chosenname") == 0){
				Destroy(gameObject);
			}
		}
	}
}
