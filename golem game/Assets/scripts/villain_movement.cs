using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class villain_movement : MonoBehaviour {

	//villains walk down bridge and start attacking your party

	Rigidbody2D rb2d;
	Animator animator;
	public float stepwait, atkwait, maxx, maxy;
	bool stepready = true, begin = true;
	public int atk, killpoint, lastkillpoint;
	public GameObject death, atk_anim;

	void Update () {
		if(lastkillpoint <= PlayerPrefs.GetInt("enemy_dmg") &&
		PlayerPrefs.GetInt("enemy_dmg") < killpoint){
			PlayerPrefs.SetFloat("villain_target_x", transform.position.x);
			PlayerPrefs.SetFloat("villain_target_y", transform.position.y);
		}
		if(PlayerPrefs.GetInt("enemy_dmg") >= killpoint){
			Instantiate(death, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
		if(begin){
			rb2d = GetComponent<Rigidbody2D> ();
			animator = GetComponent<Animator>();
			begin = false;
		}
		if(animator.GetInteger ("state") == 1){
			animator.SetInteger ("state", 0);
		}
		if(stepready && transform.position.x >= maxx && transform.position.y <= maxy){
			stepready = false;
			rb2d.MovePosition(transform.position + new Vector3 (-.02f, .01f, 0));
			StartCoroutine(StepReset());
		}
		else if(stepready){
			animator.SetInteger ("state", 1);
			stepready = false;
			Instantiate(atk_anim, new Vector2(PlayerPrefs.GetFloat("monk_target_x", 0),
			PlayerPrefs.GetFloat("monk_target_y", 0)), Quaternion.identity);
			PlayerPrefs.SetInt("ally_dmg", (PlayerPrefs.GetInt("ally_dmg") + atk));
			StartCoroutine(AtkReset());
		}
	}

	IEnumerator StepReset(){
		yield return new WaitForSeconds(stepwait);
		stepready = true;
	}

	IEnumerator AtkReset(){
		yield return new WaitForSeconds(atkwait);
		stepready = true;
	}
}
