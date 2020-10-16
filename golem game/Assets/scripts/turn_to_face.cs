using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn_to_face : MonoBehaviour {

	//ROTATES AN NPC TO FACE AVATAR WHEN SPACEBAR IS PRESSED FACING IT
	//also generates dialogue, maybe more important >___>
	//(check "dontturn" to disable the turning and only generate dialogue... <___<)

	SpriteRenderer rendering, childrendering;
	public GameObject dialogue, fade;
	public float diax, diay;
	public Sprite LU, RU, RD, LD;
	bool inZone, diareset;
	public bool fading, dontturn;
	GameObject fadechild;

	void Update () {
		if(inZone && Input.GetKeyDown("space")){
			if(PlayerPrefs.GetInt("frozen") != 1){
				PlayerPrefs.SetInt("frozen", 1);
				StartCoroutine (Turning());
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

	IEnumerator Turning(){
		yield return new WaitForSeconds(.1f);
		Instantiate(dialogue, new Vector2(transform.position.x + diax,
		transform.position.y + diay), Quaternion.identity, transform);
		yield return new WaitForSeconds(.2f);
		if(PlayerPrefs.GetInt("facing") == 1 && !dontturn){
			rendering = GetComponent <SpriteRenderer>();
			rendering.sprite = RU;
		}
		if(PlayerPrefs.GetInt("facing") == 2 && !dontturn){
			rendering = GetComponent <SpriteRenderer>();
			rendering.sprite = RD;
		}
		if(PlayerPrefs.GetInt("facing") == 3 && !dontturn){
			rendering = GetComponent <SpriteRenderer>();
			rendering.sprite = LD;
		}
		if(PlayerPrefs.GetInt("facing") == 4 && !dontturn){
			rendering = GetComponent <SpriteRenderer>();
			rendering.sprite = LU;
		}
	}

	void OnDestroy(){
		if(fading){
			fadechild = Instantiate(fade, transform.position, Quaternion.identity);
			childrendering = fadechild.GetComponent <SpriteRenderer>();
			rendering = GetComponent <SpriteRenderer>();
			childrendering.sprite = rendering.sprite;
		}
	}
}
