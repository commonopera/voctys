using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room_name : MonoBehaviour {

	//displays name of room currently selected on castle overmap

	public Sprite one, two, three, four, five, six, seven, eight, nine, ten, eleven,
	twelve, thirteen;
	SpriteRenderer renderer;

	void Start () {
		renderer = GetComponent<SpriteRenderer>();
	}

	void Update () {
		if(PlayerPrefs.GetInt("inroom") == 0){
			if(PlayerPrefs.GetInt("room") == 1){
				renderer.sprite = one;
			}
			if(PlayerPrefs.GetInt("room") == 2){
				renderer.sprite = two;
			}
			if(PlayerPrefs.GetInt("room") == 3){
				renderer.sprite = three;
			}
			if(PlayerPrefs.GetInt("room") == 4){
				renderer.sprite = four;
			}
			if(PlayerPrefs.GetInt("room") == 5){
				renderer.sprite = five;
			}
			if(PlayerPrefs.GetInt("room") == 6){
				renderer.sprite = six;
			}
			if(PlayerPrefs.GetInt("room") == 7){
				renderer.sprite = seven;
			}
			if(PlayerPrefs.GetInt("room") == 8){
				renderer.sprite = eight;
			}
			if(PlayerPrefs.GetInt("room") == 9){
				renderer.sprite = nine;
			}
			if(PlayerPrefs.GetInt("room") == 10){
				renderer.sprite = ten;
			}
			if(PlayerPrefs.GetInt("room") == 11){
				renderer.sprite = eleven;
			}
			if(PlayerPrefs.GetInt("room") == 12){
				renderer.sprite = twelve;
			}
			if(PlayerPrefs.GetInt("room") == 13){
				renderer.sprite = thirteen;
			}
		}
	}
}
