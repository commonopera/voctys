using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class namemixcursor : MonoBehaviour {

	//navigate and control synthesis menu
	//validity of combinations set by mix_library script

	Rigidbody2D rb2d;
	int position = 1, i, whichselectedl, whichselectedr;
	int [] inventory;
	public float leftx, lefty, mixx, mixy, waitx, waity, rightx, righty, diax, diay;
	bool begin = true, repeat = true;
	public GameObject approval, rejection, switchsfx, nameswitchsfx, denysound, waitsfx;

	void Update () {
		if(begin){
			begin = false;
			PlayerPrefs.SetInt("frozen", 1);
			rb2d = GetComponent<Rigidbody2D> ();
			if(PlayerPrefs.GetInt("sacrednames") == 0){
				PlayerPrefs.SetInt("leftmix", 0);
				PlayerPrefs.SetInt("rightmix", 0);
				position = 2;
			}
			inventory = new int[PlayerPrefs.GetInt("sacrednames")];
			i = 0;
		}
		if(repeat){
			repeat = false;
			if(i < PlayerPrefs.GetInt("sacrednames")){
				if(PlayerPrefs.GetInt("name1") == 1 && System.Array.IndexOf(inventory, 1) == -1){
					inventory[i] = 1;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name2") == 1 && System.Array.IndexOf(inventory, 2) == -1){
					inventory[i] = 2;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name3") == 1 && System.Array.IndexOf(inventory, 3) == -1){
					inventory[i] = 3;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name4") == 1 && System.Array.IndexOf(inventory, 4) == -1){
					inventory[i] = 4;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name5") == 1 && System.Array.IndexOf(inventory, 5) == -1){
					inventory[i] = 5;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name6") == 1 && System.Array.IndexOf(inventory, 6) == -1){
					inventory[i] = 6;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name7") == 1 && System.Array.IndexOf(inventory, 7) == -1){
					inventory[i] = 7;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name8") == 1 && System.Array.IndexOf(inventory, 8) == -1){
					inventory[i] = 8;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name9") == 1 && System.Array.IndexOf(inventory, 9) == -1){
					inventory[i] = 9;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name10") == 1 && System.Array.IndexOf(inventory, 10) == -1){
					inventory[i] = 10;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name11") == 1 && System.Array.IndexOf(inventory, 11) == -1){
					inventory[i] = 11;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name12") == 1 && System.Array.IndexOf(inventory, 12) == -1){
					inventory[i] = 12;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name13") == 1 && System.Array.IndexOf(inventory, 13) == -1){
					inventory[i] = 13;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name14") == 1 && System.Array.IndexOf(inventory, 14) == -1){
					inventory[i] = 14;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name15") == 1 && System.Array.IndexOf(inventory, 15) == -1){
					inventory[i] = 15;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name16") == 1 && System.Array.IndexOf(inventory, 16) == -1){
					inventory[i] = 16;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name17") == 1 && System.Array.IndexOf(inventory, 17) == -1){
					inventory[i] = 17;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name18") == 1 && System.Array.IndexOf(inventory, 18) == -1){
					inventory[i] = 18;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name19") == 1 && System.Array.IndexOf(inventory, 19) == -1){
					inventory[i] = 19;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name20") == 1 && System.Array.IndexOf(inventory, 20) == -1){
					inventory[i] = 20;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name21") == 1 && System.Array.IndexOf(inventory, 21) == -1){
					inventory[i] = 21;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name22") == 1 && System.Array.IndexOf(inventory, 22) == -1){
					inventory[i] = 22;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name23") == 1 && System.Array.IndexOf(inventory, 23) == -1){
					inventory[i] = 23;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name24") == 1 && System.Array.IndexOf(inventory, 24) == -1){
					inventory[i] = 24;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name25") == 1 && System.Array.IndexOf(inventory, 25) == -1){
					inventory[i] = 25;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name26") == 1 && System.Array.IndexOf(inventory, 26) == -1){
					inventory[i] = 26;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name27") == 1 && System.Array.IndexOf(inventory, 27) == -1){
					inventory[i] = 27;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name28") == 1 && System.Array.IndexOf(inventory, 28) == -1){
					inventory[i] = 28;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name29") == 1 && System.Array.IndexOf(inventory, 29) == -1){
					inventory[i] = 29;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name30") == 1 && System.Array.IndexOf(inventory, 30) == -1){
					inventory[i] = 30;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name31") == 1 && System.Array.IndexOf(inventory, 31) == -1){
					inventory[i] = 31;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name32") == 1 && System.Array.IndexOf(inventory, 32) == -1){
					inventory[i] = 32;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name33") == 1 && System.Array.IndexOf(inventory, 33) == -1){
					inventory[i] = 33;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name34") == 1 && System.Array.IndexOf(inventory, 34) == -1){
					inventory[i] = 34;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name35") == 1 && System.Array.IndexOf(inventory, 35) == -1){
					inventory[i] = 35;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name36") == 1 && System.Array.IndexOf(inventory, 36) == -1){
					inventory[i] = 36;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name37") == 1 && System.Array.IndexOf(inventory, 37) == -1){
					inventory[i] = 37;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name38") == 1 && System.Array.IndexOf(inventory, 38) == -1){
					inventory[i] = 38;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name39") == 1 && System.Array.IndexOf(inventory, 39) == -1){
					inventory[i] = 39;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name40") == 1 && System.Array.IndexOf(inventory, 40) == -1){
					inventory[i] = 40;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name41") == 1 && System.Array.IndexOf(inventory, 41) == -1){
					inventory[i] = 41;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name42") == 1 && System.Array.IndexOf(inventory, 42) == -1){
					inventory[i] = 42;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name43") == 1 && System.Array.IndexOf(inventory, 43) == -1){
					inventory[i] = 43;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name44") == 1 && System.Array.IndexOf(inventory, 44) == -1){
					inventory[i] = 44;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name45") == 1 && System.Array.IndexOf(inventory, 45) == -1){
					inventory[i] = 45;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name46") == 1 && System.Array.IndexOf(inventory, 46) == -1){
					inventory[i] = 46;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name47") == 1 && System.Array.IndexOf(inventory, 47) == -1){
					inventory[i] = 47;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name48") == 1 && System.Array.IndexOf(inventory, 48) == -1){
					inventory[i] = 48;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name49") == 1 && System.Array.IndexOf(inventory, 49) == -1){
					inventory[i] = 49;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name50") == 1 && System.Array.IndexOf(inventory, 50) == -1){
					inventory[i] = 50;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name51") == 1 && System.Array.IndexOf(inventory, 51) == -1){
					inventory[i] = 51;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name52") == 1 && System.Array.IndexOf(inventory, 52) == -1){
					inventory[i] = 52;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name53") == 1 && System.Array.IndexOf(inventory, 53) == -1){
					inventory[i] = 53;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name54") == 1 && System.Array.IndexOf(inventory, 54) == -1){
					inventory[i] = 54;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name55") == 1 && System.Array.IndexOf(inventory, 55) == -1){
					inventory[i] = 55;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name56") == 1 && System.Array.IndexOf(inventory, 56) == -1){
					inventory[i] = 56;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name57") == 1 && System.Array.IndexOf(inventory, 57) == -1){
					inventory[i] = 57;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name58") == 1 && System.Array.IndexOf(inventory, 58) == -1){
					inventory[i] = 58;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name59") == 1 && System.Array.IndexOf(inventory, 59) == -1){
					inventory[i] = 59;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name60") == 1 && System.Array.IndexOf(inventory, 60) == -1){
					inventory[i] = 60;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name61") == 1 && System.Array.IndexOf(inventory, 61) == -1){
					inventory[i] = 61;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name62") == 1 && System.Array.IndexOf(inventory, 62) == -1){
					inventory[i] = 62;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name63") == 1 && System.Array.IndexOf(inventory, 63) == -1){
					inventory[i] = 63;
					i += 1;
					repeat = true;
				}
				else if(PlayerPrefs.GetInt("name64") == 1 && System.Array.IndexOf(inventory, 64) == -1){
					inventory[i] = 64;
					i += 1;
					repeat = true;
				}
			}
			else if (PlayerPrefs.GetInt("sacrednames") == 1){
				PlayerPrefs.SetInt("leftmix", inventory[0]);
				PlayerPrefs.SetInt("rightmix", inventory[0]);
				whichselectedl = 0;
				whichselectedr = 0;
			}
			else if (PlayerPrefs.GetInt("sacrednames") > 1){
				PlayerPrefs.SetInt("leftmix", inventory[0]);
				PlayerPrefs.SetInt("rightmix", inventory[1]);
				whichselectedl = 0;
				whichselectedr = 1;
			}
		}
		if(position == 1){
			//leftmix
			rb2d.MovePosition(new Vector2(transform.parent.position.x + leftx,
			transform.parent.position.y + lefty));
			if(Input.GetKeyDown("right")){
				position = 2;
				Instantiate(switchsfx, transform.position, Quaternion.identity);
			}
			if(Input.GetKeyDown("down")){
				whichselectedl += 1;
				if(whichselectedl >= PlayerPrefs.GetInt("sacrednames")){
					whichselectedl = 0;
				}
				PlayerPrefs.SetInt("leftmix", inventory[whichselectedl]);
				Instantiate(nameswitchsfx, transform.position, Quaternion.identity);
			}
			if(Input.GetKeyDown("up")){
				whichselectedl -= 1;
				if(whichselectedl < 0){
					whichselectedl = PlayerPrefs.GetInt("sacrednames") - 1;
				}
				PlayerPrefs.SetInt("leftmix", inventory[whichselectedl]);
				Instantiate(nameswitchsfx, transform.position, Quaternion.identity);
			}
			if(Input.GetKeyDown("space")){
				////////////////////NOTHING HAPPENS
			}
		}
		else if(position == 2){
			//mix
			rb2d.MovePosition(new Vector2(transform.parent.position.x + mixx,
			transform.parent.position.y + mixy));
			if(Input.GetKeyDown("left") && PlayerPrefs.GetInt("sacrednames") != 0){
				position = 1;
				Instantiate(switchsfx, transform.position, Quaternion.identity);
			}
			if(Input.GetKeyDown("right") && PlayerPrefs.GetInt("sacrednames") != 0){
				position = 4;
				Instantiate(switchsfx, transform.position, Quaternion.identity);
			}
			if(Input.GetKeyDown("down")){
				position = 3;
				Instantiate(switchsfx, transform.position, Quaternion.identity);
			}
			if(Input.GetKeyDown("space")){
				if(PlayerPrefs.GetInt("sacrednames") > 0){
					if(PlayerPrefs.GetInt("mixable") == 1){
						PlayerPrefs.SetInt("sacrednames", (PlayerPrefs.GetInt("sacrednames") - 1));
						PlayerPrefs.SetInt(("name" + PlayerPrefs.GetInt("leftmix").ToString()), 0);
						PlayerPrefs.SetInt(("name" + PlayerPrefs.GetInt("rightmix").ToString()), 0);
						PlayerPrefs.SetInt(("name" + PlayerPrefs.GetInt("mixproduct").ToString()), 1);
						PlayerPrefs.SetInt("screenclear", 1);
						Instantiate(approval, new Vector2(diax, diay), Quaternion.identity);
					}
					else{
						PlayerPrefs.SetInt("screenclear", 1);
						Instantiate(rejection, new Vector2(diax, diay), Quaternion.identity);
					}
				}
				else{
					Instantiate(denysound, transform.position, Quaternion.identity);
				}
			}
		}
		else if(position == 3){
			//wait
			rb2d.MovePosition(new Vector2(transform.parent.position.x + waitx,
			transform.parent.position.y + waity));
			if(Input.GetKeyDown("left") && PlayerPrefs.GetInt("sacrednames") != 0){
				position = 1;
				Instantiate(switchsfx, transform.position, Quaternion.identity);
			}
			if(Input.GetKeyDown("right") && PlayerPrefs.GetInt("sacrednames") != 0){
				position = 4;
				Instantiate(switchsfx, transform.position, Quaternion.identity);
			}
			if(Input.GetKeyDown("up")){
				position = 2;
				Instantiate(switchsfx, transform.position, Quaternion.identity);
			}
			if(Input.GetKeyDown("space")){
				Instantiate(waitsfx, transform.position, Quaternion.identity);
				PlayerPrefs.SetInt("screenclear", 1);
				PlayerPrefs.SetInt("frozen", 0);
			}
		}
		else if(position == 4){
			//rightmix
			rb2d.MovePosition(new Vector2(transform.parent.position.x + rightx,
			transform.parent.position.y + righty));
			if(Input.GetKeyDown("left")){
				position = 2;
				Instantiate(switchsfx, transform.position, Quaternion.identity);
			}
			if(Input.GetKeyDown("down")){
				whichselectedr += 1;
				if(whichselectedr >= PlayerPrefs.GetInt("sacrednames")){
					whichselectedr = 0;
				}
				PlayerPrefs.SetInt("rightmix", inventory[whichselectedr]);
				Instantiate(nameswitchsfx, transform.position, Quaternion.identity);
			}
			if(Input.GetKeyDown("up")){
				whichselectedr -= 1;
				if(whichselectedr < 0){
					whichselectedr = PlayerPrefs.GetInt("sacrednames") - 1;
				}
				PlayerPrefs.SetInt("rightmix", inventory[whichselectedr]);
				Instantiate(nameswitchsfx, transform.position, Quaternion.identity);
			}
			if(Input.GetKeyDown("space")){
				////////////////////NOTHING HAPPENS
			}
		}
	}
}
