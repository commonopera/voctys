using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour {

	//isometric pixel-perfect movement
	//it seems like i found a way to make this work without the overlapcollider???
	//maybe thats only the case because you move such tiny amounts at a time though?
	//the skeleton of this script has been through a lot,
	//this is maybe the most solid version of it yet though?
	//also spawns fade when hero dissolves

	Vector3 newpos = new Vector3 (0,0,0);
	Animator animator;
	Rigidbody2D rb2d;
	public float stepwait, sfxwait;
	const int  LDOWN = 1, LUP = 2, RUP = 3, RDOWN = 4, LDZ = 5, LUZ = 6, RUZ = 7, RDZ = 8;
	int _currentAnimationState = 0;
	bool stepready = true, sfxready = true, sfxleft = true;
	public bool shadow;
	public GameObject fadeLD, fadeLU, fadeRU, fadeRD, sfxL, sfxR;


	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator>();
	}

	void changeState(int state){
		if (_currentAnimationState == state)
		return;
		switch(state){
			case LUP:
							animator.SetInteger ("state", LUP);
							PlayerPrefs.SetInt("facing", 2);
							break;
			case RDOWN:
							animator.SetInteger ("state", RDOWN);
							PlayerPrefs.SetInt("facing", 4);
							break;
			case RUP:
							animator.SetInteger ("state", RUP);
							PlayerPrefs.SetInt("facing", 3);
							break;
			case LDOWN:
							animator.SetInteger ("state", LDOWN);
							PlayerPrefs.SetInt("facing", 1);
							break;
			case LDZ:
							animator.SetInteger ("state", LDZ);
							PlayerPrefs.SetInt("facing", 1);
							break;
			case LUZ:
							animator.SetInteger ("state", LUZ);
							PlayerPrefs.SetInt("facing", 2);
							break;
			case RDZ:
							animator.SetInteger ("state", RDZ);
							PlayerPrefs.SetInt("facing", 4);
							break;
			case RUZ:
							animator.SetInteger ("state", RUZ);
							PlayerPrefs.SetInt("facing", 3);
							break;
		}
	}

	void Update () {
		if(PlayerPrefs.GetInt("frozen") == 1){
			if(animator.GetInteger("state") == LUP){
				animator.SetInteger ("state", LUZ);
			}
			if(animator.GetInteger("state") == RUP){
				animator.SetInteger ("state", RUZ);
			}
			if(animator.GetInteger("state") == LDOWN){
				animator.SetInteger ("state", LDZ);
			}
			if(animator.GetInteger("state") == RDOWN){
				animator.SetInteger ("state", RDZ);
			}
		}
		if(PlayerPrefs.GetInt("frozen") == 0){
			if (Input.GetKeyDown("down")){
				newpos = new Vector3 (-.02f, -.01f, 0);
				changeState(LDOWN);
			}
			if (Input.GetKeyDown("left")){
				newpos = new Vector3 (-.02f, .01f, 0);
				changeState(LUP);
			}
			if (Input.GetKeyDown("up")){
				newpos = new Vector3 (.02f, .01f, 0);
				changeState(RUP);
			}
			if (Input.GetKeyDown("right")){
				newpos = new Vector3 (.02f, -.01f, 0);
				changeState(RDOWN);
			}
			if ((!Input.GetKey("down")) && (animator.GetInteger("state") == LDOWN)){
				if (Input.GetKey("down")){
					newpos = new Vector3 (-.02f, -.01f, 0);
					changeState(LDOWN);
				}
				else if (Input.GetKey("left")){
					newpos = new Vector3 (-.02f, .01f, 0);
					changeState(LUP);
				}
				else if (Input.GetKey("up")){
					newpos = new Vector3 (.02f, .01f, 0);
					changeState(RUP);
				}
				else if (Input.GetKey("right")){
					newpos = new Vector3 (.02f, -.01f, 0);
					changeState(RDOWN);
				}
				else{
					changeState(LDZ);
					newpos = new Vector3 (0, 0, 0);
				}
			}
			if ((!Input.GetKey("left")) && (animator.GetInteger("state") == LUP)){
				if (Input.GetKey("down")){
					newpos = new Vector3 (-.02f, -.01f, 0);
					changeState(LDOWN);
				}
				else if (Input.GetKey("left")){
					newpos = new Vector3 (-.02f, .01f, 0);
					changeState(LUP);
				}
				else if (Input.GetKey("up")){
					newpos = new Vector3 (.02f, .01f, 0);
					changeState(RUP);
				}
				else if (Input.GetKey("right")){
					newpos = new Vector3 (.02f, -.01f, 0);
					changeState(RDOWN);
				}
				else{
					changeState(LUZ);
					newpos = new Vector3 (0, 0, 0);
				}
			}
			if ((!Input.GetKey("right")) && (animator.GetInteger("state") == RDOWN)){
				if (Input.GetKey("down")){
					newpos = new Vector3 (-.02f, -.01f, 0);
					changeState(LDOWN);
				}
				else if (Input.GetKey("left")){
					newpos = new Vector3 (-.02f, .01f, 0);
					changeState(LUP);
				}
				else if (Input.GetKey("up")){
					newpos = new Vector3 (.02f, .01f, 0);
					changeState(RUP);
				}
				else if (Input.GetKey("right")){
					newpos = new Vector3 (.02f, -.01f, 0);
					changeState(RDOWN);
				}
				else{
					changeState(RDZ);
					newpos = new Vector3 (0, 0, 0);
				}
			}
			if ((!Input.GetKey("up")) && (animator.GetInteger("state") == RUP)){
				if (Input.GetKey("down")){
					newpos = new Vector3 (-.02f, -.01f, 0);
					changeState(LDOWN);
				}
				else if (Input.GetKey("left")){
					newpos = new Vector3 (-.02f, .01f, 0);
					changeState(LUP);
				}
				else if (Input.GetKey("up")){
					newpos = new Vector3 (.02f, .01f, 0);
					changeState(RUP);
				}
				else if (Input.GetKey("right")){
					newpos = new Vector3 (.02f, -.01f, 0);
					changeState(RDOWN);
				}
				else{
					changeState(RUZ);
					newpos = new Vector3 (0, 0, 0);
				}
			}
		}
		else{
			newpos = new Vector3 (0, 0, 0);
		}
	}

	void FixedUpdate(){
		if(stepready && !shadow){
			if(PlayerPrefs.GetInt("frozen") != 1 && sfxready && (Input.GetKey("left")
			|| Input.GetKey("right") || Input.GetKey("up") || Input.GetKey("down"))){
				sfxready = false;
				if(sfxleft){
					Instantiate(sfxL, transform.position, Quaternion.identity);
				}
				else{
					Instantiate(sfxR, transform.position, Quaternion.identity);
				}
				StartCoroutine(SfxReset());
			}
			rb2d.MovePosition(transform.position + newpos);
			stepready = false;
			if(stepwait > Time.deltaTime){
				StartCoroutine(StepReset());
			}
			else{
				stepready = true;
			}
		}
	}

	IEnumerator StepReset(){
		if(stepwait >= (2 * Time.deltaTime)){
			yield return new WaitForSeconds(stepwait - (2 * Time.deltaTime));
		}
		stepready = true;
	}

	IEnumerator SfxReset(){
		yield return new WaitForSeconds(sfxwait);
		sfxready = true;
	}

	void OnDestroy(){
		if(PlayerPrefs.GetInt("facing") == 1){
			Instantiate(fadeLD, transform.position, Quaternion.identity);
		}
		if(PlayerPrefs.GetInt("facing") == 2){
			Instantiate(fadeLU, transform.position, Quaternion.identity);
		}
		if(PlayerPrefs.GetInt("facing") == 3){
			Instantiate(fadeRU, transform.position, Quaternion.identity);
		}
		if(PlayerPrefs.GetInt("facing") == 4){
			Instantiate(fadeRD, transform.position, Quaternion.identity);
		}
	}
}
