using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restwait : MonoBehaviour {

	//default controls rest/wait menu
	//"prayer" sets to pray/wait menu
	//(sorry i didnt name this more generally just "menus" >___>)

	Rigidbody2D rb2d;
	int position = 1;
	bool begin = true;
	public bool prayer, hone, work, look;
	public GameObject fade, dialogue, switchsfx, waitsfx;
	public float diax, diay = 2.75f;

	void Update () {
		if(begin){
			begin = false;
			rb2d = GetComponent<Rigidbody2D> ();
			PlayerPrefs.SetInt("frozen", 1);
		}
		if(position == 1){
			//rest
			rb2d.MovePosition(new Vector2(transform.parent.position.x,
			transform.parent.position.y + 0.055f));
			if(Input.GetKeyDown("down")){
				position = 2;
				Instantiate(switchsfx, transform.position, Quaternion.identity);
			}
			if(Input.GetKeyDown("space")){
				if(prayer){
					Instantiate(dialogue, new Vector2(diax, diay), Quaternion.identity);
					PlayerPrefs.SetInt("timesprayed", (PlayerPrefs.GetInt("timesprayed") + 1));
				}
				else if(hone){
					Instantiate(dialogue, new Vector2(diax, diay), Quaternion.identity);
					if(PlayerPrefs.GetInt("hero_atk") < 6){
						PlayerPrefs.SetInt("hero_atk", PlayerPrefs.GetInt("hero_atk") + 1);
					}
				}
				else if(work){
					Instantiate(dialogue, new Vector2(diax, diay), Quaternion.identity);
					if(PlayerPrefs.GetInt("hero_def") < 6){
						PlayerPrefs.SetInt("hero_def", PlayerPrefs.GetInt("hero_def") + 1);
					}
				}
				else if(look){
					Instantiate(dialogue, new Vector2(diax, diay), Quaternion.identity);
				}
				else{
					PlayerPrefs.SetInt("fighttime", 1);
				}
				Destroy(transform.parent.gameObject);
			}
		}

		if(position == 2){
			//wait
			rb2d.MovePosition(new Vector2(transform.parent.position.x,
			transform.parent.position.y - 0.035f));
			if(Input.GetKeyDown("up")){
				position = 1;
				Instantiate(switchsfx, transform.position, Quaternion.identity);
			}
			if(Input.GetKeyDown("space")){
				Instantiate(fade, transform.parent.position, Quaternion.identity);
				Instantiate(waitsfx, transform.position, Quaternion.identity);
				PlayerPrefs.SetInt("frozen", 0);
				Destroy(transform.parent.gameObject);
			}
		}
	}
}
