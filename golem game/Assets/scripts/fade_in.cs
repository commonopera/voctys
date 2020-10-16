using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade_in : MonoBehaviour {

	//smoothly fades objects in from transparent black when they are created
	//OR check fade_out to reverse to fading out then destroying self

	public float delaytime, totalfilled = 1;
	//"delaytime" x7 is the total time the fadein takes,
	//"totalfilled" is the target opacity object should fade in to (0 = 0%, 1 = 100%)
	//(the latter for objects meant to be still partially transparent at fadeins completion)

	public bool fade_out;

	SpriteRenderer Render;

	void Start () {
		Render = GetComponent<SpriteRenderer>();
		if(fade_out){
			StartCoroutine(FadeOut());
		}
		else{
			StartCoroutine(FadeIn());
		}
	}

	IEnumerator FadeIn(){
		Render.color = new Color(0,0,0,0);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(.15f * totalfilled,.15f * totalfilled,.15f * totalfilled,.15f * totalfilled);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(.3f * totalfilled,.3f * totalfilled,.3f * totalfilled,.3f * totalfilled);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(.45f * totalfilled,.45f * totalfilled,.45f * totalfilled,.45f * totalfilled);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(.6f * totalfilled,.6f * totalfilled,.6f * totalfilled,.6f * totalfilled);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(.75f * totalfilled,.75f * totalfilled,.75f * totalfilled,.75f * totalfilled);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(.9f * totalfilled,.9f * totalfilled,.9f * totalfilled,.9f * totalfilled);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(totalfilled,totalfilled,totalfilled,totalfilled);
	}

	IEnumerator FadeOut(){
		Render.color = new Color(totalfilled,totalfilled,totalfilled,totalfilled);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(.9f * totalfilled,.9f * totalfilled,.9f * totalfilled,.9f * totalfilled);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(.75f * totalfilled,.75f * totalfilled,.75f * totalfilled,.75f * totalfilled);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(.6f * totalfilled,.6f * totalfilled,.6f * totalfilled,.6f * totalfilled);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(.45f * totalfilled,.45f * totalfilled,.45f * totalfilled,.45f * totalfilled);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(.3f * totalfilled,.3f * totalfilled,.3f * totalfilled,.3f * totalfilled);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(.15f * totalfilled,.15f * totalfilled,.15f * totalfilled,.15f * totalfilled);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(0,0,0,0);
		Destroy(gameObject);		
	}
}
