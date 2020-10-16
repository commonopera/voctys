using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class active_time_reset : MonoBehaviour {

	//counts down cooldown time between characters' battle actions then resets

	public Sprite f01, f02, f03, f04, f05, f06, f07, f08, f09, f10, f11, f12, f13,
	f14, f15, f16, f17, f18, f19, f20, f21, f22, f23, f24, f25, f26, f27, f28, f29,
	f30, f31, f32, f33, f34, f35;
	SpriteRenderer renderer;
	public float waittime;
	int whichframe = 1;
	bool ready = false;
	public string itsname;

	void Start () {
		renderer = GetComponent<SpriteRenderer>();
		StartCoroutine(NextFrame());
	}

	void Update () {
		if(PlayerPrefs.GetInt("endscene") == 1){
			Destroy(gameObject);
		}
		if(ready){
			if(whichframe == 1){
				ready = false;
				renderer.sprite = f02;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 2){
				ready = false;
				renderer.sprite = f03;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 3){
				ready = false;
				renderer.sprite = f04;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 4){
				ready = false;
				renderer.sprite = f05;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 5){
				ready = false;
				renderer.sprite = f06;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 6){
				ready = false;
				renderer.sprite = f07;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 7){
				ready = false;
				renderer.sprite = f08;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 8){
				ready = false;
				renderer.sprite = f09;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 9){
				ready = false;
				renderer.sprite = f10;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 10){
				ready = false;
				renderer.sprite = f11;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 11){
				ready = false;
				renderer.sprite = f12;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 12){
				ready = false;
				renderer.sprite = f13;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 13){
				ready = false;
				renderer.sprite = f14;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 14){
				ready = false;
				renderer.sprite = f15;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 15){
				ready = false;
				renderer.sprite = f16;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 16){
				ready = false;
				renderer.sprite = f17;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 17){
				ready = false;
				renderer.sprite = f18;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 18){
				ready = false;
				renderer.sprite = f19;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 19){
				ready = false;
				renderer.sprite = f20;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 20){
				ready = false;
				renderer.sprite = f21;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 21){
				ready = false;
				renderer.sprite = f22;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 22){
				ready = false;
				renderer.sprite = f23;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 23){
				ready = false;
				renderer.sprite = f24;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 24){
				ready = false;
				renderer.sprite = f25;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 25){
				ready = false;
				renderer.sprite = f26;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 26){
				ready = false;
				renderer.sprite = f27;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 27){
				ready = false;
				renderer.sprite = f28;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 28){
				ready = false;
				renderer.sprite = f29;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 29){
				ready = false;
				renderer.sprite = f30;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 30){
				ready = false;
				renderer.sprite = f31;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 31){
				ready = false;
				renderer.sprite = f32;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 32){
				ready = false;
				renderer.sprite = f33;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 33){
				ready = false;
				renderer.sprite = f34;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 34){
				ready = false;
				renderer.sprite = f35;
				StartCoroutine(NextFrame());
			}
			if(whichframe == 35){
				PlayerPrefs.SetInt(("activetime_" + itsname), 1);
				Destroy(gameObject);
			}
		}
	}

	IEnumerator NextFrame(){
		yield return new WaitForSeconds (waittime);
		whichframe += 1;
		ready = true;
	}
}
