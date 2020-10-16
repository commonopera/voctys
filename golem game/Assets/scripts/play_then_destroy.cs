using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_then_destroy : MonoBehaviour {

	//PLAYS ANIMATION ONCE THEN DESTROYS OBJECT
	//(if "replace", spawns replacement object in its place before destructing)
	//(if "specificreplace" spawns replacement at given coordinates, otherwise at own location)

	public bool replace, specificreplace;
	public GameObject replacement;
	public float replacex, replacey;

	void Start () {
		StartCoroutine(Activate());
	}

	IEnumerator Activate(){
		yield return new WaitForSeconds((this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length));
		if(replace){
			if(specificreplace){
				Instantiate(replacement, new Vector2(replacex, replacey), Quaternion.identity);
			}
			else{
				Instantiate(replacement, transform.position, Quaternion.identity);
			}
		}
		Destroy(gameObject);
	}
}
