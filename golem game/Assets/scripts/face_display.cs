using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class face_display : MonoBehaviour {

	//attach to dialogue prefab to call selected portrait on creation
	//sets portrait's fadewaitfade script to linger just slightly longer
	//than the dialogue will take to display

	public GameObject face;
	public fadewaitfade fadecontrol;
	public dialogue_proto diacontrol;
	float facelinger;
	public bool endgame_top;
	public float waitfactor = 1.1f;


	void Start () {
		fadecontrol = face.GetComponent<fadewaitfade>();
		diacontrol = GetComponent<dialogue_proto>();
		facelinger = Mathf.CeilToInt(diacontrol.text.Length * diacontrol.waittime * waitfactor);
		fadecontrol.pausetime = facelinger;
		if(endgame_top){
			Instantiate(face, new Vector2(-3.75f, 2.33f), Quaternion.identity);
		}
		else{
			Instantiate(face, new Vector2(3.75f, -2.33f), Quaternion.identity);
		}
	}
}
