using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grid_fade : MonoBehaviour {

	//i didnt write the core of this, thanks timo326 on the unity forums
	//fades in castle overmap grid on load and upon exiting a room
	//fades it out upon entering a room or after a set amount of time with no input
	//checking "hourglass" sets object to fade in and out on keypress even in a room

	private float timerStart, timeElapsed;
 	private bool timerStarted = false;
	public bool hourglass;
	public float reloadTime;
	Animator animator;

	void Start () {
		animator = GetComponent<Animator>();
		timerStart = Time.time;
		timerStarted = true;
	}

	void Update () {
		if(PlayerPrefs.GetInt("fadereset") == 1){
			animator.SetInteger("state", 0);
			timerStart = Time.time;
			timerStarted = true;
			if(!hourglass){
				PlayerPrefs.SetInt("fadereset", 0);
			}
		}
		if(hourglass){
			if (Input.GetKey("left") || Input.GetKey("right") ||
			Input.GetKey("up") || Input.GetKey("down") ||
			Input.GetKey("space")) {
				if(animator.GetInteger("state") == 1){
					animator.SetInteger("state", 0);
				}
	  		timerStart = Time.time;
	  		timerStarted = true;
	  	}
	 		if (timerStarted == true) {
	  		timeElapsed = Time.time - timerStart;
	  		if (timeElapsed >= reloadTime) {
			    animator.SetInteger ("state", 1);
	    		timerStarted = false;
	   		}
	  	}
		}
		else if(PlayerPrefs.GetInt("inroom") == 0){
			if (Input.GetKeyDown("left") || Input.GetKeyDown("right") ||
			Input.GetKeyDown("up") || Input.GetKeyDown("down") ||
			Input.GetKeyDown("space")) {
				if(animator.GetInteger("state") == 1){
					animator.SetInteger("state", 0);
				}
	  		timerStart = Time.time;
	  		timerStarted = true;
	  	}
	 		if (timerStarted == true) {
	  		timeElapsed = Time.time - timerStart;
	  		if (timeElapsed >= reloadTime) {
			    animator.SetInteger ("state", 1);
	    		timerStarted = false;
	   		}
	  	}
		}
		else{
			animator.SetInteger ("state", 1);
		}
	}
}
