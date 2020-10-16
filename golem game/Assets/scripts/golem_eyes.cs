using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golem_eyes : MonoBehaviour {

	//sets awakened golem eye color based on soul color
	//destroys golem if it was not given a name

	SpriteRenderer Render;
	public bool formenu;

	void Start () {
		Render = GetComponent<SpriteRenderer>();

		if(PlayerPrefs.GetInt("chosenname") == 0){
			Destroy(transform.parent.gameObject);
		}

		if(!formenu){
			//red:
			if(PlayerPrefs.GetInt("chosenname") == 1){
				Render.color = new Color(.84f,.13f,.1f);
			}

			//blue:
			if(PlayerPrefs.GetInt("chosenname") == 2 || PlayerPrefs.GetInt("chosenname") == 19
			|| PlayerPrefs.GetInt("chosenname") == 28 || PlayerPrefs.GetInt("chosenname") == 61){
				Render.color = new Color(.19f,.43f,1);
			}

			//yellow:
			if(PlayerPrefs.GetInt("chosenname") == 3 || PlayerPrefs.GetInt("chosenname") == 20
			|| PlayerPrefs.GetInt("chosenname") == 23 || PlayerPrefs.GetInt("chosenname") == 29){
				Render.color = new Color(1,.97f,.34f);
			}

			//black:
			if(PlayerPrefs.GetInt("chosenname") == 4){
				Render.color = new Color(0,0,0);
			}

			//white:
			if(PlayerPrefs.GetInt("chosenname") == 5 || PlayerPrefs.GetInt("chosenname") == 17
			|| PlayerPrefs.GetInt("chosenname") == 48 || PlayerPrefs.GetInt("chosenname") == 60
			|| PlayerPrefs.GetInt("chosenname") == 55){
				Render.color = new Color(.82f,.82f,.82f);
			}

			//green:
			if(PlayerPrefs.GetInt("chosenname") == 10 || PlayerPrefs.GetInt("chosenname") == 12
			|| PlayerPrefs.GetInt("chosenname") == 15 || PlayerPrefs.GetInt("chosenname") == 21
			|| PlayerPrefs.GetInt("chosenname") == 26 || PlayerPrefs.GetInt("chosenname") == 7
			|| PlayerPrefs.GetInt("chosenname") == 37 || PlayerPrefs.GetInt("chosenname") == 40
			|| PlayerPrefs.GetInt("chosenname") == 44){
				Render.color = new Color(.28f,.7f,.34f);
			}

			//brown:
			if(PlayerPrefs.GetInt("chosenname") == 11 || PlayerPrefs.GetInt("chosenname") == 14
			|| PlayerPrefs.GetInt("chosenname") == 25 || PlayerPrefs.GetInt("chosenname") == 51){
				Render.color = new Color(.38f,.17f,.04f);
			}

			//purple:
			if(PlayerPrefs.GetInt("chosenname") == 13 || PlayerPrefs.GetInt("chosenname") == 18
			|| PlayerPrefs.GetInt("chosenname") == 6 || PlayerPrefs.GetInt("chosenname") == 47){
				Render.color = new Color(.6f,.14f,.72f);
			}

			//pink:
			if(PlayerPrefs.GetInt("chosenname") == 16 || PlayerPrefs.GetInt("chosenname") == 31
			|| PlayerPrefs.GetInt("chosenname") == 42 || PlayerPrefs.GetInt("chosenname") == 43){
				Render.color = new Color(.99f,.6f,.68f);
			}

			//maroon:
			if(PlayerPrefs.GetInt("chosenname") == 24 || PlayerPrefs.GetInt("chosenname") == 30){
				Render.color = new Color(.47f,.06f,.07f);
			}

			//orange:
			if(PlayerPrefs.GetInt("chosenname") == 27 || PlayerPrefs.GetInt("chosenname") == 8
			|| PlayerPrefs.GetInt("chosenname") == 33 || PlayerPrefs.GetInt("chosenname") == 53){
				Render.color = new Color(.92f,.5f,.06f);
			}

			//gray:
			if(PlayerPrefs.GetInt("chosenname") == 9 || PlayerPrefs.GetInt("chosenname") == 57
			|| PlayerPrefs.GetInt("chosenname") == 64){
				Render.color = new Color(.44f,.44f,.44f);
			}

			//sand:
			if(PlayerPrefs.GetInt("chosenname") == 34 || PlayerPrefs.GetInt("chosenname") == 36
			|| PlayerPrefs.GetInt("chosenname") == 39 || PlayerPrefs.GetInt("chosenname") == 41
			|| PlayerPrefs.GetInt("chosenname") == 54 || PlayerPrefs.GetInt("chosenname") == 59
			|| PlayerPrefs.GetInt("chosenname") == 50){
				Render.color = new Color(.97f,.9f,.59f);
			}

			//navy:
			if(PlayerPrefs.GetInt("chosenname") == 22 || PlayerPrefs.GetInt("chosenname") == 35
			|| PlayerPrefs.GetInt("chosenname") == 46 || PlayerPrefs.GetInt("chosenname") == 63
			|| PlayerPrefs.GetInt("chosenname") == 52){
				Render.color = new Color(.08f,.1f,.29f);
			}

			//sky:
			if(PlayerPrefs.GetInt("chosenname") == 32 || PlayerPrefs.GetInt("chosenname") == 38
			|| PlayerPrefs.GetInt("chosenname") == 58 || PlayerPrefs.GetInt("chosenname") == 45
			|| PlayerPrefs.GetInt("chosenname") == 56 || PlayerPrefs.GetInt("chosenname") == 49
			|| PlayerPrefs.GetInt("chosenname") == 62){
				Render.color = new Color(.57f,.68f,.92f);
			}
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
