using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ally_health : MonoBehaviour {

	//triggers kill next ally in sequence when their ally dmg reaches their health
	//then resets ally dmg

	public bool chelbo, elazar, komlin, machir, meir, natronai, shabsai, sulam,
	uri, zuiskind, golem, hero;
	public GameObject death, gameover;

	void Update () {
		if(PlayerPrefs.GetInt("chosenname") > 0){
			if(golem){
				PlayerPrefs.SetFloat("monk_target_x", transform.position.x);
				PlayerPrefs.SetFloat("monk_target_y", transform.position.y);
			}
			if(golem && (PlayerPrefs.GetInt("ally_dmg") > PlayerPrefs.GetInt("golem_hp"))){
				Instantiate(death, transform.position, Quaternion.identity);
				PlayerPrefs.SetInt("chosenname", 0);
				PlayerPrefs.SetInt("ally_dmg", 0);
				Destroy(gameObject);
			}
		}
		else if(PlayerPrefs.GetInt("seq_shabsai") > 0 && PlayerPrefs.GetInt("seq_shabsai") != 100){
			if(shabsai){
				PlayerPrefs.SetFloat("monk_target_x", transform.position.x);
				PlayerPrefs.SetFloat("monk_target_y", transform.position.y);
			}
			if(shabsai && (PlayerPrefs.GetInt("ally_dmg") > 17)){
				Instantiate(death, transform.position, Quaternion.identity);
				PlayerPrefs.SetInt("seq_shabsai", 100);
				PlayerPrefs.SetInt("ally_dmg", 0);
			}
		}
		else if(PlayerPrefs.GetInt("seq_sulam") > 0 && PlayerPrefs.GetInt("seq_sulam") != 100){
			if(sulam){
				PlayerPrefs.SetFloat("monk_target_x", transform.position.x);
				PlayerPrefs.SetFloat("monk_target_y", transform.position.y);
			}
			if(sulam && (PlayerPrefs.GetInt("ally_dmg") > 20)){
				Instantiate(death, transform.position, Quaternion.identity);
				PlayerPrefs.SetInt("seq_sulam", 100);
				PlayerPrefs.SetInt("ally_dmg", 0);
			}
		}
		else if(PlayerPrefs.GetInt("seq_komlin") > 0 && PlayerPrefs.GetInt("seq_komlin") != 100){
			if(komlin){
				PlayerPrefs.SetFloat("monk_target_x", transform.position.x);
				PlayerPrefs.SetFloat("monk_target_y", transform.position.y);
			}
			if(komlin && (PlayerPrefs.GetInt("ally_dmg") > 18)){
				Instantiate(death, transform.position, Quaternion.identity);
				PlayerPrefs.SetInt("seq_komlin", 100);
				PlayerPrefs.SetInt("ally_dmg", 0);
			}
		}
		else if(PlayerPrefs.GetInt("seq_machir") > 0 && PlayerPrefs.GetInt("seq_machir") != 100){
			if(machir){
				PlayerPrefs.SetFloat("monk_target_x", transform.position.x);
				PlayerPrefs.SetFloat("monk_target_y", transform.position.y);
			}
			if(machir && (PlayerPrefs.GetInt("ally_dmg") > 14)){
				Instantiate(death, transform.position, Quaternion.identity);
				PlayerPrefs.SetInt("seq_machir", 100);
				PlayerPrefs.SetInt("ally_dmg", 0);
			}
		}
		else if(PlayerPrefs.GetInt("seq_meir") > 0 && PlayerPrefs.GetInt("seq_meir") != 100){
			if(meir){
				PlayerPrefs.SetFloat("monk_target_x", transform.position.x);
				PlayerPrefs.SetFloat("monk_target_y", transform.position.y);
			}
			if(meir && (PlayerPrefs.GetInt("ally_dmg") > 14)){
				Instantiate(death, transform.position, Quaternion.identity);
				PlayerPrefs.SetInt("seq_meir", 100);
				PlayerPrefs.SetInt("ally_dmg", 0);
			}
		}
		else if(PlayerPrefs.GetInt("seq_chelbo") > 0 && PlayerPrefs.GetInt("seq_chelbo") != 100){
			if(chelbo){
				PlayerPrefs.SetFloat("monk_target_x", transform.position.x);
				PlayerPrefs.SetFloat("monk_target_y", transform.position.y);
			}
			if(chelbo && (PlayerPrefs.GetInt("ally_dmg") > 12)){
				Instantiate(death, transform.position, Quaternion.identity);
				PlayerPrefs.SetInt("seq_chelbo", 100);
				PlayerPrefs.SetInt("ally_dmg", 0);
			}
		}
		else if(PlayerPrefs.GetInt("seq_elazar") > 0 && PlayerPrefs.GetInt("seq_elazar") != 100){
			if(elazar){
				PlayerPrefs.SetFloat("monk_target_x", transform.position.x);
				PlayerPrefs.SetFloat("monk_target_y", transform.position.y);
			}
			if(elazar && (PlayerPrefs.GetInt("ally_dmg") > 13)){
				Instantiate(death, transform.position, Quaternion.identity);
				PlayerPrefs.SetInt("seq_elazar", 100);
				PlayerPrefs.SetInt("ally_dmg", 0);
			}
		}
		else if(PlayerPrefs.GetInt("seq_uri") > 0 && PlayerPrefs.GetInt("seq_uri") != 100){
			if(uri){
				PlayerPrefs.SetFloat("monk_target_x", transform.position.x);
				PlayerPrefs.SetFloat("monk_target_y", transform.position.y);
			}
			if(uri && (PlayerPrefs.GetInt("ally_dmg") > 11)){
				Instantiate(death, transform.position, Quaternion.identity);
				PlayerPrefs.SetInt("seq_uri", 100);
				PlayerPrefs.SetInt("ally_dmg", 0);
			}
		}
		else if(PlayerPrefs.GetInt("seq_natronai") > 0 && PlayerPrefs.GetInt("seq_natronai") != 100){
			if(natronai){
				PlayerPrefs.SetFloat("monk_target_x", transform.position.x);
				PlayerPrefs.SetFloat("monk_target_y", transform.position.y);
			}
			if(natronai && (PlayerPrefs.GetInt("ally_dmg") > 10)){
				Instantiate(death, transform.position, Quaternion.identity);
				PlayerPrefs.SetInt("seq_natronai", 100);
				PlayerPrefs.SetInt("ally_dmg", 0);
			}
		}
		else if(PlayerPrefs.GetInt("seq_zuiskind") > 0 && PlayerPrefs.GetInt("seq_zuiskind") != 100){
			if(zuiskind){
				PlayerPrefs.SetFloat("monk_target_x", transform.position.x);
				PlayerPrefs.SetFloat("monk_target_y", transform.position.y);
			}
			if(zuiskind && (PlayerPrefs.GetInt("ally_dmg") > 9)){
				Instantiate(death, transform.position, Quaternion.identity);
				PlayerPrefs.SetInt("seq_zuiskind", 100);
				PlayerPrefs.SetInt("ally_dmg", 0);
			}
		}
		else{
			if(hero){
				PlayerPrefs.SetFloat("monk_target_x", transform.position.x);
				PlayerPrefs.SetFloat("monk_target_y", transform.position.y);
			}
			if(hero && (PlayerPrefs.GetInt("ally_dmg") > 13)){
				Instantiate(gameover, new Vector2(0,0), Quaternion.identity);
				Destroy(gameObject);
			}
		}
	}
}
