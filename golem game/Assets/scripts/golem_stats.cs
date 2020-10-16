using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golem_stats : MonoBehaviour {

//sets golem stats variables based on chosenname

	void Start () {
		if(PlayerPrefs.GetInt("chosenname") == 1){
			PlayerPrefs.SetInt("golem_atk", 6);
			PlayerPrefs.SetInt("golem_def", 2);
			PlayerPrefs.SetInt("golem_hp", 19);
		}
		if(PlayerPrefs.GetInt("chosenname") == 2){
			PlayerPrefs.SetInt("golem_atk", 5);
			PlayerPrefs.SetInt("golem_def", 3);
			PlayerPrefs.SetInt("golem_hp", 21);
		}
		if(PlayerPrefs.GetInt("chosenname") == 3){
			PlayerPrefs.SetInt("golem_atk", 3);
			PlayerPrefs.SetInt("golem_def", 4);
			PlayerPrefs.SetInt("golem_hp", 29);
		}
		if(PlayerPrefs.GetInt("chosenname") == 4){
			PlayerPrefs.SetInt("golem_atk", 2);
			PlayerPrefs.SetInt("golem_def", 6);
			PlayerPrefs.SetInt("golem_hp", 16);
		}
		if(PlayerPrefs.GetInt("chosenname") == 5){
			PlayerPrefs.SetInt("golem_atk", 3);
			PlayerPrefs.SetInt("golem_def", 4);
			PlayerPrefs.SetInt("golem_hp", 22);
		}
		if(PlayerPrefs.GetInt("chosenname") == 6){
			PlayerPrefs.SetInt("golem_atk", 8);
			PlayerPrefs.SetInt("golem_def", 4);
			PlayerPrefs.SetInt("golem_hp", 25);
		}
		if(PlayerPrefs.GetInt("chosenname") == 7){
			PlayerPrefs.SetInt("golem_atk", 6);
			PlayerPrefs.SetInt("golem_def", 5);
			PlayerPrefs.SetInt("golem_hp", 34);
		}
		if(PlayerPrefs.GetInt("chosenname") == 8){
			PlayerPrefs.SetInt("golem_atk", 7);
			PlayerPrefs.SetInt("golem_def", 4);
			PlayerPrefs.SetInt("golem_hp", 32);
		}
		if(PlayerPrefs.GetInt("chosenname") == 9){
			PlayerPrefs.SetInt("golem_atk", 4);
			PlayerPrefs.SetInt("golem_def", 9);
			PlayerPrefs.SetInt("golem_hp", 24);
		}
		if(PlayerPrefs.GetInt("chosenname") == 10){
			PlayerPrefs.SetInt("golem_atk", 3);
			PlayerPrefs.SetInt("golem_def", 2);
			PlayerPrefs.SetInt("golem_hp", 23);
		}
		if(PlayerPrefs.GetInt("chosenname") == 11){
			PlayerPrefs.SetInt("golem_atk", 2);
			PlayerPrefs.SetInt("golem_def", 3);
			PlayerPrefs.SetInt("golem_hp", 20);
		}
		if(PlayerPrefs.GetInt("chosenname") == 12){
			PlayerPrefs.SetInt("golem_atk", 4);
			PlayerPrefs.SetInt("golem_def", 2);
			PlayerPrefs.SetInt("golem_hp", 22);
		}
		if(PlayerPrefs.GetInt("chosenname") == 13){
			PlayerPrefs.SetInt("golem_atk", 5);
			PlayerPrefs.SetInt("golem_def", 1);
			PlayerPrefs.SetInt("golem_hp", 12);
		}
		if(PlayerPrefs.GetInt("chosenname") == 14){
			PlayerPrefs.SetInt("golem_atk", 2);
			PlayerPrefs.SetInt("golem_def", 3);
			PlayerPrefs.SetInt("golem_hp", 20);
		}
		if(PlayerPrefs.GetInt("chosenname") == 15){
			PlayerPrefs.SetInt("golem_atk", 3);
			PlayerPrefs.SetInt("golem_def", 2);
			PlayerPrefs.SetInt("golem_hp", 20);
		}
		if(PlayerPrefs.GetInt("chosenname") == 16){
			PlayerPrefs.SetInt("golem_atk", 3);
			PlayerPrefs.SetInt("golem_def", 3);
			PlayerPrefs.SetInt("golem_hp", 16);
		}
		if(PlayerPrefs.GetInt("chosenname") == 17){
			PlayerPrefs.SetInt("golem_atk", 6);
			PlayerPrefs.SetInt("golem_def", 5);
			PlayerPrefs.SetInt("golem_hp", 24);
		}
		if(PlayerPrefs.GetInt("chosenname") == 18){
			PlayerPrefs.SetInt("golem_atk", 5);
			PlayerPrefs.SetInt("golem_def", 4);
			PlayerPrefs.SetInt("golem_hp", 23);
		}
		if(PlayerPrefs.GetInt("chosenname") == 19){
			PlayerPrefs.SetInt("golem_atk", 6);
			PlayerPrefs.SetInt("golem_def", 3);
			PlayerPrefs.SetInt("golem_hp", 24);
		}
		if(PlayerPrefs.GetInt("chosenname") == 20){
			PlayerPrefs.SetInt("golem_atk", 5);
			PlayerPrefs.SetInt("golem_def", 5);
			PlayerPrefs.SetInt("golem_hp", 25);
		}
		if(PlayerPrefs.GetInt("chosenname") == 21){
			PlayerPrefs.SetInt("golem_atk", 5);
			PlayerPrefs.SetInt("golem_def", 4);
			PlayerPrefs.SetInt("golem_hp", 24);
		}
		if(PlayerPrefs.GetInt("chosenname") == 22){
			PlayerPrefs.SetInt("golem_atk", 4);
			PlayerPrefs.SetInt("golem_def", 4);
			PlayerPrefs.SetInt("golem_hp", 18);
		}
		if(PlayerPrefs.GetInt("chosenname") == 23){
			PlayerPrefs.SetInt("golem_atk", 2);
			PlayerPrefs.SetInt("golem_def", 2);
			PlayerPrefs.SetInt("golem_hp", 26);
		}
		if(PlayerPrefs.GetInt("chosenname") == 24){
			PlayerPrefs.SetInt("golem_atk", 6);
			PlayerPrefs.SetInt("golem_def", 3);
			PlayerPrefs.SetInt("golem_hp", 17);
		}
		if(PlayerPrefs.GetInt("chosenname") == 25){
			PlayerPrefs.SetInt("golem_atk", 3);
			PlayerPrefs.SetInt("golem_def", 3);
			PlayerPrefs.SetInt("golem_hp", 24);
		}
		if(PlayerPrefs.GetInt("chosenname") == 26){
			PlayerPrefs.SetInt("golem_atk", 4);
			PlayerPrefs.SetInt("golem_def", 2);
			PlayerPrefs.SetInt("golem_hp", 25);
		}
		if(PlayerPrefs.GetInt("chosenname") == 27){
			PlayerPrefs.SetInt("golem_atk", 4);
			PlayerPrefs.SetInt("golem_def", 2);
			PlayerPrefs.SetInt("golem_hp", 23);
		}
		if(PlayerPrefs.GetInt("chosenname") == 28){
			PlayerPrefs.SetInt("golem_atk", 6);
			PlayerPrefs.SetInt("golem_def", 4);
			PlayerPrefs.SetInt("golem_hp", 17);
		}
		if(PlayerPrefs.GetInt("chosenname") == 29){
			PlayerPrefs.SetInt("golem_atk", 2);
			PlayerPrefs.SetInt("golem_def", 2);
			PlayerPrefs.SetInt("golem_hp", 28);
		}
		if(PlayerPrefs.GetInt("chosenname") == 30){
			PlayerPrefs.SetInt("golem_atk", 7);
			PlayerPrefs.SetInt("golem_def", 7);
			PlayerPrefs.SetInt("golem_hp", 20);
		}
		if(PlayerPrefs.GetInt("chosenname") == 31){
			PlayerPrefs.SetInt("golem_atk", 7);
			PlayerPrefs.SetInt("golem_def", 7);
			PlayerPrefs.SetInt("golem_hp", 21);
		}
		if(PlayerPrefs.GetInt("chosenname") == 32){
			PlayerPrefs.SetInt("golem_atk", 8);
			PlayerPrefs.SetInt("golem_def", 6);
			PlayerPrefs.SetInt("golem_hp", 30);
		}
		if(PlayerPrefs.GetInt("chosenname") == 33){
			PlayerPrefs.SetInt("golem_atk", 7);
			PlayerPrefs.SetInt("golem_def", 7);
			PlayerPrefs.SetInt("golem_hp", 33);
		}
		if(PlayerPrefs.GetInt("chosenname") == 34){
			PlayerPrefs.SetInt("golem_atk", 6);
			PlayerPrefs.SetInt("golem_def", 6);
			PlayerPrefs.SetInt("golem_hp", 32);
		}
		if(PlayerPrefs.GetInt("chosenname") == 35){
			PlayerPrefs.SetInt("golem_atk", 6);
			PlayerPrefs.SetInt("golem_def", 7);
			PlayerPrefs.SetInt("golem_hp", 20);
		}
		if(PlayerPrefs.GetInt("chosenname") == 36){
			PlayerPrefs.SetInt("golem_atk", 6);
			PlayerPrefs.SetInt("golem_def", 5);
			PlayerPrefs.SetInt("golem_hp", 34);
		}
		if(PlayerPrefs.GetInt("chosenname") == 37){
			PlayerPrefs.SetInt("golem_atk", 6);
			PlayerPrefs.SetInt("golem_def", 4);
			PlayerPrefs.SetInt("golem_hp", 33);
		}
		if(PlayerPrefs.GetInt("chosenname") == 38){
			PlayerPrefs.SetInt("golem_atk", 7);
			PlayerPrefs.SetInt("golem_def", 7);
			PlayerPrefs.SetInt("golem_hp", 28);
		}
		if(PlayerPrefs.GetInt("chosenname") == 39){
			PlayerPrefs.SetInt("golem_atk", 5);
			PlayerPrefs.SetInt("golem_def", 6);
			PlayerPrefs.SetInt("golem_hp", 33);
		}
		if(PlayerPrefs.GetInt("chosenname") == 40){
			PlayerPrefs.SetInt("golem_atk", 10);
			PlayerPrefs.SetInt("golem_def", 11);
			PlayerPrefs.SetInt("golem_hp", 41);
		}
		if(PlayerPrefs.GetInt("chosenname") == 41){
			PlayerPrefs.SetInt("golem_atk", 8);
			PlayerPrefs.SetInt("golem_def", 9);
			PlayerPrefs.SetInt("golem_hp", 48);
		}
		if(PlayerPrefs.GetInt("chosenname") == 42){
			PlayerPrefs.SetInt("golem_atk", 10);
			PlayerPrefs.SetInt("golem_def", 11);
			PlayerPrefs.SetInt("golem_hp", 26);
		}
		if(PlayerPrefs.GetInt("chosenname") == 43){
			PlayerPrefs.SetInt("golem_atk", 10);
			PlayerPrefs.SetInt("golem_def", 9);
			PlayerPrefs.SetInt("golem_hp", 39);
		}
		if(PlayerPrefs.GetInt("chosenname") == 44){
			PlayerPrefs.SetInt("golem_atk", 9);
			PlayerPrefs.SetInt("golem_def", 7);
			PlayerPrefs.SetInt("golem_hp", 41);
		}
		if(PlayerPrefs.GetInt("chosenname") == 45){
			PlayerPrefs.SetInt("golem_atk", 8);
			PlayerPrefs.SetInt("golem_def", 8);
			PlayerPrefs.SetInt("golem_hp", 30);
		}
		if(PlayerPrefs.GetInt("chosenname") == 46){
			PlayerPrefs.SetInt("golem_atk", 6);
			PlayerPrefs.SetInt("golem_def", 8);
			PlayerPrefs.SetInt("golem_hp", 21);
		}
		if(PlayerPrefs.GetInt("chosenname") == 47){
			PlayerPrefs.SetInt("golem_atk", 11);
			PlayerPrefs.SetInt("golem_def", 10);
			PlayerPrefs.SetInt("golem_hp", 35);
		}
		if(PlayerPrefs.GetInt("chosenname") == 48){
			PlayerPrefs.SetInt("golem_atk", 13);
			PlayerPrefs.SetInt("golem_def", 15);
			PlayerPrefs.SetInt("golem_hp", 32);
		}
		if(PlayerPrefs.GetInt("chosenname") == 49){
			PlayerPrefs.SetInt("golem_atk", 12);
			PlayerPrefs.SetInt("golem_def", 13);
			PlayerPrefs.SetInt("golem_hp", 42);
		}
		if(PlayerPrefs.GetInt("chosenname") == 50){
			PlayerPrefs.SetInt("golem_atk", 8);
			PlayerPrefs.SetInt("golem_def", 14);
			PlayerPrefs.SetInt("golem_hp", 52);
		}
		if(PlayerPrefs.GetInt("chosenname") == 51){
			PlayerPrefs.SetInt("golem_atk", 7);
			PlayerPrefs.SetInt("golem_def", 10);
			PlayerPrefs.SetInt("golem_hp", 38);
		}
		if(PlayerPrefs.GetInt("chosenname") == 52){
			PlayerPrefs.SetInt("golem_atk", 12);
			PlayerPrefs.SetInt("golem_def", 14);
			PlayerPrefs.SetInt("golem_hp", 29);
		}
		if(PlayerPrefs.GetInt("chosenname") == 53){
			PlayerPrefs.SetInt("golem_atk", 14);
			PlayerPrefs.SetInt("golem_def", 13);
			PlayerPrefs.SetInt("golem_hp", 51);
		}
		if(PlayerPrefs.GetInt("chosenname") == 54){
			PlayerPrefs.SetInt("golem_atk", 8);
			PlayerPrefs.SetInt("golem_def", 11);
			PlayerPrefs.SetInt("golem_hp", 39);
		}
		if(PlayerPrefs.GetInt("chosenname") == 55){
			PlayerPrefs.SetInt("golem_atk", 8);
			PlayerPrefs.SetInt("golem_def", 14);
			PlayerPrefs.SetInt("golem_hp", 32);
		}
		if(PlayerPrefs.GetInt("chosenname") == 56){
			PlayerPrefs.SetInt("golem_atk", 10);
			PlayerPrefs.SetInt("golem_def", 10);
			PlayerPrefs.SetInt("golem_hp", 28);
		}
		if(PlayerPrefs.GetInt("chosenname") == 57){
			PlayerPrefs.SetInt("golem_atk", 10);
			PlayerPrefs.SetInt("golem_def", 17);
			PlayerPrefs.SetInt("golem_hp", 42);
		}
		if(PlayerPrefs.GetInt("chosenname") == 58){
			PlayerPrefs.SetInt("golem_atk", 8);
			PlayerPrefs.SetInt("golem_def", 8);
			PlayerPrefs.SetInt("golem_hp", 29);
		}
		if(PlayerPrefs.GetInt("chosenname") == 59){
			PlayerPrefs.SetInt("golem_atk", 6);
			PlayerPrefs.SetInt("golem_def", 10);
			PlayerPrefs.SetInt("golem_hp", 43);
		}
		if(PlayerPrefs.GetInt("chosenname") == 60){
			PlayerPrefs.SetInt("golem_atk", 7);
			PlayerPrefs.SetInt("golem_def", 10);
			PlayerPrefs.SetInt("golem_hp", 30);
		}
		if(PlayerPrefs.GetInt("chosenname") == 61){
			PlayerPrefs.SetInt("golem_atk", 11);
			PlayerPrefs.SetInt("golem_def", 7);
			PlayerPrefs.SetInt("golem_hp", 23);
		}
		if(PlayerPrefs.GetInt("chosenname") == 62){
			PlayerPrefs.SetInt("golem_atk", 13);
			PlayerPrefs.SetInt("golem_def", 13);
			PlayerPrefs.SetInt("golem_hp", 42);
		}
		if(PlayerPrefs.GetInt("chosenname") == 63){
			PlayerPrefs.SetInt("golem_atk", 9);
			PlayerPrefs.SetInt("golem_def", 11);
			PlayerPrefs.SetInt("golem_hp", 25);
		}
		if(PlayerPrefs.GetInt("chosenname") == 64){
			PlayerPrefs.SetInt("golem_atk", 13);
			PlayerPrefs.SetInt("golem_def", 17);
			PlayerPrefs.SetInt("golem_hp", 39);
		}
	}
}
