using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitting : MonoBehaviour {

	//call quit menu from curator with esc,
	//quit or resume game from quit menu with space or esc respectively

	public bool caller, executor;
	bool called = false;
	public GameObject quitscreen, fade;


	void Update () {
		if(caller){
			if(Input.GetKeyDown("escape") && called == false){
				called = true;
				Instantiate(quitscreen, new Vector2(0, 0), Quaternion.identity);
			}
			else if(Input.GetKeyDown("escape") && called){
				called = false;
			}
		}
		if(executor){
			if(Input.GetKeyDown("escape")){
				Instantiate(fade, new Vector2(0, 0), Quaternion.identity);
				Destroy(gameObject);
			}
			if(Input.GetKeyDown("space")){
				Application.Quit();
			}
		}
	}
}
