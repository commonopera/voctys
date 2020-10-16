using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyfade : MonoBehaviour {

	//oversky fades from dark to transparent as dawn nears
	//even in these tiny increments the cuts are a little choppier than i'd like...
	//waittobegin at 1200 and waitbetween at .6 to line up with hourglass animation
	//(hourglass at .01 speed, timing out to about 29 minutes duration)

	//...haha psyche, way too much content @_____@
	//adding "modifyby" float to stretch it out—currently set to 2 for double that length

	public float waittobegin, waitbetween, modifyby;
	bool repeater = false;
	SpriteRenderer Render;
	Color thenewcolor;

	void Start () {
		Render = GetComponent<SpriteRenderer>();
		StartCoroutine(DarknessEnding1());
	}

	void Update () {
		if(repeater){
			repeater = false;
			StartCoroutine(DarknessEnding2());
		}
		if(PlayerPrefs.GetInt("fighttime") == 1){
			StopCoroutine(DarknessEnding1());
			StopCoroutine(DarknessEnding2());
			Render.color = new Color(0, 0, 0, 0);
		}
	}

	IEnumerator DarknessEnding1(){
		yield return new WaitForSeconds(waittobegin * modifyby);
		thenewcolor = Render.color - new Color(0, 0, 0, .00125f);
		Render.color = thenewcolor;
		yield return new WaitForSeconds(waitbetween * modifyby);
		repeater = true;
	}

	IEnumerator DarknessEnding2(){
		thenewcolor = Render.color - new Color(0, 0, 0, .00125f);
		Render.color = thenewcolor;
		yield return new WaitForSeconds(waitbetween * modifyby);
		repeater = true;
	}
}
