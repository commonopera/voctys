using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fighting_cursor : MonoBehaviour {

	//navigates within individual battle command boxes, executes actions 

	Rigidbody2D rb2d;
	int position = 1, oldposition = 1;
	bool begin = true;
	public bool chelbo, elazar, komlin, machir, meir, natronai, shabsai, sulam,
	uri, zuiskind, golem, hero;
	public string name;
	public float centerx, centery, c1x, c1y, c2x, c2y, c3x, c3y, c4x, c4y;
	public GameObject chelbo_reset, elazar_reset, komlin_reset, machir_reset,
	meir_reset, natronai_reset, shabsai_reset, sulam_reset, uri_reset, zuiskind_reset,
	golem_reset, hero_reset, atk_anim, def_anim, heal_anim, powerup_anim, move_sfx,
	sfx_pray, sfxnull, sfxwait, silent_powerup,
	poem_a, poem_b, poem_c, poem_d, poem_e, poem_f, poem_g, poem_h, poem_i;

	void Update () {
		if(begin){
			begin = false;
			rb2d = GetComponent<Rigidbody2D> ();
		}

		//play sfx on cursor having moved:
		if(oldposition != position){
			oldposition = position;
			Instantiate(move_sfx, transform.position, Quaternion.identity);
		}

		if(chelbo && (PlayerPrefs.GetInt("seq_chelbo") == 0 || PlayerPrefs.GetInt("seq_chelbo") == 100)){
			PlayerPrefs.SetInt("whichfightcursor", 1);
			Destroy(gameObject);
		}
		if(elazar && (PlayerPrefs.GetInt("seq_elazar") == 0 || PlayerPrefs.GetInt("seq_elazar") == 100)){
			PlayerPrefs.SetInt("whichfightcursor", 1);
			Destroy(gameObject);
		}
		if(komlin && (PlayerPrefs.GetInt("seq_komlin") == 0 || PlayerPrefs.GetInt("seq_komlin") == 100)){
			PlayerPrefs.SetInt("whichfightcursor", 1);
			Destroy(gameObject);
		}
		if(machir && (PlayerPrefs.GetInt("seq_machir") == 0 || PlayerPrefs.GetInt("seq_machir") == 100)){
			PlayerPrefs.SetInt("whichfightcursor", 1);
			Destroy(gameObject);
		}
		if(meir && (PlayerPrefs.GetInt("seq_meir") == 0 || PlayerPrefs.GetInt("seq_meir") == 100)){
			PlayerPrefs.SetInt("whichfightcursor", 1);
			Destroy(gameObject);
		}
		if(natronai && (PlayerPrefs.GetInt("seq_natronai") == 0 || PlayerPrefs.GetInt("seq_natronai") == 100)){
			PlayerPrefs.SetInt("whichfightcursor", 1);
			Destroy(gameObject);
		}
		if(shabsai && (PlayerPrefs.GetInt("seq_shabsai") == 0 || PlayerPrefs.GetInt("seq_shabsai") == 100)){
			PlayerPrefs.SetInt("whichfightcursor", 1);
			Destroy(gameObject);
		}
		if(sulam && (PlayerPrefs.GetInt("seq_sulam") == 0 || PlayerPrefs.GetInt("seq_sulam") == 100)){
			PlayerPrefs.SetInt("whichfightcursor", 1);
			Destroy(gameObject);
		}
		if(uri && (PlayerPrefs.GetInt("seq_uri") == 0 || PlayerPrefs.GetInt("seq_uri") == 100)){
			PlayerPrefs.SetInt("whichfightcursor", 1);
			Destroy(gameObject);
		}
		if(zuiskind && (PlayerPrefs.GetInt("seq_zuiskind") == 0 || PlayerPrefs.GetInt("seq_zuiskind") == 100)){
			PlayerPrefs.SetInt("whichfightcursor", 1);
			Destroy(gameObject);
		}
		if(golem && PlayerPrefs.GetInt("chosenname") == 0){
			PlayerPrefs.SetInt("whichfightcursor", 1);
			Destroy(gameObject);
		}


		//ATTACK:
		if(position == 1){
			rb2d.MovePosition(new Vector2(centerx + c1x, centery + c1y));
			if(Input.GetKeyDown("space")){
				if(chelbo){
					Instantiate(atk_anim, new Vector2(PlayerPrefs.GetFloat("villain_target_x"),
					PlayerPrefs.GetFloat("villain_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("enemy_dmg", (PlayerPrefs.GetInt("enemy_dmg") +
					PlayerPrefs.GetInt("chelbo_atk")));
					PlayerPrefs.SetInt(("activetime_chelbo"), 0);
					Instantiate(chelbo_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(elazar){
					Instantiate(atk_anim, new Vector2(PlayerPrefs.GetFloat("villain_target_x"),
					PlayerPrefs.GetFloat("villain_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("enemy_dmg", (PlayerPrefs.GetInt("enemy_dmg") +
					PlayerPrefs.GetInt("elazar_atk")));
					PlayerPrefs.SetInt(("activetime_elazar"), 0);
					Instantiate(elazar_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(komlin){
					Instantiate(atk_anim, new Vector2(PlayerPrefs.GetFloat("villain_target_x"),
					PlayerPrefs.GetFloat("villain_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("enemy_dmg", (PlayerPrefs.GetInt("enemy_dmg") +
					PlayerPrefs.GetInt("komlin_atk")));
					PlayerPrefs.SetInt(("activetime_komlin"), 0);
					Instantiate(komlin_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(machir){
					Instantiate(atk_anim, new Vector2(PlayerPrefs.GetFloat("villain_target_x"),
					PlayerPrefs.GetFloat("villain_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("enemy_dmg", (PlayerPrefs.GetInt("enemy_dmg") +
					PlayerPrefs.GetInt("machir_atk")));
					PlayerPrefs.SetInt(("activetime_machir"), 0);
					Instantiate(machir_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(meir){
					Instantiate(atk_anim, new Vector2(PlayerPrefs.GetFloat("villain_target_x"),
					PlayerPrefs.GetFloat("villain_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("enemy_dmg", (PlayerPrefs.GetInt("enemy_dmg") +
					PlayerPrefs.GetInt("meir_atk")));
					PlayerPrefs.SetInt(("activetime_meir"), 0);
					Instantiate(meir_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(natronai){
					Instantiate(atk_anim, new Vector2(PlayerPrefs.GetFloat("villain_target_x"),
					PlayerPrefs.GetFloat("villain_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("enemy_dmg", (PlayerPrefs.GetInt("enemy_dmg") +
					PlayerPrefs.GetInt("natronai_atk")));
					PlayerPrefs.SetInt(("activetime_natronai"), 0);
					Instantiate(natronai_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(shabsai){
					Instantiate(atk_anim, new Vector2(PlayerPrefs.GetFloat("villain_target_x"),
					PlayerPrefs.GetFloat("villain_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("enemy_dmg", (PlayerPrefs.GetInt("enemy_dmg") +
					PlayerPrefs.GetInt("shabsai_atk")));
					PlayerPrefs.SetInt(("activetime_shabsai"), 0);
					Instantiate(shabsai_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(sulam){
					Instantiate(atk_anim, new Vector2(PlayerPrefs.GetFloat("villain_target_x"),
					PlayerPrefs.GetFloat("villain_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("enemy_dmg", (PlayerPrefs.GetInt("enemy_dmg") +
					PlayerPrefs.GetInt("sulam_atk")));
					PlayerPrefs.SetInt(("activetime_sulam"), 0);
					Instantiate(sulam_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(uri){
					Instantiate(atk_anim, new Vector2(PlayerPrefs.GetFloat("villain_target_x"),
					PlayerPrefs.GetFloat("villain_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("enemy_dmg", (PlayerPrefs.GetInt("enemy_dmg") +
					PlayerPrefs.GetInt("uri_atk")));
					PlayerPrefs.SetInt(("activetime_uri"), 0);
					Instantiate(uri_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(zuiskind){
					Instantiate(atk_anim, new Vector2(PlayerPrefs.GetFloat("villain_target_x"),
					PlayerPrefs.GetFloat("villain_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("enemy_dmg", (PlayerPrefs.GetInt("enemy_dmg") +
					PlayerPrefs.GetInt("zuiskind_atk")));
					PlayerPrefs.SetInt(("activetime_zuiskind"), 0);
					Instantiate(zuiskind_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(golem){
					Instantiate(atk_anim, new Vector2(PlayerPrefs.GetFloat("villain_target_x"),
					PlayerPrefs.GetFloat("villain_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("enemy_dmg", (PlayerPrefs.GetInt("enemy_dmg") +
					PlayerPrefs.GetInt("golem_atk")));
					PlayerPrefs.SetInt(("activetime_golem"), 0);
					Instantiate(golem_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(hero){
					Instantiate(atk_anim, new Vector2(PlayerPrefs.GetFloat("villain_target_x"),
					PlayerPrefs.GetFloat("villain_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("enemy_dmg", (PlayerPrefs.GetInt("enemy_dmg") +
					PlayerPrefs.GetInt("hero_atk")));
					PlayerPrefs.SetInt(("activetime_hero"), 0);
					Instantiate(hero_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				PlayerPrefs.SetInt("ani_" + name, 1);
				PlayerPrefs.SetInt("whichfightcursor", 1);
				Destroy(gameObject);
			}
			if(Input.GetKeyDown("right")){
				position = 2;
			}
			if(Input.GetKeyDown("down")){
				position = 3;
			}
		}

		//DEFEND:
		else if(position == 2){
			rb2d.MovePosition(new Vector2(centerx + c2x, centery + c2y));
			if(Input.GetKeyDown("space")){
				if(chelbo){
					Instantiate(def_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
					PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("ally_dmg", (PlayerPrefs.GetInt("ally_dmg") -
					PlayerPrefs.GetInt("chelbo_def")));
					PlayerPrefs.SetInt(("activetime_chelbo"), 0);
					Instantiate(chelbo_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(elazar){
					Instantiate(def_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
					PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("ally_dmg", (PlayerPrefs.GetInt("ally_dmg") -
					PlayerPrefs.GetInt("elazar_def")));
					PlayerPrefs.SetInt(("activetime_elazar"), 0);
					Instantiate(elazar_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(komlin){
					Instantiate(def_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
					PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("ally_dmg", (PlayerPrefs.GetInt("ally_dmg") -
					PlayerPrefs.GetInt("komlin_def")));
					PlayerPrefs.SetInt(("activetime_komlin"), 0);
					Instantiate(komlin_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(machir){
					Instantiate(def_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
					PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("ally_dmg", (PlayerPrefs.GetInt("ally_dmg") -
					PlayerPrefs.GetInt("machir_def")));
					PlayerPrefs.SetInt(("activetime_machir"), 0);
					Instantiate(machir_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(meir){
					Instantiate(def_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
					PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("ally_dmg", (PlayerPrefs.GetInt("ally_dmg") -
					PlayerPrefs.GetInt("meir_def")));
					PlayerPrefs.SetInt(("activetime_meir"), 0);
					Instantiate(meir_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(natronai){
					Instantiate(def_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
					PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("ally_dmg", (PlayerPrefs.GetInt("ally_dmg") -
					PlayerPrefs.GetInt("natronai_def")));
					PlayerPrefs.SetInt(("activetime_natronai"), 0);
					Instantiate(natronai_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(shabsai){
					Instantiate(def_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
					PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("ally_dmg", (PlayerPrefs.GetInt("ally_dmg") -
					PlayerPrefs.GetInt("shabsai_def")));
					PlayerPrefs.SetInt(("activetime_shabsai"), 0);
					Instantiate(shabsai_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(sulam){
					Instantiate(def_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
					PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("ally_dmg", (PlayerPrefs.GetInt("ally_dmg") -
					PlayerPrefs.GetInt("sulam_def")));
					PlayerPrefs.SetInt(("activetime_sulam"), 0);
					Instantiate(sulam_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(uri){
					Instantiate(def_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
					PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("ally_dmg", (PlayerPrefs.GetInt("ally_dmg") -
					PlayerPrefs.GetInt("uri_def")));
					PlayerPrefs.SetInt(("activetime_uri"), 0);
					Instantiate(uri_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(zuiskind){
					Instantiate(def_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
					PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("ally_dmg", (PlayerPrefs.GetInt("ally_dmg") -
					PlayerPrefs.GetInt("zuiskind_def")));
					PlayerPrefs.SetInt(("activetime_zuiskind"), 0);
					Instantiate(zuiskind_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(golem){
					Instantiate(def_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
					PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("ally_dmg", (PlayerPrefs.GetInt("ally_dmg") -
					PlayerPrefs.GetInt("golem_def")));
					PlayerPrefs.SetInt(("activetime_golem"), 0);
					Instantiate(golem_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(hero){
					Instantiate(def_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
					PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("ally_dmg", (PlayerPrefs.GetInt("ally_dmg") -
					PlayerPrefs.GetInt("hero_def")));
					PlayerPrefs.SetInt(("activetime_hero"), 0);
					Instantiate(hero_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				PlayerPrefs.SetInt("ani_" + name, 2);
				PlayerPrefs.SetInt("whichfightcursor", 1);
				Destroy(gameObject);
			}
			if(Input.GetKeyDown("left")){
				position = 1;
			}
			if(Input.GetKeyDown("down")){
				position = 4;
			}
		}

		//SP MOVE:
		else if(position == 3){
			rb2d.MovePosition(new Vector2(centerx + c3x, centery + c3y));
			if(Input.GetKeyDown("space")){
				if(chelbo){
					Instantiate(heal_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
					PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("ally_dmg", (PlayerPrefs.GetInt("ally_dmg") - 2));
					PlayerPrefs.SetInt(("activetime_chelbo"), 0);
					Instantiate(chelbo_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(elazar){
					if(PlayerPrefs.GetInt("speech_part") == 1){
						Instantiate(poem_a, new Vector2(0, 2.75f), Quaternion.identity);
						PlayerPrefs.SetInt("speech_part", 2);
					}
					else if(PlayerPrefs.GetInt("speech_part") == 2){
						Instantiate(poem_b, new Vector2(0, 2.75f), Quaternion.identity);
						PlayerPrefs.SetInt("speech_part", 3);
					}
					else if(PlayerPrefs.GetInt("speech_part") == 3){
						Instantiate(poem_c, new Vector2(0, 2.75f), Quaternion.identity);
						PlayerPrefs.SetInt("speech_part", 4);
					}
					else if(PlayerPrefs.GetInt("speech_part") == 4){
						Instantiate(poem_d, new Vector2(0, 2.75f), Quaternion.identity);
						PlayerPrefs.SetInt("speech_part", 5);
					}
					else if(PlayerPrefs.GetInt("speech_part") == 5){
						Instantiate(poem_e, new Vector2(0, 2.75f), Quaternion.identity);
						PlayerPrefs.SetInt("speech_part", 6);
					}
					else if(PlayerPrefs.GetInt("speech_part") == 6){
						Instantiate(poem_f, new Vector2(0, 2.75f), Quaternion.identity);
						PlayerPrefs.SetInt("speech_part", 7);
					}
					else if(PlayerPrefs.GetInt("speech_part") == 7){
						Instantiate(poem_g, new Vector2(0, 2.75f), Quaternion.identity);
						PlayerPrefs.SetInt("speech_part", 8);
					}
					else if(PlayerPrefs.GetInt("speech_part") == 8){
						Instantiate(poem_h, new Vector2(0, 2.75f), Quaternion.identity);
						PlayerPrefs.SetInt("speech_part", 9);
					}
					else if(PlayerPrefs.GetInt("speech_part") == 9){
						Instantiate(poem_i, new Vector2(0, 2.75f), Quaternion.identity);
					}
					PlayerPrefs.SetInt(("activetime_elazar"), 0);
					Instantiate(elazar_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(komlin){
					Instantiate(powerup_anim, new Vector2(-2.4f, 1.07f), Quaternion.identity);
					PlayerPrefs.SetInt("komlin_atk", (PlayerPrefs.GetInt("komlin_atk") + 1));
					PlayerPrefs.SetInt(("activetime_komlin"), 0);
					Instantiate(komlin_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(machir){
					Instantiate(powerup_anim, new Vector2(-3.06f, .91f), Quaternion.identity);
					//THIS MOVE DOES NOTHING???
					PlayerPrefs.SetInt(("activetime_machir"), 0);
					Instantiate(machir_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(meir){
					Instantiate(powerup_anim, new Vector2(-2.55f, 1.24f), Quaternion.identity);
					//THIS MOVE DOES NOTHING???
					PlayerPrefs.SetInt(("activetime_meir"), 0);
					Instantiate(meir_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(natronai){
					Instantiate(heal_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
					PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
					PlayerPrefs.SetInt("ally_dmg", (PlayerPrefs.GetInt("ally_dmg") - 4));
					PlayerPrefs.SetInt(("activetime_natronai"), 0);
					Instantiate(natronai_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(shabsai){
					Instantiate(silent_powerup, new Vector2(-2.4f, 1.07f), Quaternion.identity);
					Instantiate(silent_powerup, new Vector2(-2.74f, .84f), Quaternion.identity);
					Instantiate(silent_powerup, new Vector2(-2.55f, 1.24f), Quaternion.identity);
					Instantiate(silent_powerup, new Vector2(-2.72f, 1.12f), Quaternion.identity);
					Instantiate(silent_powerup, new Vector2(-2.88f, 1f), Quaternion.identity);
					Instantiate(silent_powerup, new Vector2(-3.06f, .91f), Quaternion.identity);
					Instantiate(silent_powerup, new Vector2(-2.78f, 1.35f), Quaternion.identity);
					Instantiate(powerup_anim, new Vector2(-2.95f, 1.25f), Quaternion.identity);
					Instantiate(silent_powerup, new Vector2(-3.13f, 1.15f), Quaternion.identity);
					Instantiate(silent_powerup, new Vector2(-3.32f, 1.04f), Quaternion.identity);
					PlayerPrefs.SetInt("chelbo_atk", (PlayerPrefs.GetInt("chelbo_atk") + 1));
					PlayerPrefs.SetInt("elazar_atk", (PlayerPrefs.GetInt("elazar_atk") + 1));
					PlayerPrefs.SetInt("komlin_atk", (PlayerPrefs.GetInt("komlin_atk") + 1));
					PlayerPrefs.SetInt("machir_atk", (PlayerPrefs.GetInt("machir_atk") + 1));
					PlayerPrefs.SetInt("meir_atk", (PlayerPrefs.GetInt("meir_atk") + 1));
					PlayerPrefs.SetInt("natronai_atk", (PlayerPrefs.GetInt("natronai_atk") + 1));
					PlayerPrefs.SetInt("sulam_atk", (PlayerPrefs.GetInt("sulam_atk") + 1));
					PlayerPrefs.SetInt("uri_atk", (PlayerPrefs.GetInt("uri_atk") + 1));
					PlayerPrefs.SetInt("zuiskind_atk", (PlayerPrefs.GetInt("zuiskind_atk") + 1));
					PlayerPrefs.SetInt("hero_atk", (PlayerPrefs.GetInt("hero_atk") + 1));
					PlayerPrefs.SetInt(("activetime_shabsai"), 0);
					Instantiate(shabsai_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(sulam){
					Instantiate(powerup_anim, new Vector2(-2.74f, .84f), Quaternion.identity);
					PlayerPrefs.SetInt("sulam_def", (PlayerPrefs.GetInt("sulam_def") + 1));
					PlayerPrefs.SetInt(("activetime_sulam"), 0);
					Instantiate(sulam_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(uri){
					if(PlayerPrefs.GetInt("poem_part") == 1){
						Instantiate(poem_a, new Vector2(0, -2.75f), Quaternion.identity);
						PlayerPrefs.SetInt("poem_part", 2);
					}
					else if(PlayerPrefs.GetInt("poem_part") == 2){
						Instantiate(poem_b, new Vector2(0, -2.75f), Quaternion.identity);
						PlayerPrefs.SetInt("poem_part", 3);
					}
					else if(PlayerPrefs.GetInt("poem_part") == 3){
						Instantiate(poem_c, new Vector2(0, -2.75f), Quaternion.identity);
						PlayerPrefs.SetInt("poem_part", 4);
					}
					else if(PlayerPrefs.GetInt("poem_part") == 4){
						Instantiate(poem_d, new Vector2(0, -2.75f), Quaternion.identity);
						PlayerPrefs.SetInt("poem_part", 5);
					}
					else if(PlayerPrefs.GetInt("poem_part") == 5){
						Instantiate(poem_e, new Vector2(0, -2.75f), Quaternion.identity);
						PlayerPrefs.SetInt("poem_part", 6);
					}
					else if(PlayerPrefs.GetInt("poem_part") == 6){
						Instantiate(poem_f, new Vector2(0, -2.75f), Quaternion.identity);
						PlayerPrefs.SetInt("poem_part", 7);
					}
					else if(PlayerPrefs.GetInt("poem_part") == 7){
						Instantiate(poem_g, new Vector2(0, -2.75f), Quaternion.identity);
						PlayerPrefs.SetInt("poem_part", 8);
					}
					else if(PlayerPrefs.GetInt("poem_part") == 8){
						Instantiate(poem_h, new Vector2(0, -2.75f), Quaternion.identity);
						PlayerPrefs.SetInt("poem_part", 9);
					}
					else if(PlayerPrefs.GetInt("poem_part") == 9){
						Instantiate(poem_i, new Vector2(0, -2.75f), Quaternion.identity);
					}
					PlayerPrefs.SetInt(("activetime_uri"), 0);
					Instantiate(uri_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(zuiskind){
					if(PlayerPrefs.GetInt("chosenname") > 0){
						Instantiate(powerup_anim, new Vector2(-2.08f, .86f), Quaternion.identity);
					}
					else{
						Instantiate(sfxnull, transform.position, Quaternion.identity);
					}
					PlayerPrefs.SetInt("golem_atk", (PlayerPrefs.GetInt("golem_atk") + 2));
					PlayerPrefs.SetInt(("activetime_zuiskind"), 0);
					Instantiate(zuiskind_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(golem){
					if(PlayerPrefs.GetInt("chosenname") == 1 ||
					PlayerPrefs.GetInt("chosenname") == 13 ||
					PlayerPrefs.GetInt("chosenname") == 16 ||
					PlayerPrefs.GetInt("chosenname") == 27 ||
					PlayerPrefs.GetInt("chosenname") == 30 ||
					PlayerPrefs.GetInt("chosenname") == 42 ||
					PlayerPrefs.GetInt("chosenname") == 53){
						//MARS -
						Instantiate(atk_anim, new Vector2(PlayerPrefs.GetFloat("villain_target_x"),
						PlayerPrefs.GetFloat("villain_target_y")), Quaternion.identity);
						PlayerPrefs.SetInt("enemy_dmg", (PlayerPrefs.GetInt("enemy_dmg") + 11));
					}
					if(PlayerPrefs.GetInt("chosenname") == 2 ||
					PlayerPrefs.GetInt("chosenname") == 6 ||
					PlayerPrefs.GetInt("chosenname") == 7 ||
					PlayerPrefs.GetInt("chosenname") == 10 ||
					PlayerPrefs.GetInt("chosenname") == 12 ||
					PlayerPrefs.GetInt("chosenname") == 18 ||
					PlayerPrefs.GetInt("chosenname") == 19 ||
					PlayerPrefs.GetInt("chosenname") == 21 ||
					PlayerPrefs.GetInt("chosenname") == 22 ||
					PlayerPrefs.GetInt("chosenname") == 26 ||
					PlayerPrefs.GetInt("chosenname") == 28 ||
					PlayerPrefs.GetInt("chosenname") == 32 ||
					PlayerPrefs.GetInt("chosenname") == 35 ||
					PlayerPrefs.GetInt("chosenname") == 37 ||
					PlayerPrefs.GetInt("chosenname") == 38 ||
					PlayerPrefs.GetInt("chosenname") == 47 ||
					PlayerPrefs.GetInt("chosenname") == 52 ||
					PlayerPrefs.GetInt("chosenname") == 56 ||
					PlayerPrefs.GetInt("chosenname") == 58 ||
					PlayerPrefs.GetInt("chosenname") == 61 ||
					PlayerPrefs.GetInt("chosenname") == 62){
						//JUPITER -
						Instantiate(powerup_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
						PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
						PlayerPrefs.SetInt("golem_atk", (PlayerPrefs.GetInt("golem_atk") + 3));
					}
					if(PlayerPrefs.GetInt("chosenname") == 3 ||
					PlayerPrefs.GetInt("chosenname") == 8 ||
					PlayerPrefs.GetInt("chosenname") == 15 ||
					PlayerPrefs.GetInt("chosenname") == 20 ||
					PlayerPrefs.GetInt("chosenname") == 23 ||
					PlayerPrefs.GetInt("chosenname") == 25 ||
					PlayerPrefs.GetInt("chosenname") == 29 ||
					PlayerPrefs.GetInt("chosenname") == 33 ||
					PlayerPrefs.GetInt("chosenname") == 39 ||
					PlayerPrefs.GetInt("chosenname") == 40 ||
					PlayerPrefs.GetInt("chosenname") == 44 ||
					PlayerPrefs.GetInt("chosenname") == 50 ||
					PlayerPrefs.GetInt("chosenname") == 54 ||
					PlayerPrefs.GetInt("chosenname") == 59){
						//SATURN -
						Instantiate(atk_anim, new Vector2(PlayerPrefs.GetFloat("villain_target_x"),
						PlayerPrefs.GetFloat("villain_target_y")), Quaternion.identity);
						PlayerPrefs.SetInt("enemy_dmg", (PlayerPrefs.GetInt("enemy_dmg") + 10));
					}
					if(PlayerPrefs.GetInt("chosenname") == 4 ||
					PlayerPrefs.GetInt("chosenname") == 11 ||
					PlayerPrefs.GetInt("chosenname") == 14 ||
					PlayerPrefs.GetInt("chosenname") == 24 ||
					PlayerPrefs.GetInt("chosenname") == 46 ||
					PlayerPrefs.GetInt("chosenname") == 51 ||
					PlayerPrefs.GetInt("chosenname") == 63 ||
					PlayerPrefs.GetInt("chosenname") == 64){
						//MERCURY -
						Instantiate(atk_anim, new Vector2(PlayerPrefs.GetFloat("villain_target_x"),
						PlayerPrefs.GetFloat("villain_target_y")), Quaternion.identity);
						PlayerPrefs.SetInt("enemy_dmg", (PlayerPrefs.GetInt("enemy_dmg") + 8));
					}
					if(PlayerPrefs.GetInt("chosenname") == 5 ||
					PlayerPrefs.GetInt("chosenname") == 9 ||
					PlayerPrefs.GetInt("chosenname") == 17 ||
					PlayerPrefs.GetInt("chosenname") == 31 ||
					PlayerPrefs.GetInt("chosenname") == 34 ||
					PlayerPrefs.GetInt("chosenname") == 36 ||
					PlayerPrefs.GetInt("chosenname") == 41 ||
					PlayerPrefs.GetInt("chosenname") == 43 ||
					PlayerPrefs.GetInt("chosenname") == 45 ||
					PlayerPrefs.GetInt("chosenname") == 48 ||
					PlayerPrefs.GetInt("chosenname") == 49 ||
					PlayerPrefs.GetInt("chosenname") == 55 ||
					PlayerPrefs.GetInt("chosenname") == 57 ||
					PlayerPrefs.GetInt("chosenname") == 60){
						//VENUS -
						Instantiate(powerup_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
						PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
						PlayerPrefs.SetInt("golem_atk", (PlayerPrefs.GetInt("golem_atk") + 4));
					}
					PlayerPrefs.SetInt(("activetime_golem"), 0);
					Instantiate(golem_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(hero){
					//THIS MOVE DOES NOTHING
					PlayerPrefs.SetInt(("activetime_hero"), 0);
					Instantiate(sfxwait, transform.position, Quaternion.identity);
					Instantiate(hero_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				PlayerPrefs.SetInt("ani_" + name, 3);
				PlayerPrefs.SetInt("whichfightcursor", 1);
				Destroy(gameObject);
			}
			if(Input.GetKeyDown("up")){
				position = 1;
			}
			if(Input.GetKeyDown("right")){
				position = 4;
			}
		}

		//PRAY:
		else if(position == 4){
			rb2d.MovePosition(new Vector2(centerx + c4x, centery + c4y));
			if(Input.GetKeyDown("space")){
				if(!golem){
					Instantiate(sfx_pray, transform.position, Quaternion.identity);
				}
				if(chelbo){
					PlayerPrefs.SetInt("timesprayed", (PlayerPrefs.GetInt("timesprayed") + 1));
					PlayerPrefs.SetInt(("activetime_chelbo"), 0);
					Instantiate(chelbo_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(elazar){
					PlayerPrefs.SetInt("timesprayed", (PlayerPrefs.GetInt("timesprayed") + 1));
					PlayerPrefs.SetInt(("activetime_elazar"), 0);
					Instantiate(elazar_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(komlin){
					PlayerPrefs.SetInt("timesprayed", (PlayerPrefs.GetInt("timesprayed") + 1));
					PlayerPrefs.SetInt(("activetime_komlin"), 0);
					Instantiate(komlin_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(machir){
					PlayerPrefs.SetInt("timesprayed", (PlayerPrefs.GetInt("timesprayed") + 1));
					PlayerPrefs.SetInt(("activetime_machir"), 0);
					Instantiate(machir_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(meir){
					PlayerPrefs.SetInt("timesprayed", (PlayerPrefs.GetInt("timesprayed") + 1));
					PlayerPrefs.SetInt(("activetime_meir"), 0);
					Instantiate(meir_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(natronai){
					PlayerPrefs.SetInt("timesprayed", (PlayerPrefs.GetInt("timesprayed") + 1));
					PlayerPrefs.SetInt(("activetime_natronai"), 0);
					Instantiate(natronai_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(shabsai){
					PlayerPrefs.SetInt("timesprayed", (PlayerPrefs.GetInt("timesprayed") + 1));
					PlayerPrefs.SetInt(("activetime_shabsai"), 0);
					Instantiate(shabsai_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(sulam){
					PlayerPrefs.SetInt("timesprayed", (PlayerPrefs.GetInt("timesprayed") + 1));
					PlayerPrefs.SetInt(("activetime_sulam"), 0);
					Instantiate(sulam_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(uri){
					PlayerPrefs.SetInt("timesprayed", (PlayerPrefs.GetInt("timesprayed") + 1));
					PlayerPrefs.SetInt(("activetime_uri"), 0);
					Instantiate(uri_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(zuiskind){
					PlayerPrefs.SetInt("timesprayed", (PlayerPrefs.GetInt("timesprayed") + 1));
					PlayerPrefs.SetInt(("activetime_zuiskind"), 0);
					Instantiate(zuiskind_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(golem){
					if(PlayerPrefs.GetInt("chosenname") == 1 ||
					PlayerPrefs.GetInt("chosenname") == 6 ||
					PlayerPrefs.GetInt("chosenname") == 8 ||
					PlayerPrefs.GetInt("chosenname") == 18 ||
					PlayerPrefs.GetInt("chosenname") == 24 ||
					PlayerPrefs.GetInt("chosenname") == 31 ||
					PlayerPrefs.GetInt("chosenname") == 33 ||
					PlayerPrefs.GetInt("chosenname") == 43 ||
					PlayerPrefs.GetInt("chosenname") == 47){
						//MARS +
						Instantiate(heal_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
						PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
						PlayerPrefs.SetInt("ally_dmg", (PlayerPrefs.GetInt("ally_dmg") - 7));
					}
					if(PlayerPrefs.GetInt("chosenname") == 2 ||
					PlayerPrefs.GetInt("chosenname") == 13 ||
					PlayerPrefs.GetInt("chosenname") == 15 ||
					PlayerPrefs.GetInt("chosenname") == 19 ||
					PlayerPrefs.GetInt("chosenname") == 28 ||
					PlayerPrefs.GetInt("chosenname") == 40 ||
					PlayerPrefs.GetInt("chosenname") == 44 ||
					PlayerPrefs.GetInt("chosenname") == 45 ||
					PlayerPrefs.GetInt("chosenname") == 46 ||
					PlayerPrefs.GetInt("chosenname") == 49 ||
					PlayerPrefs.GetInt("chosenname") == 61 ||
					PlayerPrefs.GetInt("chosenname") == 63){
						//JUPITER +
						Instantiate(heal_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
						PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
						PlayerPrefs.SetInt("ally_dmg", (PlayerPrefs.GetInt("ally_dmg") - 9));
					}
					if(PlayerPrefs.GetInt("chosenname") == 3 ||
					PlayerPrefs.GetInt("chosenname") == 7 ||
					PlayerPrefs.GetInt("chosenname") == 10 ||
					PlayerPrefs.GetInt("chosenname") == 11 ||
					PlayerPrefs.GetInt("chosenname") == 12 ||
					PlayerPrefs.GetInt("chosenname") == 14 ||
					PlayerPrefs.GetInt("chosenname") == 20 ||
					PlayerPrefs.GetInt("chosenname") == 21 ||
					PlayerPrefs.GetInt("chosenname") == 23 ||
					PlayerPrefs.GetInt("chosenname") == 26 ||
					PlayerPrefs.GetInt("chosenname") == 27 ||
					PlayerPrefs.GetInt("chosenname") == 29 ||
					PlayerPrefs.GetInt("chosenname") == 34 ||
					PlayerPrefs.GetInt("chosenname") == 36 ||
					PlayerPrefs.GetInt("chosenname") == 37 ||
					PlayerPrefs.GetInt("chosenname") == 41 ||
					PlayerPrefs.GetInt("chosenname") == 51 ||
					PlayerPrefs.GetInt("chosenname") == 53){
						//SATURN +
						Instantiate(powerup_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
						PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
						PlayerPrefs.SetInt("golem_def", (PlayerPrefs.GetInt("golem_def") + 3));
					}
					if(PlayerPrefs.GetInt("chosenname") == 4 ||
					PlayerPrefs.GetInt("chosenname") == 9 ||
					PlayerPrefs.GetInt("chosenname") == 22 ||
					PlayerPrefs.GetInt("chosenname") == 25 ||
					PlayerPrefs.GetInt("chosenname") == 30 ||
					PlayerPrefs.GetInt("chosenname") == 35 ||
					PlayerPrefs.GetInt("chosenname") == 52 ||
					PlayerPrefs.GetInt("chosenname") == 57){
						//MERCURY +
						Instantiate(heal_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
						PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
						PlayerPrefs.SetInt("ally_dmg", (PlayerPrefs.GetInt("ally_dmg") - 11));
					}
					if(PlayerPrefs.GetInt("chosenname") == 5 ||
					PlayerPrefs.GetInt("chosenname") == 16 ||
					PlayerPrefs.GetInt("chosenname") == 17 ||
					PlayerPrefs.GetInt("chosenname") == 32 ||
					PlayerPrefs.GetInt("chosenname") == 38 ||
					PlayerPrefs.GetInt("chosenname") == 39 ||
					PlayerPrefs.GetInt("chosenname") == 42 ||
					PlayerPrefs.GetInt("chosenname") == 48 ||
					PlayerPrefs.GetInt("chosenname") == 50 ||
					PlayerPrefs.GetInt("chosenname") == 54 ||
					PlayerPrefs.GetInt("chosenname") == 55 ||
					PlayerPrefs.GetInt("chosenname") == 56 ||
					PlayerPrefs.GetInt("chosenname") == 58 ||
					PlayerPrefs.GetInt("chosenname") == 59 ||
					PlayerPrefs.GetInt("chosenname") == 60 ||
					PlayerPrefs.GetInt("chosenname") == 62 ||
					PlayerPrefs.GetInt("chosenname") == 64){
						//VENUS +
						Instantiate(powerup_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x"),
						PlayerPrefs.GetFloat("monk_target_y")), Quaternion.identity);
						PlayerPrefs.SetInt("golem_def", (PlayerPrefs.GetInt("golem_def") + 5));
					}
					PlayerPrefs.SetInt(("activetime_golem"), 0);
					Instantiate(golem_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				if(hero){
					PlayerPrefs.SetInt("timesprayed", (PlayerPrefs.GetInt("timesprayed") + 1));
					PlayerPrefs.SetInt(("activetime_hero"), 0);
					Instantiate(hero_reset, new Vector2(centerx, centery), Quaternion.identity);
				}
				PlayerPrefs.SetInt("ani_" + name, 4);
				PlayerPrefs.SetInt("whichfightcursor", 1);
				Destroy(gameObject);
			}
			if(Input.GetKeyDown("up")){
				position = 2;
			}
			if(Input.GetKeyDown("left")){
				position = 3;
			}
		}
	}
}
