using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class villain_spawn : MonoBehaviour {

	//spawns enemies into battle based on sequence

	public float waitbetween1, waitbetween2, wavebreak1, wavebreak2, minx, miny,
	maxx, maxy, wave1max, wave2max, wave3max, wave4max;
	public GameObject v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14,
	v15, v16, v17, v18, v19, v20, v21, v22, v23;
	float yrange;
	bool wave1set = true, wave2set = false, wave3set = false, wave4set = false;
	float cx = 2.68f, cy = -1.64f, cz = -.8f, l1x = 2.56f, l1y = -1.73f, l1z = -.9f,
	r1x = 2.79f, r1y = -1.55f, r1z = -.7f, l2x = 2.44f, l2y = -1.82f, l2z = -1f,
	r2x = 2.9f, r2y = -1.46f, r2z = -.6f;

	void Start () {
		StartCoroutine(Wave1());
	}

	void Update (){
		if(wave1set && PlayerPrefs.GetInt("enemy_dmg") >= wave1max){
			wave1set = false;
			PlayerPrefs.SetFloat("villain_target_x", -100);
			PlayerPrefs.SetFloat("villain_target_y", -100);
			StartCoroutine(Wave2());
		}
		if(wave2set && PlayerPrefs.GetInt("enemy_dmg") >= wave2max){
			wave2set = false;
			PlayerPrefs.SetFloat("villain_target_x", -100);
			PlayerPrefs.SetFloat("villain_target_y", -100);
			StartCoroutine(Wave3());
		}
		if(wave3set && PlayerPrefs.GetInt("enemy_dmg") >= wave3max){
			wave3set = false;
			PlayerPrefs.SetFloat("villain_target_x", -100);
			PlayerPrefs.SetFloat("villain_target_y", -100);
			StartCoroutine(Wave4());
		}
		if(wave4set && PlayerPrefs.GetInt("enemy_dmg") >= wave4max){
			wave4set = false;
			PlayerPrefs.SetFloat("villain_target_x", -100);
			PlayerPrefs.SetFloat("villain_target_y", -100);
			StartCoroutine(Wave5());
		}
	}

	IEnumerator Wave1(){
		//WAVE 1:
		Instantiate(v1, new Vector3(cx, cy, cz), Quaternion.identity);
		yield return new WaitForSeconds(waitbetween1);
		Instantiate(v2, new Vector3(l1x, l1y, l1z), Quaternion.identity);
		yield return new WaitForSeconds(waitbetween1);
		Instantiate(v3, new Vector3(r1x, r1y, r1z), Quaternion.identity);
		yield return new WaitForSeconds(waitbetween1);
		Instantiate(v4, new Vector3(l2x, l2y, l2z), Quaternion.identity);
		yield return new WaitForSeconds(waitbetween1);
		Instantiate(v5, new Vector3(r2x, r2y, r2z), Quaternion.identity);
	}

	IEnumerator Wave2(){
		//WAVE 2:
		yield return new WaitForSeconds(wavebreak1);
		PlayerPrefs.SetInt("enemy_dmg", 0);
		wave2set = true;
		Instantiate(v6, new Vector3(cx, cy, cz), Quaternion.identity);
		yield return new WaitForSeconds(waitbetween1);
		Instantiate(v7, new Vector3(l1x, l1y, l1z),	Quaternion.identity);
		yield return new WaitForSeconds(waitbetween1);
		Instantiate(v8, new Vector3(r1x, r1y, r1z), Quaternion.identity);
		yield return new WaitForSeconds(waitbetween2);
		Instantiate(v9, new Vector3(cx, cy, cz), Quaternion.identity);
	}

	IEnumerator Wave3(){
		//WAVE 3:
		yield return new WaitForSeconds(wavebreak2);
		PlayerPrefs.SetInt("enemy_dmg", 0);
		wave3set = true;
		Instantiate(v10, new Vector3(l1x, l1y, l1z), Quaternion.identity);
		yield return new WaitForSeconds(waitbetween1);
		Instantiate(v11, new Vector3(r1x, r1y, r1z),	Quaternion.identity);
		yield return new WaitForSeconds(waitbetween1);
		Instantiate(v12, new Vector3(l2x, l2y, l2z), Quaternion.identity);
		yield return new WaitForSeconds(waitbetween1);
		Instantiate(v13, new Vector3(r2x, r2y, r2z), Quaternion.identity);
		yield return new WaitForSeconds(waitbetween2);
		Instantiate(v14, new Vector3(l1x, l1y, l1z), Quaternion.identity);
		yield return new WaitForSeconds(waitbetween1);
		Instantiate(v15, new Vector3(r1x, r1y, r1z),	Quaternion.identity);
	}

	IEnumerator Wave4(){
		//WAVE 4:
		yield return new WaitForSeconds(wavebreak1);
		PlayerPrefs.SetInt("enemy_dmg", 0);
		wave4set = true;
		Instantiate(v16, new Vector3(l1x, l1y, l1z), Quaternion.identity);
		yield return new WaitForSeconds(waitbetween1);
		Instantiate(v17, new Vector3(r1x, r1y, r1z),	Quaternion.identity);
		yield return new WaitForSeconds(waitbetween1);
		Instantiate(v18, new Vector3(l2x, l2y, l2z), Quaternion.identity);
		yield return new WaitForSeconds(waitbetween1);
		Instantiate(v19, new Vector3(r2x, r2y, r2z), Quaternion.identity);
		yield return new WaitForSeconds(waitbetween1);
		Instantiate(v20, new Vector3(cx, cy, cz), Quaternion.identity);
	}

	IEnumerator Wave5(){
		//WAVE 5:
		yield return new WaitForSeconds(wavebreak2);
		PlayerPrefs.SetInt("enemy_dmg", 0);
		Instantiate(v21, new Vector3(l1x, l1y, l1z), Quaternion.identity);
		yield return new WaitForSeconds(waitbetween1);
		Instantiate(v22, new Vector3(r1x, r1y, r1z),	Quaternion.identity);
		yield return new WaitForSeconds(waitbetween2);
		Instantiate(v23, new Vector3(cx, cy, cz), Quaternion.identity);
	}
}
