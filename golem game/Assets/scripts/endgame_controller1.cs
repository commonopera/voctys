using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endgame_controller1 : MonoBehaviour {

	//handles endgame mechanics
	//host object called by hero unit when "hp reaches 0" in battle
	//one copy on character icon moves it around and calls text when in place
	//one copy on the title text that restarts game when clicked through
	//i feel unhappy today but the clouds are beautiful

	public float waittostart, waittoend, stepwait, charawait, titlewait;
	public GameObject goodtitle, badtitle, gchelbo, gelazar, gkomlin, gmachir, gmeir,
	gnatronai, gshabsai, gsulam, guri, gzuiskind, halo, goodbg;
	bool stepready = false, titleready = true, reloadready = false, winner = false,
	charaready = true, haloready = true, gochelbo = true, goelazar = true,
	gokomlin = true, gomachir = true, gomeir = true, gonatronai = true, goshabsai = true,
	gosulam = true, gouri = true, gozuiskind = true, waitready = true;
	Rigidbody2D rb2d;

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		PlayerPrefs.SetInt("endscene", 1);
		if(PlayerPrefs.GetInt("win_chelbo") == 1 && PlayerPrefs.GetInt("win_elazar") == 1
		&& PlayerPrefs.GetInt("win_komlin") == 1 && PlayerPrefs.GetInt("win_machir") == 1
		&& PlayerPrefs.GetInt("win_meir") == 1 && PlayerPrefs.GetInt("win_natronai") == 1
		&& PlayerPrefs.GetInt("win_shabsai") == 1 && PlayerPrefs.GetInt("win_sulam") == 1
		&& PlayerPrefs.GetInt("win_uri") == 1 && PlayerPrefs.GetInt("win_zuiskind") == 1){
			winner = true;
		}
		StartCoroutine(WaitToBegin());
	}

	void Update () {
		if(reloadready&& Input.GetKeyDown("space")){
			SceneManager.LoadScene(0);
		}
		if(titleready && transform.position.y <= 0 && transform.position.x >= 0 && charaready){
			if(gochelbo && PlayerPrefs.GetInt("seq_chelbo") > 0){
				gochelbo = false;
				charaready = false;
				Instantiate(gchelbo, new Vector2(0, -1.1f), Quaternion.identity);
				if(PlayerPrefs.GetInt("win_chelbo") == 1){
					Instantiate(halo, new Vector2(0, -1.1f), Quaternion.identity);
				}
				StartCoroutine(CharaReset());
			}
			else if(goelazar && PlayerPrefs.GetInt("seq_elazar") > 0){
				goelazar = false;
				charaready = false;
				Instantiate(gelazar, new Vector2(-.55f, -.95f), Quaternion.identity);
				if(PlayerPrefs.GetInt("win_elazar") == 1){
					Instantiate(halo, new Vector2(-.55f, -.95f), Quaternion.identity);
				}
				StartCoroutine(CharaReset());
			}
			else if(gokomlin && PlayerPrefs.GetInt("seq_komlin") > 0){
				gokomlin = false;
				charaready = false;
				Instantiate(gkomlin, new Vector2(-1.1f, 0), Quaternion.identity);
				if(PlayerPrefs.GetInt("win_komlin") == 1){
					Instantiate(halo, new Vector2(-1.1f, 0), Quaternion.identity);
				}
				StartCoroutine(CharaReset());
			}
			else if(gomachir && PlayerPrefs.GetInt("seq_machir") > 0){
				gomachir = false;
				charaready = false;
				Instantiate(gmachir, new Vector2(-.95f, .55f), Quaternion.identity);
				if(PlayerPrefs.GetInt("win_machir") == 1){
					Instantiate(halo, new Vector2(-.95f, .55f), Quaternion.identity);
				}
				StartCoroutine(CharaReset());
			}
			else if(gomeir && PlayerPrefs.GetInt("seq_meir") > 0){
				gomeir  = false;
				charaready = false;
				Instantiate(gmeir, new Vector2(-.55f, .95f), Quaternion.identity);
				if(PlayerPrefs.GetInt("win_meir") == 1){
					Instantiate(halo, new Vector2(-.55f, .95f), Quaternion.identity);
				}
				StartCoroutine(CharaReset());
			}
			else if(gonatronai && PlayerPrefs.GetInt("seq_natronai") > 0){
				gonatronai = false;
				charaready = false;
				Instantiate(gnatronai, new Vector2(0, 1.1f), Quaternion.identity);
				if(PlayerPrefs.GetInt("win_natronai") == 1){
					Instantiate(halo, new Vector2(0, 1.1f), Quaternion.identity);
				}
				StartCoroutine(CharaReset());
			}
			else if(goshabsai && PlayerPrefs.GetInt("seq_shabsai") > 0){
				goshabsai = false;
				charaready = false;
				Instantiate(gshabsai, new Vector2(.55f, .95f), Quaternion.identity);
				if(PlayerPrefs.GetInt("win_shabsai") == 1){
					Instantiate(halo, new Vector2(.55f, .95f), Quaternion.identity);
				}
				StartCoroutine(CharaReset());
			}
			else if(gosulam && PlayerPrefs.GetInt("seq_sulam") > 0){
				gosulam = false;
				charaready = false;
				Instantiate(gsulam, new Vector2(.95f, .55f), Quaternion.identity);
				if(PlayerPrefs.GetInt("win_sulam") == 1){
					Instantiate(halo, new Vector2(.95f, .55f), Quaternion.identity);
				}
				StartCoroutine(CharaReset());
			}
			else if(gouri && PlayerPrefs.GetInt("seq_uri") > 0){
				gouri = false;
				charaready = false;
				Instantiate(guri, new Vector2(1.1f, 0), Quaternion.identity);
				if(PlayerPrefs.GetInt("win_uri") == 1){
					Instantiate(halo, new Vector2(1.1f, 0), Quaternion.identity);
				}
				StartCoroutine(CharaReset());
			}
			else if(gozuiskind && PlayerPrefs.GetInt("seq_zuiskind") > 0){
				gozuiskind = false;
				charaready = false;
				Instantiate(gzuiskind, new Vector2(.55f, -.95f), Quaternion.identity);
				if(PlayerPrefs.GetInt("win_zuiskind") == 1){
					Instantiate(halo, new Vector2(.55f, -.95f), Quaternion.identity);
				}
				StartCoroutine(CharaReset());
			}
			else if(winner & haloready){
				haloready = false;
				Instantiate(halo, new Vector2(0,0), Quaternion.identity);
			}
			else if (waitready){
				waitready = false;
				charaready = false;
				StartCoroutine(WaitToTitle());
			}
			else if(winner){
				Instantiate(goodtitle, new Vector2(-.11f, -.5f), Quaternion.identity);
				Instantiate(goodbg, new Vector2(0,0), Quaternion.identity);
				titleready = false;
				StartCoroutine(WaitToEnd());
			}
			else{
				Instantiate(badtitle, new Vector2(-.11f, -.5f), Quaternion.identity);
				titleready = false;
//				Instantiate(goodbg, new Vector2(0,0), Quaternion.identity);
				StartCoroutine(WaitToEnd());
			}
		}
	}

	void FixedUpdate(){
		if(stepready){
			if(transform.position.y > 0){
				rb2d.MovePosition(transform.position + new Vector3 (.02f, -.01f, 0));
			}
			else if(transform.position.x < 0){
				rb2d.MovePosition(transform.position + new Vector3 (.02f, 0, 0));
			}
			stepready = false;
			StartCoroutine(StepReset());
		}
	}

	IEnumerator StepReset(){
		yield return new WaitForSeconds(stepwait);
		stepready = true;
	}

	IEnumerator CharaReset(){
		yield return new WaitForSeconds(charawait);
		charaready = true;
	}

	IEnumerator WaitToBegin(){
		yield return new WaitForSeconds(waittostart);
		stepready = true;
	}

	IEnumerator WaitToTitle(){
		yield return new WaitForSeconds(titlewait);
		charaready = true;
	}

	IEnumerator WaitToEnd(){
		yield return new WaitForSeconds(waittoend);
		reloadready = true;
	}

}
