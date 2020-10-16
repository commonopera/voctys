using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadewaitfade : MonoBehaviour {

	//object fades in, waits specified length, then fades out
	//for use primarily on portraits

	//(if "replace", spawns replacement object in its place before destructing)
	//(if "specificreplace" spawns replacement at given coordinates, otherwise at own location)

	SpriteRenderer Render;
	public float delaytime, pausetime;

	public bool replace, specificreplace;
	public GameObject replacement;
	public float replacex, replacey;

	void Start () {
		Render = GetComponent<SpriteRenderer>();
		StartCoroutine(Fades());
	}

	IEnumerator Fades(){
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
		yield return new WaitForSeconds(pausetime);
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
