using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fighter_cursor : MonoBehaviour {

	//navigates cursor over character names in combat menu
	//skips over anybody who isnt present

	Rigidbody2D rb2d;
	int position = 12, oldposition = 12;
	bool begin = true, shudderready = true;
	public float w1x, w1y, w2x, w2y, w3x, w3y, w4x, w4y, w5x, w5y, w6x, w6y, w7x, w7y,
	w8x, w8y, w9x, w9y, w10x, w10y, w11x, w11y, w12x, w12y;
	public GameObject cursor_chelbo, cursor_elazar, cursor_komlin, cursor_machir,
	cursor_meir, cursor_natronai, cursor_shabsai, cursor_sulam, cursor_uri,
	cursor_zuiskind, cursor_golem, cursor_hero, move_sfx;


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

		//shuddering cursor when selected space disappears beneath you:
		if(((position == 1 && (PlayerPrefs.GetInt("seq_chelbo") == 0 || PlayerPrefs.GetInt("seq_chelbo") == 100))
		|| (position == 2 && (PlayerPrefs.GetInt("seq_elazar") == 0 || PlayerPrefs.GetInt("seq_elazar") == 100))
		|| (position == 3 && (PlayerPrefs.GetInt("seq_komlin") == 0 || PlayerPrefs.GetInt("seq_komlin") == 100))
		|| (position == 4 && (PlayerPrefs.GetInt("seq_machir") == 0 || PlayerPrefs.GetInt("seq_machir") == 100))
		|| (position == 5 && (PlayerPrefs.GetInt("seq_meir") == 0 || PlayerPrefs.GetInt("seq_meir") == 100))
		|| (position == 6 && (PlayerPrefs.GetInt("seq_natronai") == 0 || PlayerPrefs.GetInt("seq_natronai") == 100))
		|| (position == 7 && (PlayerPrefs.GetInt("seq_shabsai") == 0 || PlayerPrefs.GetInt("seq_shabsai") == 100))
		|| (position == 8 && (PlayerPrefs.GetInt("seq_sulam") == 0 || PlayerPrefs.GetInt("seq_sulam") == 100))
		|| (position == 9 && (PlayerPrefs.GetInt("seq_uri") == 0 || PlayerPrefs.GetInt("seq_uri") == 100))
		|| (position == 10 && (PlayerPrefs.GetInt("seq_zuiskind") == 0 || PlayerPrefs.GetInt("seq_zuiskind") == 100))
		|| (position == 11 && PlayerPrefs.GetInt("chosenname") == 0)) && shudderready){
			shudderready = false;
			StartCoroutine(Shuddering());
		}

		if(PlayerPrefs.GetInt("whichfightcursor") == 1){
			if(position == 1){
				rb2d.MovePosition(new Vector2(w1x, w1y));
				PlayerPrefs.SetInt("whosselected", 1);
				if(Input.GetKeyDown("space")){
					if(PlayerPrefs.GetInt("activetime_chelbo") == 1){
						PlayerPrefs.SetInt("whichfightcursor", 0);
						Instantiate(cursor_chelbo, new Vector2(transform.position.x - .265f,
						transform.position.y - .105f), Quaternion.identity);
					}
				}
				if(Input.GetKeyDown("right")){
					if(PlayerPrefs.GetInt("seq_elazar") != 0 && PlayerPrefs.GetInt("seq_elazar") != 100){
						position = 2;
					}
					else if(PlayerPrefs.GetInt("seq_komlin") != 0 && PlayerPrefs.GetInt("seq_komlin") != 100){
						position = 3;
					}
					else if(PlayerPrefs.GetInt("seq_machir") != 0 && PlayerPrefs.GetInt("seq_machir") != 100){
						position = 4;
					}
					else if(PlayerPrefs.GetInt("seq_meir") != 0 && PlayerPrefs.GetInt("seq_meir") != 100){
						position = 5;
					}
				}
				if(Input.GetKeyDown("down")){
					if(PlayerPrefs.GetInt("chosenname") != 0){
						position = 11;
					}
					else{
						position = 12;
					}
				}
			}
			else if(position == 2){
				rb2d.MovePosition(new Vector2(w2x, w2y));
				PlayerPrefs.SetInt("whosselected", 2);
				if(Input.GetKeyDown("space")){
					if(PlayerPrefs.GetInt("activetime_elazar") == 1){
						PlayerPrefs.SetInt("whichfightcursor", 0);
						Instantiate(cursor_elazar, new Vector2(transform.position.x - .265f,
						transform.position.y - .105f), Quaternion.identity);
					}
				}
				if(Input.GetKeyDown("left")){
					if(PlayerPrefs.GetInt("seq_chelbo") != 0 && PlayerPrefs.GetInt("seq_chelbo") != 100){
						position = 1;
					}
				}
				if(Input.GetKeyDown("right")){
					if(PlayerPrefs.GetInt("seq_komlin") != 0 && PlayerPrefs.GetInt("seq_komlin") != 100){
						position = 3;
					}
					else if(PlayerPrefs.GetInt("seq_machir") != 0 && PlayerPrefs.GetInt("seq_machir") != 100){
						position = 4;
					}
					else if(PlayerPrefs.GetInt("seq_meir") != 0 && PlayerPrefs.GetInt("seq_meir") != 100){
						position = 5;
					}
				}
				if(Input.GetKeyDown("down")){
					if(PlayerPrefs.GetInt("chosenname") != 0){
						position = 11;
					}
					else{
						position = 12;
					}
				}
			}
			else if(position == 3){
				rb2d.MovePosition(new Vector2(w3x, w3y));
				PlayerPrefs.SetInt("whosselected", 3);
				if(Input.GetKeyDown("space")){
					if(PlayerPrefs.GetInt("activetime_komlin") == 1){
						PlayerPrefs.SetInt("whichfightcursor", 0);
						Instantiate(cursor_komlin, new Vector2(transform.position.x - .265f,
						transform.position.y - .105f), Quaternion.identity);
					}
				}
				if(Input.GetKeyDown("left")){
					if(PlayerPrefs.GetInt("seq_elazar") != 0 && PlayerPrefs.GetInt("seq_elazar") != 100){
						position = 2;
					}
					else if(PlayerPrefs.GetInt("seq_chelbo") != 0 && PlayerPrefs.GetInt("seq_chelbo") != 100){
						position = 1;
					}
				}
				if(Input.GetKeyDown("right")){
					if(PlayerPrefs.GetInt("seq_machir") != 0 && PlayerPrefs.GetInt("seq_machir") != 100){
						position = 4;
					}
					else if(PlayerPrefs.GetInt("seq_meir") != 0 && PlayerPrefs.GetInt("seq_meir") != 100){
						position = 5;
					}
				}
				if(Input.GetKeyDown("down")){
					if(PlayerPrefs.GetInt("chosenname") != 0){
						position = 11;
					}
					else{
						position = 12;
					}
				}
			}
			else if(position == 4){
				rb2d.MovePosition(new Vector2(w4x, w4y));
				PlayerPrefs.SetInt("whosselected", 4);
				if(Input.GetKeyDown("space")){
					if(PlayerPrefs.GetInt("activetime_machir") == 1){
						PlayerPrefs.SetInt("whichfightcursor", 0);
						Instantiate(cursor_machir, new Vector2(transform.position.x - .265f,
						transform.position.y - .105f), Quaternion.identity);
					}
				}
				if(Input.GetKeyDown("left")){
					if(PlayerPrefs.GetInt("seq_komlin") != 0 && PlayerPrefs.GetInt("seq_komlin") != 100){
						position = 3;
					}
					else if(PlayerPrefs.GetInt("seq_elazar") != 0 && PlayerPrefs.GetInt("seq_elazar") != 100){
						position = 2;
					}
					else if(PlayerPrefs.GetInt("seq_chelbo") != 0 && PlayerPrefs.GetInt("seq_chelbo") != 100){
						position = 1;
					}
				}
				if(Input.GetKeyDown("right")){
					if(PlayerPrefs.GetInt("seq_meir") != 0 && PlayerPrefs.GetInt("seq_meir") != 100){
						position = 5;
					}
				}
				if(Input.GetKeyDown("down")){
					if(PlayerPrefs.GetInt("chosenname") != 0){
						position = 11;
					}
					else{
						position = 12;
					}
				}
			}
			else if(position == 5){
				rb2d.MovePosition(new Vector2(w5x, w5y));
				PlayerPrefs.SetInt("whosselected", 5);
				if(Input.GetKeyDown("space")){
					if(PlayerPrefs.GetInt("activetime_meir") == 1){
						PlayerPrefs.SetInt("whichfightcursor", 0);
						Instantiate(cursor_meir, new Vector2(transform.position.x - .265f,
						transform.position.y - .105f), Quaternion.identity);
					}
				}
				if(Input.GetKeyDown("left")){
					if(PlayerPrefs.GetInt("seq_machir") != 0 && PlayerPrefs.GetInt("seq_machir") != 100){
						position = 4;
					}
					else if(PlayerPrefs.GetInt("seq_komlin") != 0 && PlayerPrefs.GetInt("seq_komlin") != 100){
						position = 3;
					}
					else if(PlayerPrefs.GetInt("seq_elazar") != 0 && PlayerPrefs.GetInt("seq_elazar") != 100){
						position = 2;
					}
					else if(PlayerPrefs.GetInt("seq_chelbo") != 0 && PlayerPrefs.GetInt("seq_chelbo") != 100){
						position = 1;
					}
				}
				if(Input.GetKeyDown("right")){
					if(PlayerPrefs.GetInt("seq_meir") != 0 && PlayerPrefs.GetInt("seq_meir") != 100){
						position = 5;
					}
				}
				if(Input.GetKeyDown("down")){
					if(PlayerPrefs.GetInt("chosenname") != 0){
						position = 11;
					}
					else{
						position = 12;
					}
				}
			}
			else if(position == 6){
				rb2d.MovePosition(new Vector2(w6x, w6y));
				PlayerPrefs.SetInt("whosselected", 6);
				if(Input.GetKeyDown("space")){
					if(PlayerPrefs.GetInt("activetime_natronai") == 1){
						PlayerPrefs.SetInt("whichfightcursor", 0);
						Instantiate(cursor_natronai, new Vector2(transform.position.x - .265f,
						transform.position.y - .105f), Quaternion.identity);
					}
				}
				if(Input.GetKeyDown("right")){
					if(PlayerPrefs.GetInt("seq_shabsai") != 0 && PlayerPrefs.GetInt("seq_shabsai") != 100){
						position = 7;
					}
					else if(PlayerPrefs.GetInt("seq_sulam") != 0 && PlayerPrefs.GetInt("seq_sulam") != 100){
						position = 8;
					}
					else if(PlayerPrefs.GetInt("seq_uri") != 0 && PlayerPrefs.GetInt("seq_uri") != 100){
						position = 9;
					}
					else if(PlayerPrefs.GetInt("seq_zuiskind") != 0 && PlayerPrefs.GetInt("seq_zuiskind") != 100){
						position = 10;
					}
				}
				if(Input.GetKeyDown("up")){
					position = 12;
				}
			}
			else if(position == 7){
				rb2d.MovePosition(new Vector2(w7x, w7y));
				PlayerPrefs.SetInt("whosselected", 7);
				if(Input.GetKeyDown("space")){
					if(PlayerPrefs.GetInt("activetime_shabsai") == 1){
						PlayerPrefs.SetInt("whichfightcursor", 0);
						Instantiate(cursor_shabsai, new Vector2(transform.position.x - .265f,
						transform.position.y - .105f), Quaternion.identity);
					}
				}
				if(Input.GetKeyDown("left")){
					if(PlayerPrefs.GetInt("seq_natronai") != 0 && PlayerPrefs.GetInt("seq_natronai") != 100){
						position = 6;
					}
				}
				if(Input.GetKeyDown("right")){
					if(PlayerPrefs.GetInt("seq_sulam") != 0 && PlayerPrefs.GetInt("seq_sulam") != 100){
						position = 8;
					}
					else if(PlayerPrefs.GetInt("seq_uri") != 0 && PlayerPrefs.GetInt("seq_uri") != 100){
						position = 9;
					}
					else if(PlayerPrefs.GetInt("seq_zuiskind") != 0 && PlayerPrefs.GetInt("seq_zuiskind") != 100){
						position = 10;
					}
				}
				if(Input.GetKeyDown("up")){
					position = 12;
				}
			}
			else if(position == 8){
				rb2d.MovePosition(new Vector2(w8x, w8y));
				PlayerPrefs.SetInt("whosselected", 8);
				if(Input.GetKeyDown("space")){
					if(PlayerPrefs.GetInt("activetime_sulam") == 1){
						PlayerPrefs.SetInt("whichfightcursor", 0);
						Instantiate(cursor_sulam, new Vector2(transform.position.x - .265f,
						transform.position.y - .105f), Quaternion.identity);
					}
				}
				if(Input.GetKeyDown("left")){
					if(PlayerPrefs.GetInt("seq_shabsai") != 0 && PlayerPrefs.GetInt("seq_shabsai") != 100){
						position = 7;
					}
					else if(PlayerPrefs.GetInt("seq_natronai") != 0 && PlayerPrefs.GetInt("seq_natronai") != 100){
						position = 6;
					}
				}
				if(Input.GetKeyDown("right")){
					if(PlayerPrefs.GetInt("seq_uri") != 0 && PlayerPrefs.GetInt("seq_uri") != 100){
						position = 9;
					}
					else if(PlayerPrefs.GetInt("seq_zuiskind") != 0 && PlayerPrefs.GetInt("seq_zuiskind") != 100){
						position = 10;
					}
				}
				if(Input.GetKeyDown("up")){
					position = 12;
				}
			}
			else if(position == 9){
				rb2d.MovePosition(new Vector2(w9x, w9y));
				PlayerPrefs.SetInt("whosselected", 9);
				if(Input.GetKeyDown("space")){
					if(PlayerPrefs.GetInt("activetime_uri") == 1){
						PlayerPrefs.SetInt("whichfightcursor", 0);
						Instantiate(cursor_uri, new Vector2(transform.position.x - .265f,
						transform.position.y - .105f), Quaternion.identity);
					}
				}
				if(Input.GetKeyDown("left")){
					if(PlayerPrefs.GetInt("seq_sulam") != 0 && PlayerPrefs.GetInt("seq_sulam") != 100){
						position = 8;
					}
					else if(PlayerPrefs.GetInt("seq_shabsai") != 0 && PlayerPrefs.GetInt("seq_shabsai") != 100){
						position = 7;
					}
					else if(PlayerPrefs.GetInt("seq_natronai") != 0 && PlayerPrefs.GetInt("seq_natronai") != 100){
						position = 6;
					}
				}
				if(Input.GetKeyDown("right")){
					if(PlayerPrefs.GetInt("seq_zuiskind") != 0 && PlayerPrefs.GetInt("seq_zuiskind") != 100){
						position = 10;
					}
				}
				if(Input.GetKeyDown("up")){
					position = 12;
				}
			}
			else if(position == 10){
				rb2d.MovePosition(new Vector2(w10x, w10y));
				PlayerPrefs.SetInt("whosselected", 10);
				if(Input.GetKeyDown("space")){
					if(PlayerPrefs.GetInt("activetime_zuiskind") == 1){
						PlayerPrefs.SetInt("whichfightcursor", 0);
						Instantiate(cursor_zuiskind, new Vector2(transform.position.x - .265f,
						transform.position.y - .105f), Quaternion.identity);
					}
				}
				if(Input.GetKeyDown("left")){
					if(PlayerPrefs.GetInt("seq_uri") != 0 && PlayerPrefs.GetInt("seq_uri") != 100){
						position = 9;
					}
					else if(PlayerPrefs.GetInt("seq_sulam") != 0 && PlayerPrefs.GetInt("seq_sulam") != 100){
						position = 8;
					}
					else if(PlayerPrefs.GetInt("seq_shabsai") != 0 && PlayerPrefs.GetInt("seq_shabsai") != 100){
						position = 7;
					}
					else if(PlayerPrefs.GetInt("seq_natronai") != 0 && PlayerPrefs.GetInt("seq_natronai") != 100){
						position = 6;
					}
				}
				if(Input.GetKeyDown("up")){
					position = 12;
				}
			}
			else if(position == 11){
				rb2d.MovePosition(new Vector2(w11x, w11y));
				PlayerPrefs.SetInt("whosselected", 11);
				if(Input.GetKeyDown("space")){
					if(PlayerPrefs.GetInt("activetime_golem") == 1){
						PlayerPrefs.SetInt("whichfightcursor", 0);
						Instantiate(cursor_golem, new Vector2(transform.position.x - .265f,
						transform.position.y - .105f), Quaternion.identity);
					}
				}
				if(Input.GetKeyDown("up")){
					if(PlayerPrefs.GetInt("seq_meir") != 0 && PlayerPrefs.GetInt("seq_meir") != 100){
						position = 5;
					}
					else if(PlayerPrefs.GetInt("seq_machir") != 0 && PlayerPrefs.GetInt("seq_machir") != 100){
						position = 4;
					}
					else if(PlayerPrefs.GetInt("seq_komlin") != 0 && PlayerPrefs.GetInt("seq_komlin") != 100){
						position = 3;
					}
					else if(PlayerPrefs.GetInt("seq_elazar") != 0 && PlayerPrefs.GetInt("seq_elazar") != 100){
						position = 2;
					}
					else if(PlayerPrefs.GetInt("seq_chelbo") != 0 && PlayerPrefs.GetInt("seq_chelbo") != 100){
						position = 1;
					}
				}
				if(Input.GetKeyDown("down")){
					position = 12;
				}
			}
			else if(position == 12){
				rb2d.MovePosition(new Vector2(w12x, w12y));
				PlayerPrefs.SetInt("whosselected", 12);
				if(Input.GetKeyDown("space")){
					if(PlayerPrefs.GetInt("activetime_hero") == 1){
						PlayerPrefs.SetInt("whichfightcursor", 0);
						Instantiate(cursor_hero, new Vector2(transform.position.x - .265f,
						transform.position.y - .105f), Quaternion.identity);
					}
				}
				if(Input.GetKeyDown("down")){
					if(PlayerPrefs.GetInt("seq_natronai") != 0 && PlayerPrefs.GetInt("seq_natronai") != 100){
						position = 6;
					}
					else if(PlayerPrefs.GetInt("seq_shabsai") != 0 && PlayerPrefs.GetInt("seq_shabsai") != 100){
						position = 7;
					}
					else if(PlayerPrefs.GetInt("seq_sulam") != 0 && PlayerPrefs.GetInt("seq_sulam") != 100){
						position = 8;
					}
					else if(PlayerPrefs.GetInt("seq_uri") != 0 && PlayerPrefs.GetInt("seq_uri") != 100){
						position = 9;
					}
					else if(PlayerPrefs.GetInt("seq_zuiskind") != 0 && PlayerPrefs.GetInt("seq_zuiskind") != 100){
						position = 10;
					}
				}
				if(Input.GetKeyDown("up")){
					if(PlayerPrefs.GetInt("chosenname") != 0){
						position = 11;
					}
					else if(PlayerPrefs.GetInt("seq_meir") != 0 && PlayerPrefs.GetInt("seq_meir") != 100){
						position = 5;
					}
					else if(PlayerPrefs.GetInt("seq_machir") != 0 && PlayerPrefs.GetInt("seq_machir") != 100){
						position = 4;
					}
					else if(PlayerPrefs.GetInt("seq_komlin") != 0 && PlayerPrefs.GetInt("seq_komlin") != 100){
						position = 3;
					}
					else if(PlayerPrefs.GetInt("seq_elazar") != 0 && PlayerPrefs.GetInt("seq_elazar") != 100){
						position = 2;
					}
					else if(PlayerPrefs.GetInt("seq_chelbo") != 0 && PlayerPrefs.GetInt("seq_chelbo") != 100){
						position = 1;
					}
				}
			}
		}
	}

	IEnumerator Shuddering(){
		rb2d.MovePosition(new Vector2(transform.position.x - .02f, transform.position.y));
		yield return new WaitForSeconds(.1f);
		rb2d.MovePosition(new Vector2(transform.position.x + .04f, transform.position.y));
		yield return new WaitForSeconds(.1f);
		rb2d.MovePosition(new Vector2(transform.position.x - .02f, transform.position.y));
		shudderready = true;
	}
}
