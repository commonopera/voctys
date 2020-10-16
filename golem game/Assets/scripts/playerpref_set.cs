using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerpref_set : MonoBehaviour {

	//object alters a playerpref either upon being created or upon being destroyed


	public bool an_int, a_float, a_string, on_start, on_destroy;
	public string prefname, thestring;
	public int theint;
	public float thefloat;

	void Start () {
		if(on_start){
			if(an_int){
				PlayerPrefs.SetInt(prefname, theint);
			}
			if(a_float){
				PlayerPrefs.SetFloat(prefname, thefloat);
			}
			if(a_string){
				PlayerPrefs.SetString(prefname, thestring);
			}
		}
	}

	void OnDestroy () {
		if(on_destroy){
			if(an_int){
				PlayerPrefs.SetInt(prefname, theint);
			}
			if(a_float){
				PlayerPrefs.SetFloat(prefname, thefloat);
			}
			if(a_string){
				PlayerPrefs.SetString(prefname, thestring);
			}
		}
	}
}
