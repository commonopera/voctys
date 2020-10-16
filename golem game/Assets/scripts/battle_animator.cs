using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battle_animator : MonoBehaviour {

	//controls ally animations in battle

	bool begin = true;
	public string name;
	Animator animator;

	void Update () {
		if(begin){
			begin = false;
			animator = GetComponent<Animator>();
		}
		if(animator.GetInteger ("state") == 1){
			animator.SetInteger ("state", 0);
		}
		if(animator.GetInteger ("state") == 2){
			animator.SetInteger ("state", 0);
		}
		if(animator.GetInteger ("state") == 3){
			animator.SetInteger ("state", 0);
		}
		if(animator.GetInteger ("state") == 4){
			animator.SetInteger ("state", 0);
		}
		else if(PlayerPrefs.GetInt("ani_" + name) == 1){
			animator.SetInteger("state", 1);
			PlayerPrefs.SetInt("ani_" + name, 0);
		}
		else if(PlayerPrefs.GetInt("ani_" + name) == 2){
			animator.SetInteger("state", 2);
			PlayerPrefs.SetInt("ani_" + name, 0);
		}
		else if(PlayerPrefs.GetInt("ani_" + name) == 3){
			animator.SetInteger("state", 3);
			PlayerPrefs.SetInt("ani_" + name, 0);
		}
		else if(PlayerPrefs.GetInt("ani_" + name) == 4){
			animator.SetInteger("state", 4);
			PlayerPrefs.SetInt("ani_" + name, 0);
		}
	}
}
