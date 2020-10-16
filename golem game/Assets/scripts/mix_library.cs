using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mix_library : MonoBehaviour {

//library of all acceptable synthesis combinations

	void Update () {



		//ONE STAR:
		if((PlayerPrefs.GetInt("leftmix") == 10 && PlayerPrefs.GetInt("rightmix") == 11)
		|| (PlayerPrefs.GetInt("leftmix") == 11 && PlayerPrefs.GetInt("rightmix") == 10)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 20);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 10 && PlayerPrefs.GetInt("rightmix") == 12)
		|| (PlayerPrefs.GetInt("leftmix") == 12 && PlayerPrefs.GetInt("rightmix") == 10)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 20);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 10 && PlayerPrefs.GetInt("rightmix") == 13)
		|| (PlayerPrefs.GetInt("leftmix") == 13 && PlayerPrefs.GetInt("rightmix") == 10)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 21);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 10 && PlayerPrefs.GetInt("rightmix") == 14)
		|| (PlayerPrefs.GetInt("leftmix") == 14 && PlayerPrefs.GetInt("rightmix") == 10)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 22);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 10 && PlayerPrefs.GetInt("rightmix") == 15)
		|| (PlayerPrefs.GetInt("leftmix") == 15 && PlayerPrefs.GetInt("rightmix") == 10)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 21);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 11 && PlayerPrefs.GetInt("rightmix") == 12)
		|| (PlayerPrefs.GetInt("leftmix") == 12 && PlayerPrefs.GetInt("rightmix") == 11)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 23);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 11 && PlayerPrefs.GetInt("rightmix") == 13)
		|| (PlayerPrefs.GetInt("leftmix") == 13 && PlayerPrefs.GetInt("rightmix") == 11)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 24);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 11 && PlayerPrefs.GetInt("rightmix") == 14)
		|| (PlayerPrefs.GetInt("leftmix") == 14 && PlayerPrefs.GetInt("rightmix") == 11)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 25);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 11 && PlayerPrefs.GetInt("rightmix") == 15)
		|| (PlayerPrefs.GetInt("leftmix") == 15 && PlayerPrefs.GetInt("rightmix") == 11)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 25);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 12 && PlayerPrefs.GetInt("rightmix") == 13)
		|| (PlayerPrefs.GetInt("leftmix") == 13 && PlayerPrefs.GetInt("rightmix") == 12)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 27);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 12 && PlayerPrefs.GetInt("rightmix") == 14)
		|| (PlayerPrefs.GetInt("leftmix") == 14 && PlayerPrefs.GetInt("rightmix") == 12)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 26);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 12 && PlayerPrefs.GetInt("rightmix") == 15)
		|| (PlayerPrefs.GetInt("leftmix") == 15 && PlayerPrefs.GetInt("rightmix") == 12)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 26);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 14 && PlayerPrefs.GetInt("rightmix") == 13)
		|| (PlayerPrefs.GetInt("leftmix") == 13 && PlayerPrefs.GetInt("rightmix") == 14)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 24);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 15 && PlayerPrefs.GetInt("rightmix") == 13)
		|| (PlayerPrefs.GetInt("leftmix") == 13 && PlayerPrefs.GetInt("rightmix") == 15)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 28);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 14 && PlayerPrefs.GetInt("rightmix") == 15)
		|| (PlayerPrefs.GetInt("leftmix") == 15 && PlayerPrefs.GetInt("rightmix") == 14)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 29);
		}



		//TWO STAR:
		else if((PlayerPrefs.GetInt("leftmix") == 1 && PlayerPrefs.GetInt("rightmix") == 2)
		|| (PlayerPrefs.GetInt("leftmix") == 2 && PlayerPrefs.GetInt("rightmix") == 1)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 6);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 1 && PlayerPrefs.GetInt("rightmix") == 3)
		|| (PlayerPrefs.GetInt("leftmix") == 3 && PlayerPrefs.GetInt("rightmix") == 1)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 8);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 1 && PlayerPrefs.GetInt("rightmix") == 4)
		|| (PlayerPrefs.GetInt("leftmix") == 4 && PlayerPrefs.GetInt("rightmix") == 1)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 30);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 1 && PlayerPrefs.GetInt("rightmix") == 16)
		|| (PlayerPrefs.GetInt("leftmix") == 16 && PlayerPrefs.GetInt("rightmix") == 1)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 31);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 1 && PlayerPrefs.GetInt("rightmix") == 18)
		|| (PlayerPrefs.GetInt("leftmix") == 18 && PlayerPrefs.GetInt("rightmix") == 1)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 6);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 1 && PlayerPrefs.GetInt("rightmix") == 19)
		|| (PlayerPrefs.GetInt("leftmix") == 19 && PlayerPrefs.GetInt("rightmix") == 1)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 6);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 1 && PlayerPrefs.GetInt("rightmix") == 20)
		|| (PlayerPrefs.GetInt("leftmix") == 20 && PlayerPrefs.GetInt("rightmix") == 1)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 33);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 1 && PlayerPrefs.GetInt("rightmix") == 22)
		|| (PlayerPrefs.GetInt("leftmix") == 22 && PlayerPrefs.GetInt("rightmix") == 1)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 6);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 1 && PlayerPrefs.GetInt("rightmix") == 26)
		|| (PlayerPrefs.GetInt("leftmix") == 26 && PlayerPrefs.GetInt("rightmix") == 1)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 6);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 2 && PlayerPrefs.GetInt("rightmix") == 3)
		|| (PlayerPrefs.GetInt("leftmix") == 3 && PlayerPrefs.GetInt("rightmix") == 2)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 7);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 2 && PlayerPrefs.GetInt("rightmix") == 17)
		|| (PlayerPrefs.GetInt("leftmix") == 17 && PlayerPrefs.GetInt("rightmix") == 2)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 32);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 2 && PlayerPrefs.GetInt("rightmix") == 20)
		|| (PlayerPrefs.GetInt("leftmix") == 20 && PlayerPrefs.GetInt("rightmix") == 2)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 7);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 2 && PlayerPrefs.GetInt("rightmix") == 23)
		|| (PlayerPrefs.GetInt("leftmix") == 23 && PlayerPrefs.GetInt("rightmix") == 2)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 7);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 2 && PlayerPrefs.GetInt("rightmix") == 27)
		|| (PlayerPrefs.GetInt("leftmix") == 27 && PlayerPrefs.GetInt("rightmix") == 2)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 7);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 2 && PlayerPrefs.GetInt("rightmix") == 29)
		|| (PlayerPrefs.GetInt("leftmix") == 29 && PlayerPrefs.GetInt("rightmix") == 2)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 7);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 3 && PlayerPrefs.GetInt("rightmix") == 5)
		|| (PlayerPrefs.GetInt("leftmix") == 5 && PlayerPrefs.GetInt("rightmix") == 3)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 34);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 3 && PlayerPrefs.GetInt("rightmix") == 16)
		|| (PlayerPrefs.GetInt("leftmix") == 16 && PlayerPrefs.GetInt("rightmix") == 3)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 8);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 3 && PlayerPrefs.GetInt("rightmix") == 18)
		|| (PlayerPrefs.GetInt("leftmix") == 18 && PlayerPrefs.GetInt("rightmix") == 3)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 8);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 3 && PlayerPrefs.GetInt("rightmix") == 24)
		|| (PlayerPrefs.GetInt("leftmix") == 24 && PlayerPrefs.GetInt("rightmix") == 3)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 8);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 3 && PlayerPrefs.GetInt("rightmix") == 27)
		|| (PlayerPrefs.GetInt("leftmix") == 27 && PlayerPrefs.GetInt("rightmix") == 3)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 8);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 4 && PlayerPrefs.GetInt("rightmix") == 5)
		|| (PlayerPrefs.GetInt("leftmix") == 5 && PlayerPrefs.GetInt("rightmix") == 4)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 9);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 4 && PlayerPrefs.GetInt("rightmix") == 16)
		|| (PlayerPrefs.GetInt("leftmix") == 16 && PlayerPrefs.GetInt("rightmix") == 4)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 30);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 4 && PlayerPrefs.GetInt("rightmix") == 18)
		|| (PlayerPrefs.GetInt("leftmix") == 18 && PlayerPrefs.GetInt("rightmix") == 4)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 30);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 4 && PlayerPrefs.GetInt("rightmix") == 21)
		|| (PlayerPrefs.GetInt("leftmix") == 21 && PlayerPrefs.GetInt("rightmix") == 4)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 35);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 4 && PlayerPrefs.GetInt("rightmix") == 24)
		|| (PlayerPrefs.GetInt("leftmix") == 24 && PlayerPrefs.GetInt("rightmix") == 4)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 30);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 4 && PlayerPrefs.GetInt("rightmix") == 27)
		|| (PlayerPrefs.GetInt("leftmix") == 27 && PlayerPrefs.GetInt("rightmix") == 4)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 30);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 5 && PlayerPrefs.GetInt("rightmix") == 19)
		|| (PlayerPrefs.GetInt("leftmix") == 19 && PlayerPrefs.GetInt("rightmix") == 5)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 58);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 5 && PlayerPrefs.GetInt("rightmix") == 20)
		|| (PlayerPrefs.GetInt("leftmix") == 20 && PlayerPrefs.GetInt("rightmix") == 5)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 34);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 5 && PlayerPrefs.GetInt("rightmix") == 21)
		|| (PlayerPrefs.GetInt("leftmix") == 21 && PlayerPrefs.GetInt("rightmix") == 5)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 34);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 5 && PlayerPrefs.GetInt("rightmix") == 22)
		|| (PlayerPrefs.GetInt("leftmix") == 22 && PlayerPrefs.GetInt("rightmix") == 5)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 9);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 5 && PlayerPrefs.GetInt("rightmix") == 23)
		|| (PlayerPrefs.GetInt("leftmix") == 23 && PlayerPrefs.GetInt("rightmix") == 5)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 39);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 5 && PlayerPrefs.GetInt("rightmix") == 24)
		|| (PlayerPrefs.GetInt("leftmix") == 24 && PlayerPrefs.GetInt("rightmix") == 5)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 9);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 5 && PlayerPrefs.GetInt("rightmix") == 25)
		|| (PlayerPrefs.GetInt("leftmix") == 25 && PlayerPrefs.GetInt("rightmix") == 5)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 9);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 5 && PlayerPrefs.GetInt("rightmix") == 26)
		|| (PlayerPrefs.GetInt("leftmix") == 26 && PlayerPrefs.GetInt("rightmix") == 5)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 34);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 5 && PlayerPrefs.GetInt("rightmix") == 27)
		|| (PlayerPrefs.GetInt("leftmix") == 27 && PlayerPrefs.GetInt("rightmix") == 5)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 36);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 5 && PlayerPrefs.GetInt("rightmix") == 29)
		|| (PlayerPrefs.GetInt("leftmix") == 29 && PlayerPrefs.GetInt("rightmix") == 5)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 34);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 16 && PlayerPrefs.GetInt("rightmix") == 18)
		|| (PlayerPrefs.GetInt("leftmix") == 18 && PlayerPrefs.GetInt("rightmix") == 16)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 31);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 16 && PlayerPrefs.GetInt("rightmix") == 19)
		|| (PlayerPrefs.GetInt("leftmix") == 19 && PlayerPrefs.GetInt("rightmix") == 16)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 58);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 16 && PlayerPrefs.GetInt("rightmix") == 20)
		|| (PlayerPrefs.GetInt("leftmix") == 20 && PlayerPrefs.GetInt("rightmix") == 16)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 33);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 16 && PlayerPrefs.GetInt("rightmix") == 23)
		|| (PlayerPrefs.GetInt("leftmix") == 23 && PlayerPrefs.GetInt("rightmix") == 16)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 39);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 16 && PlayerPrefs.GetInt("rightmix") == 24)
		|| (PlayerPrefs.GetInt("leftmix") == 24 && PlayerPrefs.GetInt("rightmix") == 16)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 31);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 16 && PlayerPrefs.GetInt("rightmix") == 27)
		|| (PlayerPrefs.GetInt("leftmix") == 27 && PlayerPrefs.GetInt("rightmix") == 16)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 31);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 17 && PlayerPrefs.GetInt("rightmix") == 18)
		|| (PlayerPrefs.GetInt("leftmix") == 18 && PlayerPrefs.GetInt("rightmix") == 17)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 32);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 17 && PlayerPrefs.GetInt("rightmix") == 19)
		|| (PlayerPrefs.GetInt("leftmix") == 19 && PlayerPrefs.GetInt("rightmix") == 17)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 32);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 17 && PlayerPrefs.GetInt("rightmix") == 26)
		|| (PlayerPrefs.GetInt("leftmix") == 26 && PlayerPrefs.GetInt("rightmix") == 17)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 32);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 17 && PlayerPrefs.GetInt("rightmix") == 27)
		|| (PlayerPrefs.GetInt("leftmix") == 27 && PlayerPrefs.GetInt("rightmix") == 17)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 36);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 18 && PlayerPrefs.GetInt("rightmix") == 20)
		|| (PlayerPrefs.GetInt("leftmix") == 20 && PlayerPrefs.GetInt("rightmix") == 18)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 33);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 19 && PlayerPrefs.GetInt("rightmix") == 29)
		|| (PlayerPrefs.GetInt("leftmix") == 29 && PlayerPrefs.GetInt("rightmix") == 19)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 37);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 20 && PlayerPrefs.GetInt("rightmix") == 24)
		|| (PlayerPrefs.GetInt("leftmix") == 24 && PlayerPrefs.GetInt("rightmix") == 20)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 33);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 20 && PlayerPrefs.GetInt("rightmix") == 27)
		|| (PlayerPrefs.GetInt("leftmix") == 27 && PlayerPrefs.GetInt("rightmix") == 20)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 33);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 21 && PlayerPrefs.GetInt("rightmix") == 22)
		|| (PlayerPrefs.GetInt("leftmix") == 22 && PlayerPrefs.GetInt("rightmix") == 21)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 35);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 21 && PlayerPrefs.GetInt("rightmix") == 24)
		|| (PlayerPrefs.GetInt("leftmix") == 24 && PlayerPrefs.GetInt("rightmix") == 21)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 35);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 21 && PlayerPrefs.GetInt("rightmix") == 25)
		|| (PlayerPrefs.GetInt("leftmix") == 25 && PlayerPrefs.GetInt("rightmix") == 21)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 35);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 22 && PlayerPrefs.GetInt("rightmix") == 28)
		|| (PlayerPrefs.GetInt("leftmix") == 28 && PlayerPrefs.GetInt("rightmix") == 22)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 46);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 22 && PlayerPrefs.GetInt("rightmix") == 29)
		|| (PlayerPrefs.GetInt("leftmix") == 29 && PlayerPrefs.GetInt("rightmix") == 22)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 37);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 24 && PlayerPrefs.GetInt("rightmix") == 28)
		|| (PlayerPrefs.GetInt("leftmix") == 28 && PlayerPrefs.GetInt("rightmix") == 24)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 46);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 25 && PlayerPrefs.GetInt("rightmix") == 28)
		|| (PlayerPrefs.GetInt("leftmix") == 28 && PlayerPrefs.GetInt("rightmix") == 25)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 46);
		}



		//THREE STAR:
		else if((PlayerPrefs.GetInt("leftmix") == 6 && PlayerPrefs.GetInt("rightmix") == 7)
		|| (PlayerPrefs.GetInt("leftmix") == 7 && PlayerPrefs.GetInt("rightmix") == 6)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 40);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 6 && PlayerPrefs.GetInt("rightmix") == 9)
		|| (PlayerPrefs.GetInt("leftmix") == 9 && PlayerPrefs.GetInt("rightmix") == 6)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 63);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 6 && PlayerPrefs.GetInt("rightmix") == 30)
		|| (PlayerPrefs.GetInt("leftmix") == 30 && PlayerPrefs.GetInt("rightmix") == 6)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 63);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 6 && PlayerPrefs.GetInt("rightmix") == 32)
		|| (PlayerPrefs.GetInt("leftmix") == 32 && PlayerPrefs.GetInt("rightmix") == 6)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 61);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 6 && PlayerPrefs.GetInt("rightmix") == 35)
		|| (PlayerPrefs.GetInt("leftmix") == 35 && PlayerPrefs.GetInt("rightmix") == 6)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 63);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 6 && PlayerPrefs.GetInt("rightmix") == 36)
		|| (PlayerPrefs.GetInt("leftmix") == 36 && PlayerPrefs.GetInt("rightmix") == 6)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 40);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 6 && PlayerPrefs.GetInt("rightmix") == 39)
		|| (PlayerPrefs.GetInt("leftmix") == 39 && PlayerPrefs.GetInt("rightmix") == 6)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 40);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 6 && PlayerPrefs.GetInt("rightmix") == 46)
		|| (PlayerPrefs.GetInt("leftmix") == 46 && PlayerPrefs.GetInt("rightmix") == 6)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 47);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 7 && PlayerPrefs.GetInt("rightmix") == 35)
		|| (PlayerPrefs.GetInt("leftmix") == 35 && PlayerPrefs.GetInt("rightmix") == 7)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 44);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 8 && PlayerPrefs.GetInt("rightmix") == 9)
		|| (PlayerPrefs.GetInt("leftmix") == 9 && PlayerPrefs.GetInt("rightmix") == 8)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 41);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 8 && PlayerPrefs.GetInt("rightmix") == 46)
		|| (PlayerPrefs.GetInt("leftmix") == 46 && PlayerPrefs.GetInt("rightmix") == 8)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 47);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 8 && PlayerPrefs.GetInt("rightmix") == 58)
		|| (PlayerPrefs.GetInt("leftmix") == 58 && PlayerPrefs.GetInt("rightmix") == 8)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 59);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 9 && PlayerPrefs.GetInt("rightmix") == 30)
		|| (PlayerPrefs.GetInt("leftmix") == 30 && PlayerPrefs.GetInt("rightmix") == 9)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 42);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 9 && PlayerPrefs.GetInt("rightmix") == 31)
		|| (PlayerPrefs.GetInt("leftmix") == 31 && PlayerPrefs.GetInt("rightmix") == 9)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 43);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 9 && PlayerPrefs.GetInt("rightmix") == 33)
		|| (PlayerPrefs.GetInt("leftmix") == 33 && PlayerPrefs.GetInt("rightmix") == 9)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 41);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 9 && PlayerPrefs.GetInt("rightmix") == 34)
		|| (PlayerPrefs.GetInt("leftmix") == 34 && PlayerPrefs.GetInt("rightmix") == 9)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 41);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 9 && PlayerPrefs.GetInt("rightmix") == 35)
		|| (PlayerPrefs.GetInt("leftmix") == 35 && PlayerPrefs.GetInt("rightmix") == 9)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 56);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 9 && PlayerPrefs.GetInt("rightmix") == 37)
		|| (PlayerPrefs.GetInt("leftmix") == 37 && PlayerPrefs.GetInt("rightmix") == 9)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 41);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 9 && PlayerPrefs.GetInt("rightmix") == 38)
		|| (PlayerPrefs.GetInt("leftmix") == 38 && PlayerPrefs.GetInt("rightmix") == 9)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 45);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 9 && PlayerPrefs.GetInt("rightmix") == 39)
		|| (PlayerPrefs.GetInt("leftmix") == 39 && PlayerPrefs.GetInt("rightmix") == 9)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 51);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 30 && PlayerPrefs.GetInt("rightmix") == 32)
		|| (PlayerPrefs.GetInt("leftmix") == 32 && PlayerPrefs.GetInt("rightmix") == 30)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 42);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 30 && PlayerPrefs.GetInt("rightmix") == 36)
		|| (PlayerPrefs.GetInt("leftmix") == 36 && PlayerPrefs.GetInt("rightmix") == 30)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 42);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 30 && PlayerPrefs.GetInt("rightmix") == 37)
		|| (PlayerPrefs.GetInt("leftmix") == 37 && PlayerPrefs.GetInt("rightmix") == 30)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 42);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 30 && PlayerPrefs.GetInt("rightmix") == 39)
		|| (PlayerPrefs.GetInt("leftmix") == 39 && PlayerPrefs.GetInt("rightmix") == 30)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 51);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 30 && PlayerPrefs.GetInt("rightmix") == 46)
		|| (PlayerPrefs.GetInt("leftmix") == 46 && PlayerPrefs.GetInt("rightmix") == 30)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 47);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 31 && PlayerPrefs.GetInt("rightmix") == 32)
		|| (PlayerPrefs.GetInt("leftmix") == 32 && PlayerPrefs.GetInt("rightmix") == 31)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 43);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 31 && PlayerPrefs.GetInt("rightmix") == 34)
		|| (PlayerPrefs.GetInt("leftmix") == 34 && PlayerPrefs.GetInt("rightmix") == 31)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 60);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 31 && PlayerPrefs.GetInt("rightmix") == 35)
		|| (PlayerPrefs.GetInt("leftmix") == 35 && PlayerPrefs.GetInt("rightmix") == 31)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 56);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 31 && PlayerPrefs.GetInt("rightmix") == 36)
		|| (PlayerPrefs.GetInt("leftmix") == 36 && PlayerPrefs.GetInt("rightmix") == 31)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 43);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 31 && PlayerPrefs.GetInt("rightmix") == 37)
		|| (PlayerPrefs.GetInt("leftmix") == 37 && PlayerPrefs.GetInt("rightmix") == 31)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 43);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 31 && PlayerPrefs.GetInt("rightmix") == 39)
		|| (PlayerPrefs.GetInt("leftmix") == 39 && PlayerPrefs.GetInt("rightmix") == 31)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 54);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 31 && PlayerPrefs.GetInt("rightmix") == 46)
		|| (PlayerPrefs.GetInt("leftmix") == 46 && PlayerPrefs.GetInt("rightmix") == 31)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 47);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 32 && PlayerPrefs.GetInt("rightmix") == 38)
		|| (PlayerPrefs.GetInt("leftmix") == 38 && PlayerPrefs.GetInt("rightmix") == 32)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 45);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 32 && PlayerPrefs.GetInt("rightmix") == 58)
		|| (PlayerPrefs.GetInt("leftmix") == 58 && PlayerPrefs.GetInt("rightmix") == 32)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 61);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 33 && PlayerPrefs.GetInt("rightmix") == 46)
		|| (PlayerPrefs.GetInt("leftmix") == 46 && PlayerPrefs.GetInt("rightmix") == 33)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 47);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 33 && PlayerPrefs.GetInt("rightmix") == 58)
		|| (PlayerPrefs.GetInt("leftmix") == 58 && PlayerPrefs.GetInt("rightmix") == 33)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 59);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 34 && PlayerPrefs.GetInt("rightmix") == 35)
		|| (PlayerPrefs.GetInt("leftmix") == 35 && PlayerPrefs.GetInt("rightmix") == 34)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 56);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 34 && PlayerPrefs.GetInt("rightmix") == 37)
		|| (PlayerPrefs.GetInt("leftmix") == 37 && PlayerPrefs.GetInt("rightmix") == 34)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 60);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 34 && PlayerPrefs.GetInt("rightmix") == 39)
		|| (PlayerPrefs.GetInt("leftmix") == 39 && PlayerPrefs.GetInt("rightmix") == 34)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 54);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 34 && PlayerPrefs.GetInt("rightmix") == 58)
		|| (PlayerPrefs.GetInt("leftmix") == 58 && PlayerPrefs.GetInt("rightmix") == 34)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 59);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 35 && PlayerPrefs.GetInt("rightmix") == 36)
		|| (PlayerPrefs.GetInt("leftmix") == 36 && PlayerPrefs.GetInt("rightmix") == 35)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 44);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 35 && PlayerPrefs.GetInt("rightmix") == 39)
		|| (PlayerPrefs.GetInt("leftmix") == 39 && PlayerPrefs.GetInt("rightmix") == 35)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 44);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 35 && PlayerPrefs.GetInt("rightmix") == 58)
		|| (PlayerPrefs.GetInt("leftmix") == 58 && PlayerPrefs.GetInt("rightmix") == 35)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 56);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 36 && PlayerPrefs.GetInt("rightmix") == 38)
		|| (PlayerPrefs.GetInt("leftmix") == 38 && PlayerPrefs.GetInt("rightmix") == 36)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 45);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 37 && PlayerPrefs.GetInt("rightmix") == 38)
		|| (PlayerPrefs.GetInt("leftmix") == 38 && PlayerPrefs.GetInt("rightmix") == 37)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 45);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 37 && PlayerPrefs.GetInt("rightmix") == 58)
		|| (PlayerPrefs.GetInt("leftmix") == 58 && PlayerPrefs.GetInt("rightmix") == 37)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 59);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 38 && PlayerPrefs.GetInt("rightmix") == 39)
		|| (PlayerPrefs.GetInt("leftmix") == 39 && PlayerPrefs.GetInt("rightmix") == 38)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 54);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 39 && PlayerPrefs.GetInt("rightmix") == 46)
		|| (PlayerPrefs.GetInt("leftmix") == 46 && PlayerPrefs.GetInt("rightmix") == 39)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 51);
		}




		//FOUR STAR:
		else if((PlayerPrefs.GetInt("leftmix") == 40 && PlayerPrefs.GetInt("rightmix") == 41)
		|| (PlayerPrefs.GetInt("leftmix") == 41 && PlayerPrefs.GetInt("rightmix") == 40)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 49);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 40 && PlayerPrefs.GetInt("rightmix") == 42)
		|| (PlayerPrefs.GetInt("leftmix") == 42 && PlayerPrefs.GetInt("rightmix") == 40)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 49);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 40 && PlayerPrefs.GetInt("rightmix") == 43)
		|| (PlayerPrefs.GetInt("leftmix") == 43 && PlayerPrefs.GetInt("rightmix") == 40)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 49);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 40 && PlayerPrefs.GetInt("rightmix") == 45)
		|| (PlayerPrefs.GetInt("leftmix") == 45 && PlayerPrefs.GetInt("rightmix") == 40)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 49);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 40 && PlayerPrefs.GetInt("rightmix") == 47)
		|| (PlayerPrefs.GetInt("leftmix") == 47 && PlayerPrefs.GetInt("rightmix") == 40)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 53);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 41 && PlayerPrefs.GetInt("rightmix") == 42)
		|| (PlayerPrefs.GetInt("leftmix") == 42 && PlayerPrefs.GetInt("rightmix") == 41)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 48);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 41 && PlayerPrefs.GetInt("rightmix") == 43)
		|| (PlayerPrefs.GetInt("leftmix") == 43 && PlayerPrefs.GetInt("rightmix") == 41)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 48);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 41 && PlayerPrefs.GetInt("rightmix") == 44)
		|| (PlayerPrefs.GetInt("leftmix") == 44 && PlayerPrefs.GetInt("rightmix") == 41)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 50);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 41 && PlayerPrefs.GetInt("rightmix") == 45)
		|| (PlayerPrefs.GetInt("leftmix") == 45 && PlayerPrefs.GetInt("rightmix") == 41)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 48);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 41 && PlayerPrefs.GetInt("rightmix") == 51)
		|| (PlayerPrefs.GetInt("leftmix") == 51 && PlayerPrefs.GetInt("rightmix") == 41)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 52);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 41 && PlayerPrefs.GetInt("rightmix") == 54)
		|| (PlayerPrefs.GetInt("leftmix") == 54 && PlayerPrefs.GetInt("rightmix") == 41)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 55);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 42 && PlayerPrefs.GetInt("rightmix") == 44)
		|| (PlayerPrefs.GetInt("leftmix") == 44 && PlayerPrefs.GetInt("rightmix") == 42)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 50);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 42 && PlayerPrefs.GetInt("rightmix") == 51)
		|| (PlayerPrefs.GetInt("leftmix") == 51 && PlayerPrefs.GetInt("rightmix") == 42)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 52);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 42 && PlayerPrefs.GetInt("rightmix") == 54)
		|| (PlayerPrefs.GetInt("leftmix") == 54 && PlayerPrefs.GetInt("rightmix") == 42)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 55);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 43 && PlayerPrefs.GetInt("rightmix") == 44)
		|| (PlayerPrefs.GetInt("leftmix") == 44 && PlayerPrefs.GetInt("rightmix") == 43)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 50);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 43 && PlayerPrefs.GetInt("rightmix") == 51)
		|| (PlayerPrefs.GetInt("leftmix") == 51 && PlayerPrefs.GetInt("rightmix") == 43)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 52);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 43 && PlayerPrefs.GetInt("rightmix") == 54)
		|| (PlayerPrefs.GetInt("leftmix") == 54 && PlayerPrefs.GetInt("rightmix") == 43)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 55);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 44 && PlayerPrefs.GetInt("rightmix") == 45)
		|| (PlayerPrefs.GetInt("leftmix") == 45 && PlayerPrefs.GetInt("rightmix") == 44)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 50);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 44 && PlayerPrefs.GetInt("rightmix") == 47)
		|| (PlayerPrefs.GetInt("leftmix") == 47 && PlayerPrefs.GetInt("rightmix") == 44)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 53);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 45 && PlayerPrefs.GetInt("rightmix") == 51)
		|| (PlayerPrefs.GetInt("leftmix") == 51 && PlayerPrefs.GetInt("rightmix") == 45)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 52);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 45 && PlayerPrefs.GetInt("rightmix") == 54)
		|| (PlayerPrefs.GetInt("leftmix") == 54 && PlayerPrefs.GetInt("rightmix") == 45)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 55);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 47 && PlayerPrefs.GetInt("rightmix") == 51)
		|| (PlayerPrefs.GetInt("leftmix") == 51 && PlayerPrefs.GetInt("rightmix") == 47)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 53);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 51 && PlayerPrefs.GetInt("rightmix") == 56)
		|| (PlayerPrefs.GetInt("leftmix") == 56 && PlayerPrefs.GetInt("rightmix") == 51)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 57);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 51 && PlayerPrefs.GetInt("rightmix") == 59)
		|| (PlayerPrefs.GetInt("leftmix") == 59 && PlayerPrefs.GetInt("rightmix") == 51)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 57);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 54 && PlayerPrefs.GetInt("rightmix") == 61)
		|| (PlayerPrefs.GetInt("leftmix") == 61 && PlayerPrefs.GetInt("rightmix") == 54)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 62);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 54 && PlayerPrefs.GetInt("rightmix") == 63)
		|| (PlayerPrefs.GetInt("leftmix") == 63 && PlayerPrefs.GetInt("rightmix") == 54)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 64);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 56 && PlayerPrefs.GetInt("rightmix") == 61)
		|| (PlayerPrefs.GetInt("leftmix") == 61 && PlayerPrefs.GetInt("rightmix") == 56)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 62);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 56 && PlayerPrefs.GetInt("rightmix") == 63)
		|| (PlayerPrefs.GetInt("leftmix") == 63 && PlayerPrefs.GetInt("rightmix") == 56)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 64);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 59 && PlayerPrefs.GetInt("rightmix") == 61)
		|| (PlayerPrefs.GetInt("leftmix") == 61 && PlayerPrefs.GetInt("rightmix") == 59)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 62);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 59 && PlayerPrefs.GetInt("rightmix") == 63)
		|| (PlayerPrefs.GetInt("leftmix") == 63 && PlayerPrefs.GetInt("rightmix") == 59)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 64);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 60 && PlayerPrefs.GetInt("rightmix") == 61)
		|| (PlayerPrefs.GetInt("leftmix") == 61 && PlayerPrefs.GetInt("rightmix") == 60)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 62);
		}
		else if((PlayerPrefs.GetInt("leftmix") == 60 && PlayerPrefs.GetInt("rightmix") == 63)
		|| (PlayerPrefs.GetInt("leftmix") == 63 && PlayerPrefs.GetInt("rightmix") == 60)){
			PlayerPrefs.SetInt("mixable", 1);
			PlayerPrefs.SetInt("mixproduct", 64);
		}




		else{
			PlayerPrefs.SetInt("mixable", 0);
		}
	}
}
