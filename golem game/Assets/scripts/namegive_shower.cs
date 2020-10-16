using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class namegive_shower : MonoBehaviour {

	//leftmix and rightmix show respective sides of mix menu,
	//else shows soul id of selected sacred name in namegive menu

	public Sprite n01, n02, n03, n04, n05, n06, n07, n08, n09, n10, n11, n12, n13,
	n14, n15, n16, n17, n18, n19, n20, n21, n22, n23, n24, n25, n26, n27, n28, n29,
	n30, n31, n32, n33, n34, n35, n36, n37, n38, n39, n40, n41, n42, n43,	n44, n45,
	n46, n47, n48, n49, n50, n51, n52, n53,	n54, n55, n56, n57, n58, n59, n60, n61,
	n62, n63,	n64;
	SpriteRenderer renderer;
	public bool leftmix, rightmix;

	void Start () {
		renderer = GetComponent<SpriteRenderer>();
	}

	void Update () {
		if(leftmix){
			if(PlayerPrefs.GetInt("mixable") == 0){
				renderer.color = new Color(.3f,.3f,.3f,.3f);
			}
			if(PlayerPrefs.GetInt("mixable") == 1){
				renderer.color = new Color(1,1,1,1);
			}
			if(PlayerPrefs.GetInt("leftmix") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("leftmix") == 1){
				renderer.enabled = true;
				renderer.sprite = n01;
			}
			if(PlayerPrefs.GetInt("leftmix") == 2){
				renderer.enabled = true;
				renderer.sprite = n02;
			}
			if(PlayerPrefs.GetInt("leftmix") == 3){
				renderer.enabled = true;
				renderer.sprite = n03;
			}
			if(PlayerPrefs.GetInt("leftmix") == 4){
				renderer.enabled = true;
				renderer.sprite = n04;
			}
			if(PlayerPrefs.GetInt("leftmix") == 5){
				renderer.enabled = true;
				renderer.sprite = n05;
			}
			if(PlayerPrefs.GetInt("leftmix") == 6){
				renderer.enabled = true;
				renderer.sprite = n06;
			}
			if(PlayerPrefs.GetInt("leftmix") == 7){
				renderer.enabled = true;
				renderer.sprite = n07;
			}
			if(PlayerPrefs.GetInt("leftmix") == 8){
				renderer.enabled = true;
				renderer.sprite = n08;
			}
			if(PlayerPrefs.GetInt("leftmix") == 9){
				renderer.enabled = true;
				renderer.sprite = n09;
			}
			if(PlayerPrefs.GetInt("leftmix") == 10){
				renderer.enabled = true;
				renderer.sprite = n10;
			}
			if(PlayerPrefs.GetInt("leftmix") == 11){
				renderer.enabled = true;
				renderer.sprite = n11;
			}
			if(PlayerPrefs.GetInt("leftmix") == 12){
				renderer.enabled = true;
				renderer.sprite = n12;
			}
			if(PlayerPrefs.GetInt("leftmix") == 13){
				renderer.enabled = true;
				renderer.sprite = n13;
			}
			if(PlayerPrefs.GetInt("leftmix") == 14){
				renderer.enabled = true;
				renderer.sprite = n14;
			}
			if(PlayerPrefs.GetInt("leftmix") == 15){
				renderer.enabled = true;
				renderer.sprite = n15;
			}
			if(PlayerPrefs.GetInt("leftmix") == 16){
				renderer.enabled = true;
				renderer.sprite = n16;
			}
			if(PlayerPrefs.GetInt("leftmix") == 17){
				renderer.enabled = true;
				renderer.sprite = n17;
			}
			if(PlayerPrefs.GetInt("leftmix") == 18){
				renderer.enabled = true;
				renderer.sprite = n18;
			}
			if(PlayerPrefs.GetInt("leftmix") == 19){
				renderer.enabled = true;
				renderer.sprite = n19;
			}
			if(PlayerPrefs.GetInt("leftmix") == 20){
				renderer.enabled = true;
				renderer.sprite = n20;
			}
			if(PlayerPrefs.GetInt("leftmix") == 21){
				renderer.enabled = true;
				renderer.sprite = n21;
			}
			if(PlayerPrefs.GetInt("leftmix") == 22){
				renderer.enabled = true;
				renderer.sprite = n22;
			}
			if(PlayerPrefs.GetInt("leftmix") == 23){
				renderer.enabled = true;
				renderer.sprite = n23;
			}
			if(PlayerPrefs.GetInt("leftmix") == 24){
				renderer.enabled = true;
				renderer.sprite = n24;
			}
			if(PlayerPrefs.GetInt("leftmix") == 25){
				renderer.enabled = true;
				renderer.sprite = n25;
			}
			if(PlayerPrefs.GetInt("leftmix") == 26){
				renderer.enabled = true;
				renderer.sprite = n26;
			}
			if(PlayerPrefs.GetInt("leftmix") == 27){
				renderer.enabled = true;
				renderer.sprite = n27;
			}
			if(PlayerPrefs.GetInt("leftmix") == 28){
				renderer.enabled = true;
				renderer.sprite = n28;
			}
			if(PlayerPrefs.GetInt("leftmix") == 29){
				renderer.enabled = true;
				renderer.sprite = n29;
			}
			if(PlayerPrefs.GetInt("leftmix") == 30){
				renderer.enabled = true;
				renderer.sprite = n30;
			}
			if(PlayerPrefs.GetInt("leftmix") == 31){
				renderer.enabled = true;
				renderer.sprite = n31;
			}
			if(PlayerPrefs.GetInt("leftmix") == 32){
				renderer.enabled = true;
				renderer.sprite = n32;
			}
			if(PlayerPrefs.GetInt("leftmix") == 33){
				renderer.enabled = true;
				renderer.sprite = n33;
			}
			if(PlayerPrefs.GetInt("leftmix") == 34){
				renderer.enabled = true;
				renderer.sprite = n34;
			}
			if(PlayerPrefs.GetInt("leftmix") == 35){
				renderer.enabled = true;
				renderer.sprite = n35;
			}
			if(PlayerPrefs.GetInt("leftmix") == 36){
				renderer.enabled = true;
				renderer.sprite = n36;
			}
			if(PlayerPrefs.GetInt("leftmix") == 37){
				renderer.enabled = true;
				renderer.sprite = n37;
			}
			if(PlayerPrefs.GetInt("leftmix") == 38){
				renderer.enabled = true;
				renderer.sprite = n38;
			}
			if(PlayerPrefs.GetInt("leftmix") == 39){
				renderer.enabled = true;
				renderer.sprite = n39;
			}
			if(PlayerPrefs.GetInt("leftmix") == 40){
				renderer.enabled = true;
				renderer.sprite = n40;
			}
			if(PlayerPrefs.GetInt("leftmix") == 41){
				renderer.enabled = true;
				renderer.sprite = n41;
			}
			if(PlayerPrefs.GetInt("leftmix") == 42){
				renderer.enabled = true;
				renderer.sprite = n42;
			}
			if(PlayerPrefs.GetInt("leftmix") == 43){
				renderer.enabled = true;
				renderer.sprite = n43;
			}
			if(PlayerPrefs.GetInt("leftmix") == 44){
				renderer.enabled = true;
				renderer.sprite = n44;
			}
			if(PlayerPrefs.GetInt("leftmix") == 45){
				renderer.enabled = true;
				renderer.sprite = n45;
			}
			if(PlayerPrefs.GetInt("leftmix") == 46){
				renderer.enabled = true;
				renderer.sprite = n46;
			}
			if(PlayerPrefs.GetInt("leftmix") == 47){
				renderer.enabled = true;
				renderer.sprite = n47;
			}
			if(PlayerPrefs.GetInt("leftmix") == 48){
				renderer.enabled = true;
				renderer.sprite = n48;
			}
			if(PlayerPrefs.GetInt("leftmix") == 49){
				renderer.enabled = true;
				renderer.sprite = n49;
			}
			if(PlayerPrefs.GetInt("leftmix") == 50){
				renderer.enabled = true;
				renderer.sprite = n50;
			}
			if(PlayerPrefs.GetInt("leftmix") == 51){
				renderer.enabled = true;
				renderer.sprite = n51;
			}
			if(PlayerPrefs.GetInt("leftmix") == 52){
				renderer.enabled = true;
				renderer.sprite = n52;
			}
			if(PlayerPrefs.GetInt("leftmix") == 53){
				renderer.enabled = true;
				renderer.sprite = n53;
			}
			if(PlayerPrefs.GetInt("leftmix") == 54){
				renderer.enabled = true;
				renderer.sprite = n54;
			}
			if(PlayerPrefs.GetInt("leftmix") == 55){
				renderer.enabled = true;
				renderer.sprite = n55;
			}
			if(PlayerPrefs.GetInt("leftmix") == 56){
				renderer.enabled = true;
				renderer.sprite = n56;
			}
			if(PlayerPrefs.GetInt("leftmix") == 57){
				renderer.enabled = true;
				renderer.sprite = n57;
			}
			if(PlayerPrefs.GetInt("leftmix") == 58){
				renderer.enabled = true;
				renderer.sprite = n58;
			}
			if(PlayerPrefs.GetInt("leftmix") == 59){
				renderer.enabled = true;
				renderer.sprite = n59;
			}
			if(PlayerPrefs.GetInt("leftmix") == 60){
				renderer.enabled = true;
				renderer.sprite = n60;
			}
			if(PlayerPrefs.GetInt("leftmix") == 61){
				renderer.enabled = true;
				renderer.sprite = n61;
			}
			if(PlayerPrefs.GetInt("leftmix") == 62){
				renderer.enabled = true;
				renderer.sprite = n62;
			}
			if(PlayerPrefs.GetInt("leftmix") == 63){
				renderer.enabled = true;
				renderer.sprite = n63;
			}
			if(PlayerPrefs.GetInt("leftmix") == 64){
				renderer.enabled = true;
				renderer.sprite = n64;
			}
		}
		else if(rightmix){
			if(PlayerPrefs.GetInt("mixable") == 0){
				renderer.color = new Color(.3f,.3f,.3f,.3f);
			}
			if(PlayerPrefs.GetInt("mixable") == 1){
				renderer.color = new Color(1,1,1,1);
			}
			if(PlayerPrefs.GetInt("rightmix") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("rightmix") == 1){
				renderer.enabled = true;
				renderer.sprite = n01;
			}
			if(PlayerPrefs.GetInt("rightmix") == 2){
				renderer.enabled = true;
				renderer.sprite = n02;
			}
			if(PlayerPrefs.GetInt("rightmix") == 3){
				renderer.enabled = true;
				renderer.sprite = n03;
			}
			if(PlayerPrefs.GetInt("rightmix") == 4){
				renderer.enabled = true;
				renderer.sprite = n04;
			}
			if(PlayerPrefs.GetInt("rightmix") == 5){
				renderer.enabled = true;
				renderer.sprite = n05;
			}
			if(PlayerPrefs.GetInt("rightmix") == 6){
				renderer.enabled = true;
				renderer.sprite = n06;
			}
			if(PlayerPrefs.GetInt("rightmix") == 7){
				renderer.enabled = true;
				renderer.sprite = n07;
			}
			if(PlayerPrefs.GetInt("rightmix") == 8){
				renderer.enabled = true;
				renderer.sprite = n08;
			}
			if(PlayerPrefs.GetInt("rightmix") == 9){
				renderer.enabled = true;
				renderer.sprite = n09;
			}
			if(PlayerPrefs.GetInt("rightmix") == 10){
				renderer.enabled = true;
				renderer.sprite = n10;
			}
			if(PlayerPrefs.GetInt("rightmix") == 11){
				renderer.enabled = true;
				renderer.sprite = n11;
			}
			if(PlayerPrefs.GetInt("rightmix") == 12){
				renderer.enabled = true;
				renderer.sprite = n12;
			}
			if(PlayerPrefs.GetInt("rightmix") == 13){
				renderer.enabled = true;
				renderer.sprite = n13;
			}
			if(PlayerPrefs.GetInt("rightmix") == 14){
				renderer.enabled = true;
				renderer.sprite = n14;
			}
			if(PlayerPrefs.GetInt("rightmix") == 15){
				renderer.enabled = true;
				renderer.sprite = n15;
			}
			if(PlayerPrefs.GetInt("rightmix") == 16){
				renderer.enabled = true;
				renderer.sprite = n16;
			}
			if(PlayerPrefs.GetInt("rightmix") == 17){
				renderer.enabled = true;
				renderer.sprite = n17;
			}
			if(PlayerPrefs.GetInt("rightmix") == 18){
				renderer.enabled = true;
				renderer.sprite = n18;
			}
			if(PlayerPrefs.GetInt("rightmix") == 19){
				renderer.enabled = true;
				renderer.sprite = n19;
			}
			if(PlayerPrefs.GetInt("rightmix") == 20){
				renderer.enabled = true;
				renderer.sprite = n20;
			}
			if(PlayerPrefs.GetInt("rightmix") == 21){
				renderer.enabled = true;
				renderer.sprite = n21;
			}
			if(PlayerPrefs.GetInt("rightmix") == 22){
				renderer.enabled = true;
				renderer.sprite = n22;
			}
			if(PlayerPrefs.GetInt("rightmix") == 23){
				renderer.enabled = true;
				renderer.sprite = n23;
			}
			if(PlayerPrefs.GetInt("rightmix") == 24){
				renderer.enabled = true;
				renderer.sprite = n24;
			}
			if(PlayerPrefs.GetInt("rightmix") == 25){
				renderer.enabled = true;
				renderer.sprite = n25;
			}
			if(PlayerPrefs.GetInt("rightmix") == 26){
				renderer.enabled = true;
				renderer.sprite = n26;
			}
			if(PlayerPrefs.GetInt("rightmix") == 27){
				renderer.enabled = true;
				renderer.sprite = n27;
			}
			if(PlayerPrefs.GetInt("rightmix") == 28){
				renderer.enabled = true;
				renderer.sprite = n28;
			}
			if(PlayerPrefs.GetInt("rightmix") == 29){
				renderer.enabled = true;
				renderer.sprite = n29;
			}
			if(PlayerPrefs.GetInt("rightmix") == 30){
				renderer.enabled = true;
				renderer.sprite = n30;
			}
			if(PlayerPrefs.GetInt("rightmix") == 31){
				renderer.enabled = true;
				renderer.sprite = n31;
			}
			if(PlayerPrefs.GetInt("rightmix") == 32){
				renderer.enabled = true;
				renderer.sprite = n32;
			}
			if(PlayerPrefs.GetInt("rightmix") == 33){
				renderer.enabled = true;
				renderer.sprite = n33;
			}
			if(PlayerPrefs.GetInt("rightmix") == 34){
				renderer.enabled = true;
				renderer.sprite = n34;
			}
			if(PlayerPrefs.GetInt("rightmix") == 35){
				renderer.enabled = true;
				renderer.sprite = n35;
			}
			if(PlayerPrefs.GetInt("rightmix") == 36){
				renderer.enabled = true;
				renderer.sprite = n36;
			}
			if(PlayerPrefs.GetInt("rightmix") == 37){
				renderer.enabled = true;
				renderer.sprite = n37;
			}
			if(PlayerPrefs.GetInt("rightmix") == 38){
				renderer.enabled = true;
				renderer.sprite = n38;
			}
			if(PlayerPrefs.GetInt("rightmix") == 39){
				renderer.enabled = true;
				renderer.sprite = n39;
			}
			if(PlayerPrefs.GetInt("rightmix") == 40){
				renderer.enabled = true;
				renderer.sprite = n40;
			}
			if(PlayerPrefs.GetInt("rightmix") == 41){
				renderer.enabled = true;
				renderer.sprite = n41;
			}
			if(PlayerPrefs.GetInt("rightmix") == 42){
				renderer.enabled = true;
				renderer.sprite = n42;
			}
			if(PlayerPrefs.GetInt("rightmix") == 43){
				renderer.enabled = true;
				renderer.sprite = n43;
			}
			if(PlayerPrefs.GetInt("rightmix") == 44){
				renderer.enabled = true;
				renderer.sprite = n44;
			}
			if(PlayerPrefs.GetInt("rightmix") == 45){
				renderer.enabled = true;
				renderer.sprite = n45;
			}
			if(PlayerPrefs.GetInt("rightmix") == 46){
				renderer.enabled = true;
				renderer.sprite = n46;
			}
			if(PlayerPrefs.GetInt("rightmix") == 47){
				renderer.enabled = true;
				renderer.sprite = n47;
			}
			if(PlayerPrefs.GetInt("rightmix") == 48){
				renderer.enabled = true;
				renderer.sprite = n48;
			}
			if(PlayerPrefs.GetInt("rightmix") == 49){
				renderer.enabled = true;
				renderer.sprite = n49;
			}
			if(PlayerPrefs.GetInt("rightmix") == 50){
				renderer.enabled = true;
				renderer.sprite = n50;
			}
			if(PlayerPrefs.GetInt("rightmix") == 51){
				renderer.enabled = true;
				renderer.sprite = n51;
			}
			if(PlayerPrefs.GetInt("rightmix") == 52){
				renderer.enabled = true;
				renderer.sprite = n52;
			}
			if(PlayerPrefs.GetInt("rightmix") == 53){
				renderer.enabled = true;
				renderer.sprite = n53;
			}
			if(PlayerPrefs.GetInt("rightmix") == 54){
				renderer.enabled = true;
				renderer.sprite = n54;
			}
			if(PlayerPrefs.GetInt("rightmix") == 55){
				renderer.enabled = true;
				renderer.sprite = n55;
			}
			if(PlayerPrefs.GetInt("rightmix") == 56){
				renderer.enabled = true;
				renderer.sprite = n56;
			}
			if(PlayerPrefs.GetInt("rightmix") == 57){
				renderer.enabled = true;
				renderer.sprite = n57;
			}
			if(PlayerPrefs.GetInt("rightmix") == 58){
				renderer.enabled = true;
				renderer.sprite = n58;
			}
			if(PlayerPrefs.GetInt("rightmix") == 59){
				renderer.enabled = true;
				renderer.sprite = n59;
			}
			if(PlayerPrefs.GetInt("rightmix") == 60){
				renderer.enabled = true;
				renderer.sprite = n60;
			}
			if(PlayerPrefs.GetInt("rightmix") == 61){
				renderer.enabled = true;
				renderer.sprite = n61;
			}
			if(PlayerPrefs.GetInt("rightmix") == 62){
				renderer.enabled = true;
				renderer.sprite = n62;
			}
			if(PlayerPrefs.GetInt("rightmix") == 63){
				renderer.enabled = true;
				renderer.sprite = n63;
			}
			if(PlayerPrefs.GetInt("rightmix") == 64){
				renderer.enabled = true;
				renderer.sprite = n64;
			}
		}
		else{
			if(PlayerPrefs.GetInt("selectedname") == 0){
				renderer.enabled = false;
			}
			if(PlayerPrefs.GetInt("selectedname") == 1){
				renderer.enabled = true;
				renderer.sprite = n01;
			}
			if(PlayerPrefs.GetInt("selectedname") == 2){
				renderer.enabled = true;
				renderer.sprite = n02;
			}
			if(PlayerPrefs.GetInt("selectedname") == 3){
				renderer.enabled = true;
				renderer.sprite = n03;
			}
			if(PlayerPrefs.GetInt("selectedname") == 4){
				renderer.enabled = true;
				renderer.sprite = n04;
			}
			if(PlayerPrefs.GetInt("selectedname") == 5){
				renderer.enabled = true;
				renderer.sprite = n05;
			}
			if(PlayerPrefs.GetInt("selectedname") == 6){
				renderer.enabled = true;
				renderer.sprite = n06;
			}
			if(PlayerPrefs.GetInt("selectedname") == 7){
				renderer.enabled = true;
				renderer.sprite = n07;
			}
			if(PlayerPrefs.GetInt("selectedname") == 8){
				renderer.enabled = true;
				renderer.sprite = n08;
			}
			if(PlayerPrefs.GetInt("selectedname") == 9){
				renderer.enabled = true;
				renderer.sprite = n09;
			}
			if(PlayerPrefs.GetInt("selectedname") == 10){
				renderer.enabled = true;
				renderer.sprite = n10;
			}
			if(PlayerPrefs.GetInt("selectedname") == 11){
				renderer.enabled = true;
				renderer.sprite = n11;
			}
			if(PlayerPrefs.GetInt("selectedname") == 12){
				renderer.enabled = true;
				renderer.sprite = n12;
			}
			if(PlayerPrefs.GetInt("selectedname") == 13){
				renderer.enabled = true;
				renderer.sprite = n13;
			}
			if(PlayerPrefs.GetInt("selectedname") == 14){
				renderer.enabled = true;
				renderer.sprite = n14;
			}
			if(PlayerPrefs.GetInt("selectedname") == 15){
				renderer.enabled = true;
				renderer.sprite = n15;
			}
			if(PlayerPrefs.GetInt("selectedname") == 16){
				renderer.enabled = true;
				renderer.sprite = n16;
			}
			if(PlayerPrefs.GetInt("selectedname") == 17){
				renderer.enabled = true;
				renderer.sprite = n17;
			}
			if(PlayerPrefs.GetInt("selectedname") == 18){
				renderer.enabled = true;
				renderer.sprite = n18;
			}
			if(PlayerPrefs.GetInt("selectedname") == 19){
				renderer.enabled = true;
				renderer.sprite = n19;
			}
			if(PlayerPrefs.GetInt("selectedname") == 20){
				renderer.enabled = true;
				renderer.sprite = n20;
			}
			if(PlayerPrefs.GetInt("selectedname") == 21){
				renderer.enabled = true;
				renderer.sprite = n21;
			}
			if(PlayerPrefs.GetInt("selectedname") == 22){
				renderer.enabled = true;
				renderer.sprite = n22;
			}
			if(PlayerPrefs.GetInt("selectedname") == 23){
				renderer.enabled = true;
				renderer.sprite = n23;
			}
			if(PlayerPrefs.GetInt("selectedname") == 24){
				renderer.enabled = true;
				renderer.sprite = n24;
			}
			if(PlayerPrefs.GetInt("selectedname") == 25){
				renderer.enabled = true;
				renderer.sprite = n25;
			}
			if(PlayerPrefs.GetInt("selectedname") == 26){
				renderer.enabled = true;
				renderer.sprite = n26;
			}
			if(PlayerPrefs.GetInt("selectedname") == 27){
				renderer.enabled = true;
				renderer.sprite = n27;
			}
			if(PlayerPrefs.GetInt("selectedname") == 28){
				renderer.enabled = true;
				renderer.sprite = n28;
			}
			if(PlayerPrefs.GetInt("selectedname") == 29){
				renderer.enabled = true;
				renderer.sprite = n29;
			}
			if(PlayerPrefs.GetInt("selectedname") == 30){
				renderer.enabled = true;
				renderer.sprite = n30;
			}
			if(PlayerPrefs.GetInt("selectedname") == 31){
				renderer.enabled = true;
				renderer.sprite = n31;
			}
			if(PlayerPrefs.GetInt("selectedname") == 32){
				renderer.enabled = true;
				renderer.sprite = n32;
			}
			if(PlayerPrefs.GetInt("selectedname") == 33){
				renderer.enabled = true;
				renderer.sprite = n33;
			}
			if(PlayerPrefs.GetInt("selectedname") == 34){
				renderer.enabled = true;
				renderer.sprite = n34;
			}
			if(PlayerPrefs.GetInt("selectedname") == 35){
				renderer.enabled = true;
				renderer.sprite = n35;
			}
			if(PlayerPrefs.GetInt("selectedname") == 36){
				renderer.enabled = true;
				renderer.sprite = n36;
			}
			if(PlayerPrefs.GetInt("selectedname") == 37){
				renderer.enabled = true;
				renderer.sprite = n37;
			}
			if(PlayerPrefs.GetInt("selectedname") == 38){
				renderer.enabled = true;
				renderer.sprite = n38;
			}
			if(PlayerPrefs.GetInt("selectedname") == 39){
				renderer.enabled = true;
				renderer.sprite = n39;
			}
			if(PlayerPrefs.GetInt("selectedname") == 40){
				renderer.enabled = true;
				renderer.sprite = n40;
			}
			if(PlayerPrefs.GetInt("selectedname") == 41){
				renderer.enabled = true;
				renderer.sprite = n41;
			}
			if(PlayerPrefs.GetInt("selectedname") == 42){
				renderer.enabled = true;
				renderer.sprite = n42;
			}
			if(PlayerPrefs.GetInt("selectedname") == 43){
				renderer.enabled = true;
				renderer.sprite = n43;
			}
			if(PlayerPrefs.GetInt("selectedname") == 44){
				renderer.enabled = true;
				renderer.sprite = n44;
			}
			if(PlayerPrefs.GetInt("selectedname") == 45){
				renderer.enabled = true;
				renderer.sprite = n45;
			}
			if(PlayerPrefs.GetInt("selectedname") == 46){
				renderer.enabled = true;
				renderer.sprite = n46;
			}
			if(PlayerPrefs.GetInt("selectedname") == 47){
				renderer.enabled = true;
				renderer.sprite = n47;
			}
			if(PlayerPrefs.GetInt("selectedname") == 48){
				renderer.enabled = true;
				renderer.sprite = n48;
			}
			if(PlayerPrefs.GetInt("selectedname") == 49){
				renderer.enabled = true;
				renderer.sprite = n49;
			}
			if(PlayerPrefs.GetInt("selectedname") == 50){
				renderer.enabled = true;
				renderer.sprite = n50;
			}
			if(PlayerPrefs.GetInt("selectedname") == 51){
				renderer.enabled = true;
				renderer.sprite = n51;
			}
			if(PlayerPrefs.GetInt("selectedname") == 52){
				renderer.enabled = true;
				renderer.sprite = n52;
			}
			if(PlayerPrefs.GetInt("selectedname") == 53){
				renderer.enabled = true;
				renderer.sprite = n53;
			}
			if(PlayerPrefs.GetInt("selectedname") == 54){
				renderer.enabled = true;
				renderer.sprite = n54;
			}
			if(PlayerPrefs.GetInt("selectedname") == 55){
				renderer.enabled = true;
				renderer.sprite = n55;
			}
			if(PlayerPrefs.GetInt("selectedname") == 56){
				renderer.enabled = true;
				renderer.sprite = n56;
			}
			if(PlayerPrefs.GetInt("selectedname") == 57){
				renderer.enabled = true;
				renderer.sprite = n57;
			}
			if(PlayerPrefs.GetInt("selectedname") == 58){
				renderer.enabled = true;
				renderer.sprite = n58;
			}
			if(PlayerPrefs.GetInt("selectedname") == 59){
				renderer.enabled = true;
				renderer.sprite = n59;
			}
			if(PlayerPrefs.GetInt("selectedname") == 60){
				renderer.enabled = true;
				renderer.sprite = n60;
			}
			if(PlayerPrefs.GetInt("selectedname") == 61){
				renderer.enabled = true;
				renderer.sprite = n61;
			}
			if(PlayerPrefs.GetInt("selectedname") == 62){
				renderer.enabled = true;
				renderer.sprite = n62;
			}
			if(PlayerPrefs.GetInt("selectedname") == 63){
				renderer.enabled = true;
				renderer.sprite = n63;
			}
			if(PlayerPrefs.GetInt("selectedname") == 64){
				renderer.enabled = true;
				renderer.sprite = n64;
			}
		}
	}
}
