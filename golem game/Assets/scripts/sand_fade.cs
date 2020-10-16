using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sand_fade : MonoBehaviour {

	//fades in and out sand to match with hourglass
	//doing this with script is probably more efficient than animations anyway,
	//i... actually, i guess i could even do the fading to blacks with script too...
	//huh, oh well!
	//fullcolor fades to full white, otherwise fades to sand color
	//dropcut deletes the dropping on player sleeping
	//sandmain designates it as actually the sand to empty on player sleeping
	//sandmain also turns fighttime control on when animation has played out

	//phase 2 dialogue changes also occur here under NightEnder!!! whoops!!!

	private float timerStart, timeElapsed;
 	private bool timerStarted = false;
	public bool fullcolor, dropcut, sandmain;
	public float reloadTime;
	float delaytime = .05f;
	Animator animator;
	SpriteRenderer Render;

	void Start () {
		Render = GetComponent<SpriteRenderer>();
		animator = GetComponent<Animator>();
		if(sandmain){
			StartCoroutine(NightEnder());
		}
		timerStart = Time.time;
		timerStarted = true;
	}

	void Update () {
		if(dropcut && PlayerPrefs.GetInt("fightalmost") == 1){
			Destroy(gameObject);
		}
		if(sandmain && PlayerPrefs.GetInt("fighttime") == 1){
			animator.SetInteger ("state", 1);
		}
		if(PlayerPrefs.GetInt("fadereset") == 1){
			if(Render.color == new Color(0,0,0,0)){
				StartCoroutine(FadeIn());
			}
			timerStart = Time.time;
			timerStarted = true;
		}
		if (Input.GetKey("left") || Input.GetKey("right") ||
		Input.GetKey("up") || Input.GetKey("down") ||
		Input.GetKey("space")) {
			if(Render.color == new Color(0,0,0,0)){
				StartCoroutine(FadeIn());
			}
			timerStart = Time.time;
			timerStarted = true;
		}
		if (timerStarted == true) {
			timeElapsed = Time.time - timerStart;
			if (timeElapsed >= reloadTime) {
				StartCoroutine(FadeOut());
				timerStarted = false;
			}
		}
	}

	IEnumerator FadeIn(){
		if(fullcolor){
			Render.color = new Color(0,0,0,0);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.15f,.15f,.15f,.15f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.3f,.3f,.3f,.3f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.45f,.45f,.45f,.45f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.6f,.6f,.6f,.6f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.75f,.75f,.75f,.75f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.9f,.9f,.9f,.9f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(1,1,1,1);
		}
		else{
			Render.color = new Color(0,0,0,0);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.07f,.06f,0,.15f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.17f,.16f,.1f,.3f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.27f,.26f,.2f,.45f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.37f,.36f,.3f,.6f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.47f,.46f,.4f,.75f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.57f,.56f,.5f,.9f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.67f,.66f,.6f,1);
		}
	}

	IEnumerator FadeOut(){
		if(fullcolor){
			Render.color = new Color(1,1,1,1);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.9f,.9f,.9f,.9f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.75f,.75f,.75f,.75f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.6f,.6f,.6f,.6f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.45f,.45f,.45f,.45f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.3f,.3f,.3f,.3f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.15f,.15f,.15f,.15f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(0,0,0,0);
		}
		else{
			Render.color = new Color(.67f,.66f,.6f,1);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.57f,.56f,.5f,.9f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.47f,.46f,.4f,.75f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.37f,.36f,.3f,.6f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.27f,.26f,.2f,.45f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.17f,.16f,.1f,.3f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(.07f,.06f,.0f,.15f);
			yield return new WaitForSeconds(delaytime);
			Render.color = new Color(0,0,0,0);
		}
	}

	IEnumerator NightEnder(){
		yield return new WaitForSeconds((animator.GetCurrentAnimatorStateInfo(0).length)/2);
		//phase 2 entry:
		Debug.Log("phase 2 begins...");

		//CHELBO:
			//(CHELBO'S DIALOGUE NOT TIME SENSITIVE)
		//ELAZAR:
		if(PlayerPrefs.GetInt("seq_elazar") != 0){
			PlayerPrefs.SetInt("seq_elazar", 50);
		}
		//KOMLIN:
		if(PlayerPrefs.GetInt("seq_komlin") != 0 && PlayerPrefs.GetInt("seq_komlin") != 9
		&& PlayerPrefs.GetInt("seq_komlin") != 10 && PlayerPrefs.GetInt("seq_komlin") != 11){
			PlayerPrefs.SetInt("seq_komlin", 50);
		}
		if(PlayerPrefs.GetInt("seq_komlin") == 9 || PlayerPrefs.GetInt("seq_komlin") == 10
		|| PlayerPrefs.GetInt("seq_komlin") == 11){
			PlayerPrefs.SetInt("seq_komlin", 75);
		}
		//MACHIR:
		if(PlayerPrefs.GetInt("seq_machir") != 0 && PlayerPrefs.GetInt("seq_machir") != 12
		&& PlayerPrefs.GetInt("seq_machir") != 13){
			PlayerPrefs.SetInt("seq_machir", 51);
		}
		if(PlayerPrefs.GetInt("seq_machir") == 12 || PlayerPrefs.GetInt("seq_machir") == 13){
			PlayerPrefs.SetInt("seq_machir", 75);
		}
		//MEIR:
			//(MEIR'S DIALOGUE NOT TIME SENSITIVE)
		//NATRONAI:
		if(PlayerPrefs.GetInt("seq_natronai") != 0){
			if(PlayerPrefs.GetInt("seq_natronai") == 5 || PlayerPrefs.GetInt("seq_natronai") == 6
			|| PlayerPrefs.GetInt("seq_natronai") == 7 || PlayerPrefs.GetInt("seq_natronai") == 8
			|| PlayerPrefs.GetInt("seq_natronai") == 9 || PlayerPrefs.GetInt("seq_natronai") == 10
			|| PlayerPrefs.GetInt("seq_natronai") == 11){
				PlayerPrefs.SetInt("seq_natronai", 50);
			}
			else{
				PlayerPrefs.SetInt("seq_natronai", 49);
			}
		}
		//SHABSAI:
		if(PlayerPrefs.GetInt("seq_shabsai") != 0){
			PlayerPrefs.SetInt("seq_shabsai", 50);
		}
		//SULAM:
		if(PlayerPrefs.GetInt("seq_sulam") != 0 && PlayerPrefs.GetInt("seq_uri") != 8
		&& PlayerPrefs.GetInt("seq_uri") != 9 && PlayerPrefs.GetInt("seq_uri") != 10
		&& PlayerPrefs.GetInt("seq_uri") != 11 && PlayerPrefs.GetInt("seq_uri") != 12
		&& PlayerPrefs.GetInt("seq_uri") != 13 && PlayerPrefs.GetInt("seq_uri") != 14
		&& PlayerPrefs.GetInt("seq_uri") != 50){
			PlayerPrefs.SetInt("seq_sulam", 75);
		}
		//URI:
		if(PlayerPrefs.GetInt("seq_uri") != 0 && PlayerPrefs.GetInt("seq_uri") != 4
		&& PlayerPrefs.GetInt("seq_uri") != 5 && PlayerPrefs.GetInt("seq_uri") != 6
		&& PlayerPrefs.GetInt("seq_uri") != 7 && PlayerPrefs.GetInt("seq_uri") != 8
		&& PlayerPrefs.GetInt("seq_uri") != 9 && PlayerPrefs.GetInt("seq_uri") != 10
		&& PlayerPrefs.GetInt("seq_uri") != 11 && PlayerPrefs.GetInt("seq_uri") != 12
		&& PlayerPrefs.GetInt("seq_uri") != 13 && PlayerPrefs.GetInt("seq_uri") != 14){
			PlayerPrefs.SetInt("seq_uri", 75);
		}
		if(PlayerPrefs.GetInt("seq_uri") == 4 || PlayerPrefs.GetInt("seq_uri") == 5
		|| PlayerPrefs.GetInt("seq_uri") == 6 || PlayerPrefs.GetInt("seq_uri") == 7
		|| PlayerPrefs.GetInt("seq_uri") == 8 || PlayerPrefs.GetInt("seq_uri") == 9
		|| PlayerPrefs.GetInt("seq_uri") == 10 || PlayerPrefs.GetInt("seq_uri") == 11
		|| PlayerPrefs.GetInt("seq_uri") == 12 || PlayerPrefs.GetInt("seq_uri") == 13
		|| PlayerPrefs.GetInt("seq_uri") == 14){
			PlayerPrefs.SetInt("seq_uri", 50);
		}
		//ZUISKIND:
		if(PlayerPrefs.GetInt("seq_zuiskind") != 0 && PlayerPrefs.GetInt("seq_zuiskind") != 4
		&& PlayerPrefs.GetInt("seq_zuiskind") != 5 && PlayerPrefs.GetInt("seq_zuiskind") != 6
		&& PlayerPrefs.GetInt("seq_zuiskind") != 7){
			PlayerPrefs.SetInt("seq_zuiskind", 50);
		}
		if(PlayerPrefs.GetInt("seq_zuiskind") == 4 || PlayerPrefs.GetInt("seq_zuiskind") == 5
		|| PlayerPrefs.GetInt("seq_zuiskind") == 6 || PlayerPrefs.GetInt("seq_zuiskind") == 7){
			PlayerPrefs.SetInt("seq_zuiskind", 75);
		}

		//second half timer:
		yield return new WaitForSeconds((animator.GetCurrentAnimatorStateInfo(0).length)/2);
		PlayerPrefs.SetInt("fightalmost", 1);
		yield return new WaitForSeconds(8);
		PlayerPrefs.SetInt("fighttime", 1);
	}
}
