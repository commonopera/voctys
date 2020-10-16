using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class take_object : MonoBehaviour {

	//take object, destroy object on start if its already been taken
	//(also handles other objects which are supposed to appear or disappear at certain points)

	public GameObject fade, text, bettertext;
	GameObject newboy;
	public float textx, texty;
	public bool gem1, gem2, gem3, gem4, gem5, natronaihalo, water, soup, eggbook, soot,
	starbook, apples, oats, chestnuts, honey, spirits, jewelr, jewely, jewelb, decoration;
	bool inZone = false;
	SpriteRenderer Render, ParentRender, NewRenderer;

	void Start () {
		if(gem1){
			if(PlayerPrefs.GetInt("gem1taken") == 1){
				Destroy(gameObject);
			}
		}
		if(gem2){
			if(PlayerPrefs.GetInt("gem2taken") == 1){
				Destroy(gameObject);
			}
		}
		if(gem3){
			if(PlayerPrefs.GetInt("gem3taken") == 1){
				Destroy(gameObject);
			}
		}
		if(gem4){
			if(PlayerPrefs.GetInt("gem4taken") == 1){
				Destroy(gameObject);
			}
		}
		if(gem5){
			if(PlayerPrefs.GetInt("gem5taken") == 1){
				Destroy(gameObject);
			}
		}
		if(water){
			if(PlayerPrefs.GetInt("seq_chelbo") >= 9){
				Destroy(gameObject);
			}
			Render = GetComponent<SpriteRenderer>();
			ParentRender = gameObject.transform.parent.GetComponent<SpriteRenderer>();
		}
		if(soup){
			if(PlayerPrefs.GetInt("seq_chelbo") >= 11){
				Destroy(gameObject);
			}
			Render = GetComponent<SpriteRenderer>();
			ParentRender = gameObject.transform.parent.GetComponent<SpriteRenderer>();
		}
		if(eggbook){
			if(PlayerPrefs.GetInt("seq_chelbo") >= 13){
				Destroy(gameObject);
			}
			Render = GetComponent<SpriteRenderer>();
			ParentRender = gameObject.transform.parent.GetComponent<SpriteRenderer>();
		}
		if(soot){
			if(PlayerPrefs.GetInt("seq_chelbo") >= 21){
				Destroy(gameObject);
			}
			Render = GetComponent<SpriteRenderer>();
		}
		if(starbook){
			if(PlayerPrefs.GetInt("seq_meir") >= 70){
				Destroy(gameObject);
			}
			Render = GetComponent<SpriteRenderer>();
			ParentRender = gameObject.transform.parent.GetComponent<SpriteRenderer>();
		}
		if(apples){
			if(PlayerPrefs.GetInt("applestaken") == 1){
				Destroy(gameObject);
			}
			Render = GetComponent<SpriteRenderer>();
			ParentRender = gameObject.transform.parent.GetComponent<SpriteRenderer>();
		}
		if(oats){
			if(PlayerPrefs.GetInt("oatstaken") == 1){
				Destroy(gameObject);
			}
			Render = GetComponent<SpriteRenderer>();
			ParentRender = gameObject.transform.parent.GetComponent<SpriteRenderer>();
		}
		if(chestnuts){
			if(PlayerPrefs.GetInt("chestnutstaken") == 1){
				Destroy(gameObject);
			}
			Render = GetComponent<SpriteRenderer>();
			ParentRender = gameObject.transform.parent.GetComponent<SpriteRenderer>();
		}
		if(honey){
			if(PlayerPrefs.GetInt("honeytaken") == 1){
				Destroy(gameObject);
			}
			Render = GetComponent<SpriteRenderer>();
			ParentRender = gameObject.transform.parent.GetComponent<SpriteRenderer>();
		}
		if(spirits){
			if(PlayerPrefs.GetInt("seq_machir") >= 12){
				Destroy(gameObject);
			}
			Render = GetComponent<SpriteRenderer>();
			ParentRender = gameObject.transform.parent.GetComponent<SpriteRenderer>();
		}
		if(jewelr){
			if(PlayerPrefs.GetInt("jewelrtaken") == 1){
				Destroy(gameObject);
			}
			Render = GetComponent<SpriteRenderer>();
			ParentRender = gameObject.transform.parent.GetComponent<SpriteRenderer>();
		}
		if(jewely){
			if(PlayerPrefs.GetInt("jewelytaken") == 1){
				Destroy(gameObject);
			}
			Render = GetComponent<SpriteRenderer>();
			ParentRender = gameObject.transform.parent.GetComponent<SpriteRenderer>();
		}
		if(jewelb){
			if(PlayerPrefs.GetInt("jewelbtaken") == 1){
				Destroy(gameObject);
			}
			Render = GetComponent<SpriteRenderer>();
			ParentRender = gameObject.transform.parent.GetComponent<SpriteRenderer>();
		}
		if(decoration){
			Render = GetComponent<SpriteRenderer>();
			ParentRender = gameObject.transform.parent.GetComponent<SpriteRenderer>();
		}
	}

	void Update () {
		if(natronaihalo){
			if(PlayerPrefs.GetInt("seq_natronai") > 50){
				Destroy(gameObject);
			}
		}
		if((water || soup || eggbook || starbook || apples || chestnuts || honey || spirits
		|| jewelb || jewelr || jewely || decoration) && ParentRender
		&& Render.sortingOrder != ParentRender.sortingOrder){
			Render.sortingOrder = ParentRender.sortingOrder;
		}
		if(inZone && Input.GetKeyDown("space")){
			if(gem1){
				Instantiate(text, new Vector2(textx, texty), Quaternion.identity);
				PlayerPrefs.SetInt("name1", 1);
				PlayerPrefs.SetInt("sacrednames", (PlayerPrefs.GetInt("sacrednames") + 1));
				PlayerPrefs.SetInt("gem1taken", 1);
				Instantiate(fade, transform.position, Quaternion.identity);
				Destroy(gameObject);
			}
			if(gem2){
				Instantiate(text, new Vector2(textx, texty), Quaternion.identity);
				PlayerPrefs.SetInt("name2", 1);
				PlayerPrefs.SetInt("sacrednames", (PlayerPrefs.GetInt("sacrednames") + 1));
				PlayerPrefs.SetInt("gem2taken", 1);
				Instantiate(fade, transform.position, Quaternion.identity);
				Destroy(gameObject);
			}
			if(gem3){
				Instantiate(text, new Vector2(textx, texty), Quaternion.identity);
				PlayerPrefs.SetInt("name3", 1);
				PlayerPrefs.SetInt("sacrednames", (PlayerPrefs.GetInt("sacrednames") + 1));
				PlayerPrefs.SetInt("gem3taken", 1);
				Instantiate(fade, transform.position, Quaternion.identity);
				Destroy(gameObject);
			}
			if(gem4){
				Instantiate(text, new Vector2(textx, texty), Quaternion.identity);
				PlayerPrefs.SetInt("name4", 1);
				PlayerPrefs.SetInt("sacrednames", (PlayerPrefs.GetInt("sacrednames") + 1));
				PlayerPrefs.SetInt("gem4taken", 1);
				Instantiate(fade, transform.position, Quaternion.identity);
				Destroy(gameObject);
			}
			if(gem5){
				Instantiate(text, new Vector2(textx, texty), Quaternion.identity);
				PlayerPrefs.SetInt("name5", 1);
				PlayerPrefs.SetInt("sacrednames", (PlayerPrefs.GetInt("sacrednames") + 1));
				PlayerPrefs.SetInt("gem5taken", 1);
				Instantiate(fade, transform.position, Quaternion.identity);
				Destroy(gameObject);
			}
			if(water && PlayerPrefs.GetInt("frozen") != 1){
				if(PlayerPrefs.GetInt("seq_chelbo") == 7 || PlayerPrefs.GetInt("seq_chelbo") == 8){
					Instantiate(bettertext, new Vector2(textx, texty), Quaternion.identity);
					PlayerPrefs.SetInt("seq_chelbo", 9);
					CallFade();
				}
				else{
					Instantiate(text, new Vector2(textx, texty), Quaternion.identity);
				}
			}
			if(soup && PlayerPrefs.GetInt("frozen") != 1){
				if(PlayerPrefs.GetInt("seq_chelbo") == 9 || PlayerPrefs.GetInt("seq_chelbo") == 10){
					Instantiate(bettertext, new Vector2(textx, texty), Quaternion.identity);
					PlayerPrefs.SetInt("seq_chelbo", 11);
					CallFade();
				}
				else{
					Instantiate(text, new Vector2(textx, texty), Quaternion.identity);
				}
			}
			if(eggbook && PlayerPrefs.GetInt("frozen") != 1){
				if(PlayerPrefs.GetInt("seq_chelbo") == 11 || PlayerPrefs.GetInt("seq_chelbo") == 12){
					Instantiate(bettertext, new Vector2(textx, texty), Quaternion.identity);
					PlayerPrefs.SetInt("seq_chelbo", 13);
					CallFade();
				}
				else{
					Instantiate(text, new Vector2(textx, texty), Quaternion.identity);
				}
			}
			if(soot && PlayerPrefs.GetInt("frozen") != 1){
				if(PlayerPrefs.GetInt("seq_chelbo") == 18 || PlayerPrefs.GetInt("seq_chelbo") == 19
				|| PlayerPrefs.GetInt("seq_chelbo") == 20){
					Instantiate(bettertext, new Vector2(textx, texty), Quaternion.identity);
					PlayerPrefs.SetInt("seq_chelbo", 21);
					CallFade();
				}
				else{
					Instantiate(text, new Vector2(textx, texty), Quaternion.identity);
				}
			}
			if(starbook && PlayerPrefs.GetInt("frozen") != 1){
				if(PlayerPrefs.GetInt("seq_meir") == 52 || PlayerPrefs.GetInt("seq_meir") == 53
				|| PlayerPrefs.GetInt("seq_meir") == 54 || PlayerPrefs.GetInt("seq_meir") == 55
				|| PlayerPrefs.GetInt("seq_meir") == 56){
					Instantiate(bettertext, new Vector2(textx, texty), Quaternion.identity);
					PlayerPrefs.SetInt("seq_meir", 70);
					CallFade();
				}
				else{
					Instantiate(text, new Vector2(textx, texty), Quaternion.identity);
				}
			}
			if(apples && PlayerPrefs.GetInt("frozen") != 1){
				if(PlayerPrefs.GetInt("seq_machir") == 6 || PlayerPrefs.GetInt("seq_machir") == 7){
					Instantiate(bettertext, new Vector2(textx, texty), Quaternion.identity);
					PlayerPrefs.SetInt("applestaken", 1);
					if(PlayerPrefs.GetInt("oatstaken") == 1){
						PlayerPrefs.SetInt("seq_machir", 8);
					}
					CallFade();
				}
				else{
					Instantiate(text, new Vector2(textx, texty), Quaternion.identity);
				}
			}
			if(oats && PlayerPrefs.GetInt("frozen") != 1){
				if(PlayerPrefs.GetInt("seq_machir") == 6 || PlayerPrefs.GetInt("seq_machir") == 7){
					Instantiate(bettertext, new Vector2(textx, texty), Quaternion.identity);
					PlayerPrefs.SetInt("oatstaken", 1);
					if(PlayerPrefs.GetInt("applestaken") == 1){
						PlayerPrefs.SetInt("seq_machir", 8);
					}
					CallFade();
				}
				else{
					Instantiate(text, new Vector2(textx, texty), Quaternion.identity);
				}
			}
			if(chestnuts && PlayerPrefs.GetInt("frozen") != 1){
				if(PlayerPrefs.GetInt("seq_machir") == 8 || PlayerPrefs.GetInt("seq_machir") == 9){
					Instantiate(bettertext, new Vector2(textx, texty), Quaternion.identity);
					PlayerPrefs.SetInt("chestnutstaken", 1);
					if(PlayerPrefs.GetInt("honeytaken") == 1){
						PlayerPrefs.SetInt("seq_machir", 10);
					}
					CallFade();
				}
				else{
					Instantiate(text, new Vector2(textx, texty), Quaternion.identity);
				}
			}
			if(honey && PlayerPrefs.GetInt("frozen") != 1){
				if(PlayerPrefs.GetInt("seq_machir") == 8 || PlayerPrefs.GetInt("seq_machir") == 9){
					Instantiate(bettertext, new Vector2(textx, texty), Quaternion.identity);
					PlayerPrefs.SetInt("honeytaken", 1);
					if(PlayerPrefs.GetInt("chestnutstaken") == 1){
						PlayerPrefs.SetInt("seq_machir", 10);
					}
					CallFade();
				}
				else{
					Instantiate(text, new Vector2(textx, texty), Quaternion.identity);
				}
			}
			if(spirits && PlayerPrefs.GetInt("frozen") != 1){
				if(PlayerPrefs.GetInt("seq_machir") == 10 || PlayerPrefs.GetInt("seq_machir") == 11){
					Instantiate(bettertext, new Vector2(textx, texty), Quaternion.identity);
					PlayerPrefs.SetInt("seq_machir", 12);
					CallFade();
				}
				else{
					Instantiate(text, new Vector2(textx, texty), Quaternion.identity);
				}
			}
			if(jewelb && PlayerPrefs.GetInt("frozen") != 1){
				if(PlayerPrefs.GetInt("seq_sulam") == 53 || PlayerPrefs.GetInt("seq_sulam") == 54){
					Instantiate(bettertext, new Vector2(textx, texty), Quaternion.identity);
					PlayerPrefs.SetInt("jewelbtaken", 1);
					if(PlayerPrefs.GetInt("jewelrtaken") == 1 && PlayerPrefs.GetInt("jewelytaken") == 1){
						PlayerPrefs.SetInt("seq_sulam", 55);
					}
					CallFade();
				}
				else{
					Instantiate(text, new Vector2(textx, texty), Quaternion.identity);
				}
			}
			if(jewelr && PlayerPrefs.GetInt("frozen") != 1){
				if(PlayerPrefs.GetInt("seq_sulam") == 53 || PlayerPrefs.GetInt("seq_sulam") == 54){
					Instantiate(bettertext, new Vector2(textx, texty), Quaternion.identity);
					PlayerPrefs.SetInt("jewelrtaken", 1);
					if(PlayerPrefs.GetInt("jewelbtaken") == 1 && PlayerPrefs.GetInt("jewelytaken") == 1){
						PlayerPrefs.SetInt("seq_sulam", 55);
					}
					CallFade();
				}
				else{
					Instantiate(text, new Vector2(textx, texty), Quaternion.identity);
				}
			}
			if(jewely && PlayerPrefs.GetInt("frozen") != 1){
				if(PlayerPrefs.GetInt("seq_sulam") == 53 || PlayerPrefs.GetInt("seq_sulam") == 54){
					Instantiate(bettertext, new Vector2(textx, texty), Quaternion.identity);
					PlayerPrefs.SetInt("jewelytaken", 1);
					if(PlayerPrefs.GetInt("jewelrtaken") == 1 && PlayerPrefs.GetInt("jewelbtaken") == 1){
						PlayerPrefs.SetInt("seq_sulam", 55);
					}
					CallFade();
				}
				else{
					Instantiate(text, new Vector2(textx, texty), Quaternion.identity);
				}
			}
			if(decoration && PlayerPrefs.GetInt("frozen") != 1){
				Instantiate(text, new Vector2(textx, texty), Quaternion.identity);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "player"){
			inZone = true;
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if(col.gameObject.tag == "player"){
			inZone = false;
		}
	}

	void CallFade(){
		newboy = Instantiate(fade, transform.position, Quaternion.identity);
		NewRenderer = newboy.GetComponent<SpriteRenderer>();
		NewRenderer.sortingOrder = Render.sortingOrder;
		Destroy(gameObject);
	}
}
