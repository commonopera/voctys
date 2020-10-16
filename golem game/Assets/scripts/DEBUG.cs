using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEBUG : MonoBehaviour {

	//test stuff!!

	public bool killchelbo, killelazar, killkomlin, killmachir, killmeir, killnatronai,
	killshabsai, killsulam, killuri, killzuiskind, winchelbo, winelazar, winkomlin,
	winmachir, winmeir, winnatronai, winshabsai, winsulam, winuri, winzuiskind;

	void Start () {
		StartCoroutine(OkNow());
	}

	IEnumerator OkNow(){
		yield return new WaitForSeconds(1);
		if(killchelbo){
			PlayerPrefs.SetInt("seq_chelbo", 0);
		}
		if(killelazar){
			PlayerPrefs.SetInt("seq_elazar", 0);
		}
		if(killkomlin){
			PlayerPrefs.SetInt("seq_komlin", 0);
		}
		if(killmachir){
			PlayerPrefs.SetInt("seq_machir", 0);
		}
		if(killmeir){
			PlayerPrefs.SetInt("seq_meir", 0);
		}
		if(killnatronai){
			PlayerPrefs.SetInt("seq_natronai", 0);
		}
		if(killshabsai){
			PlayerPrefs.SetInt("seq_shabsai", 0);
		}
		if(killsulam){
			PlayerPrefs.SetInt("seq_sulam", 0);
		}
		if(killuri){
			PlayerPrefs.SetInt("seq_uri", 0);
		}
		if(killzuiskind){
			PlayerPrefs.SetInt("seq_zuiskind", 0);
		}
		if(winchelbo){
			PlayerPrefs.SetInt("win_chelbo", 1);
		}
		if(winelazar){
			PlayerPrefs.SetInt("win_elazar", 1);
		}
		if(winkomlin){
			PlayerPrefs.SetInt("win_komlin", 1);
		}
		if(winmachir){
			PlayerPrefs.SetInt("win_machir", 1);
		}
		if(winmeir){
			PlayerPrefs.SetInt("win_meir", 1);
		}
		if(winnatronai){
			PlayerPrefs.SetInt("win_natronai", 1);
		}
		if(winshabsai){
			PlayerPrefs.SetInt("win_shabsai", 1);
		}
		if(winsulam){
			PlayerPrefs.SetInt("win_sulam", 1);
		}
		if(winuri){
			PlayerPrefs.SetInt("win_uri", 1);
		}
		if(winzuiskind){
			PlayerPrefs.SetInt("win_zuiskind", 1);
		}
	}
}
