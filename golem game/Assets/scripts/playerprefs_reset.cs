using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerprefs_reset : MonoBehaviour {

	//uh-huh, you know what it is

//	int screenx, screeny;

	void Start () {

/*		if(Screen.currentResolution.width < 1800 || Screen.currentResolution.height < 1200){
			Screen.SetResolution(900, 600, false);
		}
		if((Screen.currentResolution.width >= 1800 && Screen.currentResolution.width < 2700)
		&& (Screen.currentResolution.height >= 1200 && Screen.currentResolution.height < 1800)){
			Screen.SetResolution(1800, 1200, false);
		}
		if(Screen.currentResolution.width >= 2700 && Screen.currentResolution.height >= 1800){
			Screen.SetResolution(2700, 1800, false);
		}*/
		Screen.SetResolution(1800, 1200, true);

/*		if(Screen.currentResolution.width/Screen.currentResolution.height > 3/2){
			screeny = ((Screen.currentResolution.height) - ((Screen.currentResolution.height) % 600));
			screenx = ((screeny * 3) / 2);
		}
		else{
			screenx = ((Screen.currentResolution.width) - ((Screen.currentResolution.width) % 900));
			screeny = (2 * (screenx / 3));
		}
		Screen.SetResolution(screenx, screeny, true);*/
		//(should?) set window size to highest multiple of 300x200 that will fit on screen

		//(i wanted the game to load in a window scaled to fit on the screen but
		//i couldnt get any of the above working so it just loads fullscreen instead
		//which is probably a better and more intimate way to experience it anyway)

		PlayerPrefs.SetInt("room", 11);
		//room #

		PlayerPrefs.SetInt("inroom", 0);
		//1 = in room, 0 = not in room

		PlayerPrefs.SetInt("fadereset", 0);
		//set to 1 upon leaving a room to cause overmap to fade in,
		//turned back off once it has

		PlayerPrefs.SetInt("facing", 2);
		//1 = LD, 2 = LU, 3 = RU, 4 = RD

		PlayerPrefs.SetInt("frozen", 0);
		//0 = player can move, 1 = cannot

		PlayerPrefs.SetString("playername", "");
		//sets players name

		PlayerPrefs.SetInt("screenclear", 0);
		//1 = deletes various objects, used and reset in 'screenclear' script

		PlayerPrefs.SetInt("seq_chelbo", 1);
		PlayerPrefs.SetInt("seq_elazar", 1);
		PlayerPrefs.SetInt("seq_komlin", 1);
		PlayerPrefs.SetInt("seq_machir", 1);
		PlayerPrefs.SetInt("seq_meir", 1);
		PlayerPrefs.SetInt("seq_natronai", 1);
		PlayerPrefs.SetInt("seq_shabsai", 1);
		PlayerPrefs.SetInt("seq_sulam", 1);
		PlayerPrefs.SetInt("seq_uri", 1);
		PlayerPrefs.SetInt("seq_zuiskind", 1);
		//dialogue sequences: 0 = name taken, 1 = starting dialogue, etc = etc

		PlayerPrefs.SetInt("win_chelbo", 0);
		PlayerPrefs.SetInt("win_elazar", 0);
		PlayerPrefs.SetInt("win_komlin", 0);
		PlayerPrefs.SetInt("win_machir", 0);
		PlayerPrefs.SetInt("win_meir", 0);
		PlayerPrefs.SetInt("win_natronai", 0);
		PlayerPrefs.SetInt("win_shabsai", 0);
		PlayerPrefs.SetInt("win_sulam", 0);
		PlayerPrefs.SetInt("win_uri", 0);
		PlayerPrefs.SetInt("win_zuiskind", 0);
		//triggered when character reaches good end

		PlayerPrefs.SetInt("sacrednames", 0);
		//number of collected names total

		PlayerPrefs.SetInt("name1", 0);
		PlayerPrefs.SetInt("name2", 0);
		PlayerPrefs.SetInt("name3", 0);
		PlayerPrefs.SetInt("name4", 0);
		PlayerPrefs.SetInt("name5", 0);
		PlayerPrefs.SetInt("name6", 0);
		PlayerPrefs.SetInt("name7", 0);
		PlayerPrefs.SetInt("name8", 0);
		PlayerPrefs.SetInt("name9", 0);
		PlayerPrefs.SetInt("name10", 0);
		PlayerPrefs.SetInt("name11", 0);
		PlayerPrefs.SetInt("name12", 0);
		PlayerPrefs.SetInt("name13", 0);
		PlayerPrefs.SetInt("name14", 0);
		PlayerPrefs.SetInt("name15", 0);
		PlayerPrefs.SetInt("name16", 0);
		PlayerPrefs.SetInt("name17", 0);
		PlayerPrefs.SetInt("name18", 0);
		PlayerPrefs.SetInt("name19", 0);
		PlayerPrefs.SetInt("name20", 0);
		PlayerPrefs.SetInt("name21", 0);
		PlayerPrefs.SetInt("name22", 0);
		PlayerPrefs.SetInt("name23", 0);
		PlayerPrefs.SetInt("name24", 0);
		PlayerPrefs.SetInt("name25", 0);
		PlayerPrefs.SetInt("name26", 0);
		PlayerPrefs.SetInt("name27", 0);
		PlayerPrefs.SetInt("name28", 0);
		PlayerPrefs.SetInt("name29", 0);
		PlayerPrefs.SetInt("name30", 0);
		PlayerPrefs.SetInt("name31", 0);
		PlayerPrefs.SetInt("name32", 0);
		PlayerPrefs.SetInt("name33", 0);
		PlayerPrefs.SetInt("name34", 0);
		PlayerPrefs.SetInt("name35", 0);
		PlayerPrefs.SetInt("name36", 0);
		PlayerPrefs.SetInt("name37", 0);
		PlayerPrefs.SetInt("name38", 0);
		PlayerPrefs.SetInt("name39", 0);
		PlayerPrefs.SetInt("name40", 0);
		PlayerPrefs.SetInt("name41", 0);
		PlayerPrefs.SetInt("name42", 0);
		PlayerPrefs.SetInt("name43", 0);
		PlayerPrefs.SetInt("name44", 0);
		PlayerPrefs.SetInt("name45", 0);
		PlayerPrefs.SetInt("name46", 0);
		PlayerPrefs.SetInt("name47", 0);
		PlayerPrefs.SetInt("name48", 0);
		PlayerPrefs.SetInt("name49", 0);
		PlayerPrefs.SetInt("name50", 0);
		PlayerPrefs.SetInt("name51", 0);
		PlayerPrefs.SetInt("name52", 0);
		PlayerPrefs.SetInt("name53", 0);
		PlayerPrefs.SetInt("name54", 0);
		PlayerPrefs.SetInt("name55", 0);
		PlayerPrefs.SetInt("name56", 0);
		PlayerPrefs.SetInt("name57", 0);
		PlayerPrefs.SetInt("name58", 0);
		PlayerPrefs.SetInt("name59", 0);
		PlayerPrefs.SetInt("name60", 0);
		PlayerPrefs.SetInt("name61", 0);
		PlayerPrefs.SetInt("name62", 0);
		PlayerPrefs.SetInt("name63", 0);
		PlayerPrefs.SetInt("name64", 0);
		//0 = names not owned, 1 = names owned

		PlayerPrefs.SetInt("gem1taken", 0);
		PlayerPrefs.SetInt("gem2taken", 0);
		PlayerPrefs.SetInt("gem3taken", 0);
		PlayerPrefs.SetInt("gem4taken", 0);
		PlayerPrefs.SetInt("gem5taken", 0);
		PlayerPrefs.SetInt("applestaken", 0);
		PlayerPrefs.SetInt("oatstaken", 0);
		PlayerPrefs.SetInt("chestnutstaken", 0);
		PlayerPrefs.SetInt("honeytaken", 0);
		PlayerPrefs.SetInt("jewelrtaken", 0);
		PlayerPrefs.SetInt("jewelytaken", 0);
		PlayerPrefs.SetInt("jewelbtaken", 0);
		//0 = item not taken, 1 = item taken

		PlayerPrefs.SetInt("selectedname", 0);
		PlayerPrefs.SetInt("chosenname", 0);
		PlayerPrefs.SetInt("leftmix", 0);
		PlayerPrefs.SetInt("rightmix", 0);
		PlayerPrefs.SetInt("mixproduct", 0);
		//0 = none, other options correspond to sacred name ids

		PlayerPrefs.SetInt("mixable", 0);
		//1 = two sides of mix menu can mix, 0 = cannot

		PlayerPrefs.SetInt("fighttime", 0);
		PlayerPrefs.SetInt("fightalmost", 0);
		//sets to one when timer has run down OR when player has rested
		//(fightalmost set when timer runs out but bonus 3 minutes have not yet elapsed)

		PlayerPrefs.SetInt("oldworldkill", 0);
		//destroys pre-battle objects when set to 1

		PlayerPrefs.SetInt("timesprayed", 0);
		//does this do anything???

		PlayerPrefs.SetInt("activetime_chelbo", 1);
		PlayerPrefs.SetInt("activetime_elazar", 1);
		PlayerPrefs.SetInt("activetime_komlin", 1);
		PlayerPrefs.SetInt("activetime_machir", 1);
		PlayerPrefs.SetInt("activetime_meir", 1);
		PlayerPrefs.SetInt("activetime_natronai", 1);
		PlayerPrefs.SetInt("activetime_shabsai", 1);
		PlayerPrefs.SetInt("activetime_sulam", 1);
		PlayerPrefs.SetInt("activetime_uri", 1);
		PlayerPrefs.SetInt("activetime_zuiskind", 1);
		PlayerPrefs.SetInt("activetime_golem", 1);
		PlayerPrefs.SetInt("activetime_hero", 1);
		//1 = ready, 0 = loading

		PlayerPrefs.SetInt("whichfightcursor", 1);
		//1 = fighter_cursor, 0 = fighting_cursor

		PlayerPrefs.SetInt("whosselected", 12);
		//arrow above unit corresponds to selected menu in battle

		PlayerPrefs.SetInt("ally_dmg", 0);
		PlayerPrefs.SetInt("enemy_dmg", 0);
		//during battle: units eliminated upon reaching certain thresholds

		PlayerPrefs.SetInt("chelbo_atk", 3);
		PlayerPrefs.SetInt("chelbo_def", 4);
		PlayerPrefs.SetInt("elazar_atk", 4);
		PlayerPrefs.SetInt("elazar_def", 4);
		PlayerPrefs.SetInt("komlin_atk", 7);
		PlayerPrefs.SetInt("komlin_def", 5);
		PlayerPrefs.SetInt("machir_atk", 3);
		PlayerPrefs.SetInt("machir_def", 5);
		PlayerPrefs.SetInt("meir_atk", 3);
		PlayerPrefs.SetInt("meir_def", 5);
		PlayerPrefs.SetInt("natronai_atk", 1);
		PlayerPrefs.SetInt("natronai_def", 3);
		PlayerPrefs.SetInt("shabsai_atk", 6);
		PlayerPrefs.SetInt("shabsai_def", 7);
		PlayerPrefs.SetInt("sulam_atk", 5);
		PlayerPrefs.SetInt("sulam_def", 6);
		PlayerPrefs.SetInt("uri_atk", 2);
		PlayerPrefs.SetInt("uri_def", 5);
		PlayerPrefs.SetInt("zuiskind_atk", 3);
		PlayerPrefs.SetInt("zuiskind_def", 2);
		PlayerPrefs.SetInt("golem_atk", 0);
		PlayerPrefs.SetInt("golem_def", 0);
		PlayerPrefs.SetInt("golem_hp", 0);
		PlayerPrefs.SetInt("hero_atk", 2);
		PlayerPrefs.SetInt("hero_def", 2);
		//character base stats

		PlayerPrefs.SetInt("ani_chelbo", 0);
		PlayerPrefs.SetInt("ani_elazar", 0);
		PlayerPrefs.SetInt("ani_komlin", 0);
		PlayerPrefs.SetInt("ani_machir", 0);
		PlayerPrefs.SetInt("ani_meir", 0);
		PlayerPrefs.SetInt("ani_natronai", 0);
		PlayerPrefs.SetInt("ani_shabsai", 0);
		PlayerPrefs.SetInt("ani_sulam", 0);
		PlayerPrefs.SetInt("ani_uri", 0);
		PlayerPrefs.SetInt("ani_zuiskind", 0);
		PlayerPrefs.SetInt("ani_golem", 0);
		PlayerPrefs.SetInt("ani_hero", 0);
		//battle animation states

		PlayerPrefs.SetFloat("villain_target_x", 0);
		PlayerPrefs.SetFloat("villain_target_y", 0);
		PlayerPrefs.SetFloat("monk_target_x", 0);
		PlayerPrefs.SetFloat("monk_target_y", 0);
		//foremost unit location (for spawning battle feedback animations)

		PlayerPrefs.SetInt("poem_part", 1);
		PlayerPrefs.SetInt("speech_part", 1);
		PlayerPrefs.SetInt("endscene", 0);
		PlayerPrefs.SetInt("darkenscreen", 0);
	}
}
