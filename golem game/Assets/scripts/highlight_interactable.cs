using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highlight_interactable : MonoBehaviour {

	//fades in an outline around interactable objects when within range
	//and fades back out upon leaving range
	//(attach as child to object's gobehind and attach a circlecollider
	//that matches the one on its menu caller)

	bool inZone = false, visible = false;
	public float delaytime, totalfilled = 1;
	SpriteRenderer Render, ParentRender;


	void Start () {
		Render = GetComponent<SpriteRenderer>();
		Render.color = new Color(0,0,0,0);
		ParentRender = gameObject.transform.parent.GetComponent<SpriteRenderer>();
	}

	void Update () {
		if(Render.sortingOrder != ParentRender.sortingOrder){
			Render.sortingOrder = ParentRender.sortingOrder;
		}
		if(inZone && !visible){
			visible = true;
			StopAllCoroutines();
			StartCoroutine(FadeIn());
		}
		if(!inZone && visible){
			visible = false;
			StopAllCoroutines();
			StartCoroutine(FadeOut());
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "player"){
			inZone = true;
		}
	}

	void OnTriggerExit2D(Collider2D col){
		if(col.gameObject.tag == "player"){
			inZone = false;
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
	}
}
