using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gem_shower : MonoBehaviour {

	//pops up animation of gem when a soul is acquired
	//determines color based on mixproduct if result of synthesis

	public GameObject onlygem, bluegem, yellowgem, whitegem, purplegem, greengem,
	orangegem, graygem, browngem, pinkgem, navygem, skygem, sandgem, maroongem;
	public bool synthesis;
	public float posx = 1.41f, posy = 1.56f;

	void Start () {
		if(!synthesis){
			Instantiate(onlygem, new Vector2(posx, posy), Quaternion.identity);
		}
		if(synthesis){
			if(PlayerPrefs.GetInt("mixproduct") == 28 ||
			PlayerPrefs.GetInt("mixproduct") == 61){
				Instantiate(bluegem, new Vector2(posx, posy), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("mixproduct") == 20 ||
			PlayerPrefs.GetInt("mixproduct") == 23 ||
			PlayerPrefs.GetInt("mixproduct") == 29){
				Instantiate(yellowgem, new Vector2(posx, posy), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("mixproduct") == 60 ||
			PlayerPrefs.GetInt("mixproduct") == 48 ||
			PlayerPrefs.GetInt("mixproduct") == 55){
				Instantiate(whitegem, new Vector2(posx, posy), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("mixproduct") == 6 ||
			PlayerPrefs.GetInt("mixproduct") == 47){
				Instantiate(purplegem, new Vector2(posx, posy), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("mixproduct") == 21 ||
			PlayerPrefs.GetInt("mixproduct") == 26 ||
			PlayerPrefs.GetInt("mixproduct") == 7 ||
			PlayerPrefs.GetInt("mixproduct") == 37 ||
			PlayerPrefs.GetInt("mixproduct") == 40 ||
			PlayerPrefs.GetInt("mixproduct") == 44){
				Instantiate(greengem, new Vector2(posx, posy), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("mixproduct") == 27 ||
			PlayerPrefs.GetInt("mixproduct") == 8 ||
			PlayerPrefs.GetInt("mixproduct") == 33 ||
			PlayerPrefs.GetInt("mixproduct") == 53){
				Instantiate(orangegem, new Vector2(posx, posy), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("mixproduct") == 9 ||
			PlayerPrefs.GetInt("mixproduct") == 57 ||
			PlayerPrefs.GetInt("mixproduct") == 64){
				Instantiate(graygem, new Vector2(posx, posy), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("mixproduct") == 25 ||
			PlayerPrefs.GetInt("mixproduct") == 51){
				Instantiate(browngem, new Vector2(posx, posy), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("mixproduct") == 31 ||
			PlayerPrefs.GetInt("mixproduct") == 42 ||
			PlayerPrefs.GetInt("mixproduct") == 43){
				Instantiate(pinkgem, new Vector2(posx, posy), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("mixproduct") == 22 ||
			PlayerPrefs.GetInt("mixproduct") == 35 ||
			PlayerPrefs.GetInt("mixproduct") == 46 ||
			PlayerPrefs.GetInt("mixproduct") == 63 ||
			PlayerPrefs.GetInt("mixproduct") == 52){
				Instantiate(navygem, new Vector2(posx, posy), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("mixproduct") == 32 ||
			PlayerPrefs.GetInt("mixproduct") == 38 ||
			PlayerPrefs.GetInt("mixproduct") == 58 ||
			PlayerPrefs.GetInt("mixproduct") == 45 ||
			PlayerPrefs.GetInt("mixproduct") == 56 ||
			PlayerPrefs.GetInt("mixproduct") == 49 ||
			PlayerPrefs.GetInt("mixproduct") == 62){
				Instantiate(skygem, new Vector2(posx, posy), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("mixproduct") == 34 ||
			PlayerPrefs.GetInt("mixproduct") == 36 ||
			PlayerPrefs.GetInt("mixproduct") == 39 ||
			PlayerPrefs.GetInt("mixproduct") == 41 ||
			PlayerPrefs.GetInt("mixproduct") == 54 ||
			PlayerPrefs.GetInt("mixproduct") == 59 ||
			PlayerPrefs.GetInt("mixproduct") == 50){
				Instantiate(sandgem, new Vector2(posx, posy), Quaternion.identity);
			}
			if(PlayerPrefs.GetInt("mixproduct") == 24 ||
			PlayerPrefs.GetInt("mixproduct") == 30){
				Instantiate(maroongem, new Vector2(posx, posy), Quaternion.identity);
			}
		}
	}
}
