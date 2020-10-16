using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_on_playerpref : MonoBehaviour {

	//object is destroyed when certain playerpref hits certain value

	public bool an_int, a_float, a_string;
	public string prefname, thestring;
	public int theint;
	public float thefloat;

	void Update () {
		if((an_int && PlayerPrefs.GetInt(prefname) == theint)
		|| (a_float && PlayerPrefs.GetFloat(prefname) == thefloat)
		|| (a_string && PlayerPrefs.GetString(prefname) == thestring)){
			Destroy(gameObject);
		}
	}
}
