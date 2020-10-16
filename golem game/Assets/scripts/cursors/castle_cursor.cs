using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class castle_cursor : MonoBehaviour {

	//CURSED SCRIPT: PROCEED WITH CAUTION

	//navigates cursor between points on castle overmap
	//sets "room" playerpref based on selected location
	//loads respective room on pressing space

	//this script gave me the worst bug i have yet encountered in my short and shallow
	//tenure as someone who codes; it did not appear in the editor and only showed up
	//in builds like ~1/3 of the times the file would be opened and would cause this
	//cursor on those instances to move 2-3 spaces per getkeydown instead of the one
	//its suppsed to (rendering effective exploration occasionally impossible)
	//then i would close the file and reopen it and it would work fine or vice versa
	//i still dont know exactly why this was happening and cant be positive i have solved it
	//(my only 'evidence' for the latter being my having opened the latest build up
	//six times in a row without the bug being activated—conceivably just a lucky fluke)
	//i spent many many hours smashing my head into the wall over this
	//the thing that finally solved it was making the current room number pass back
	//and forth between its playerpref and the newly added int "currentroom"
	//instead of just operating in the former. again, im not sure why this worked
	//but i hope it did and will not test my luck further
	//deepest apologies for how DEEPLY MESSY this code is, i think certain components
	//could be removed now that it works but i will superstitiously keep them in,
	//the massively excessive sequence of knots holding closed the gates to hell
	//(this comment is my memorial to the afternoon i spent chasing a ghost, 8 - 17 - 2020)

	Rigidbody2D rb2d;
	SpriteRenderer Render;
	public GameObject r01, r02, r03, r04, r05, r06, r07, r08, r09, r10, r11, r12, r13,
	movesfx, cursorfade;
	public float p1x, p1y, p2x, p2y, p3x, p3y, p4x, p4y, p5x, p5y, p6x, p6y, p7x, p7y,
	p8x, p8y, p9x, p9y, p10x, p10y, p11x, p11y, p12x, p12y, p13x, p13y, roomspawnx,
	roomspawny, delaytime, totalfilled = 1;
	float offsetx = 1.5f, offsety = -1f, m_lastPressed;
	int currentroom = 11;
	bool notavail = false, firsttime = true, rauldy = true, itsdown = false;
	Vector3 whereami;

	void Update () {


		if(firsttime){
			Render = GetComponent<SpriteRenderer>();
			rb2d = GetComponent<Rigidbody2D> ();
			rb2d.MovePosition(new Vector2(p11x + offsetx, p11y + offsety));
			firsttime = false;
			whereami = transform.position;
		}

		if(whereami != transform.position){
			Cursorfade();
			whereami = transform.position;
		}


		if(PlayerPrefs.GetInt("inroom") == 0 && m_lastPressed != Time.time){

			m_lastPressed = Time.time;

			if(Input.GetKeyDown("space")){
				if(PlayerPrefs.GetInt("room") == 1){
					Instantiate(r01, new Vector2(roomspawnx, roomspawny), Quaternion.identity);
				}
				else if(PlayerPrefs.GetInt("room") == 2){
					Instantiate(r02, new Vector2(roomspawnx, roomspawny), Quaternion.identity);
				}
				else if(PlayerPrefs.GetInt("room") == 3){
					Instantiate(r03, new Vector2(roomspawnx, roomspawny), Quaternion.identity);
				}
				else if(PlayerPrefs.GetInt("room") == 4){
					Instantiate(r04, new Vector2(roomspawnx, roomspawny), Quaternion.identity);
				}
				else if(PlayerPrefs.GetInt("room") == 5){
					Instantiate(r05, new Vector2(roomspawnx, roomspawny), Quaternion.identity);
				}
				else if(PlayerPrefs.GetInt("room") == 6){
					Instantiate(r06, new Vector2(roomspawnx, roomspawny), Quaternion.identity);
				}
				else if(PlayerPrefs.GetInt("room") == 7){
					Instantiate(r07, new Vector2(roomspawnx, roomspawny), Quaternion.identity);
				}
				else if(PlayerPrefs.GetInt("room") == 8){
					Instantiate(r08, new Vector2(roomspawnx, roomspawny), Quaternion.identity);
				}
				else if(PlayerPrefs.GetInt("room") == 9){
					Instantiate(r09, new Vector2(roomspawnx + .5f, roomspawny - .04f), Quaternion.identity);
				}
				else if(PlayerPrefs.GetInt("room") == 10){
					Instantiate(r10, new Vector2(roomspawnx, roomspawny), Quaternion.identity);
				}
				else if(PlayerPrefs.GetInt("room") == 11){
					Instantiate(r11, new Vector2(roomspawnx, roomspawny), Quaternion.identity);
				}
				else if(PlayerPrefs.GetInt("room") == 12){
					Instantiate(r12, new Vector2(roomspawnx, roomspawny), Quaternion.identity);
				}
				else if(PlayerPrefs.GetInt("room") == 13){
					Instantiate(r13, new Vector2(roomspawnx, roomspawny), Quaternion.identity);
				}
				else{
					notavail = true;
				}
				if(!notavail){
					PlayerPrefs.SetInt("inroom", 1);
				}
				notavail = false;
			}


			if(PlayerPrefs.GetInt("room") != currentroom){
				if(PlayerPrefs.GetInt("room") == 1 && currentroom != 1){
					rb2d.MovePosition(new Vector2(p1x + offsetx, p1y + offsety));
					currentroom = 1;
				}
				else if(PlayerPrefs.GetInt("room") == 2 && currentroom != 2){
					rb2d.MovePosition(new Vector2(p2x + offsetx, p2y + offsety));
					currentroom = 2;
				}
				else if(PlayerPrefs.GetInt("room") == 3 && currentroom != 3){
					rb2d.MovePosition(new Vector2(p3x + offsetx, p3y + offsety));
					currentroom = 3;
				}
				else if(PlayerPrefs.GetInt("room") == 4 && currentroom != 4){
					rb2d.MovePosition(new Vector2(p4x + offsetx, p4y + offsety));
					currentroom = 4;
				}
				else if(PlayerPrefs.GetInt("room") == 5 && currentroom != 5){
					rb2d.MovePosition(new Vector2(p5x + offsetx, p5y + offsety));
					currentroom = 5;
				}
				else if(PlayerPrefs.GetInt("room") == 6 && currentroom != 6){
					rb2d.MovePosition(new Vector2(p6x + offsetx, p6y + offsety));
					currentroom = 6;
				}
				else if(PlayerPrefs.GetInt("room") == 7 && currentroom != 7){
					rb2d.MovePosition(new Vector2(p7x + offsetx, p7y + offsety));
					currentroom = 7;
				}
				else if(PlayerPrefs.GetInt("room") == 8 && currentroom != 8){
					rb2d.MovePosition(new Vector2(p8x + offsetx, p8y + offsety));
					currentroom = 8;
				}
				else if(PlayerPrefs.GetInt("room") == 9 && currentroom != 9){
					rb2d.MovePosition(new Vector2(p9x + offsetx, p9y + offsety));
					currentroom = 9;
				}
				else if(PlayerPrefs.GetInt("room") == 10 && currentroom != 10){
					rb2d.MovePosition(new Vector2(p10x + offsetx, p10y + offsety));
					currentroom = 10;
				}
				else if(PlayerPrefs.GetInt("room") == 11 && currentroom != 11){
					rb2d.MovePosition(new Vector2(p11x + offsetx, p11y + offsety));
					currentroom = 11;
				}
				else if(PlayerPrefs.GetInt("room") == 12 && currentroom != 12){
					rb2d.MovePosition(new Vector2(p12x + offsetx, p12y + offsety));
					currentroom = 12;
				}
				else if(PlayerPrefs.GetInt("room") == 13 && currentroom != 13){
					rb2d.MovePosition(new Vector2(p13x + offsetx, p13y + offsety));
					currentroom = 13;
				}
			}





		}
	}

	void LateUpdate(){
		if(PlayerPrefs.GetInt("inroom") == 0){
			if(Input.GetKeyDown("up") && currentroom == 11 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 13);
			}
			else if(Input.GetKeyDown("up") && currentroom == 10 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 12);
			}
			else if(Input.GetKeyDown("up") && currentroom == 7 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 11);
			}
			else if(Input.GetKeyDown("up") && currentroom == 6 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 10);
			}
			else if(Input.GetKeyDown("up") && currentroom == 4 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 8);
			}
			else if(Input.GetKeyDown("up") && currentroom == 3 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 7);
			}
			else if(Input.GetKeyDown("up") && currentroom == 2 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 6);
			}
			else if(Input.GetKeyDown("up") && currentroom == 1 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 3);
			}
			else if(Input.GetKeyDown("down") && currentroom == 13 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 11);
			}
			else if(Input.GetKeyDown("down") && currentroom == 12 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 10);
			}
			else if(Input.GetKeyDown("down") && currentroom == 11 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 7);
			}
			else if(Input.GetKeyDown("down") && currentroom == 10 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 6);
			}
			else if(Input.GetKeyDown("down") && currentroom == 8 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 4);
			}
			else if(Input.GetKeyDown("down") && currentroom == 7 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 3);
			}
			else if(Input.GetKeyDown("down") && currentroom == 6 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 2);
			}
			else if(Input.GetKeyDown("down") && currentroom == 4 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 3);
			}
			else if(Input.GetKeyDown("down") && currentroom == 3 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 1);
			}
			else if(Input.GetKeyDown("down") && currentroom == 2 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 3);
			}
			else if(Input.GetKeyDown("left") && currentroom == 9 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 8);
			}
			else if(Input.GetKeyDown("left") && currentroom == 8 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 7);
			}
			else if(Input.GetKeyDown("left") && currentroom == 7 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 6);
			}
			else if(Input.GetKeyDown("left") && currentroom == 5 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 4);
			}
			else if(Input.GetKeyDown("left") && currentroom == 3 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 2);
			}
			else if(Input.GetKeyDown("right") && currentroom == 8 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 9);
			}
			else if(Input.GetKeyDown("right") && currentroom == 7 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 8);
			}
			else if(Input.GetKeyDown("right") && currentroom == 6 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 7);
			}
			else if(Input.GetKeyDown("right") && currentroom == 4 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 5);
			}
			else if(Input.GetKeyDown("right") && currentroom == 3 && !itsdown){
				itsdown = true;
				PlayerPrefs.SetInt("room", 4);
			}
			else{
				notavail = true;
				if(Input.GetKeyUp("up") || Input.GetKeyUp("down") || Input.GetKeyUp("left")
				|| Input.GetKeyUp("right")){
					itsdown = false;
				}
			}
			if(!notavail){
				MovingStuff();
			}
			notavail = false;
		}



	}




	void MovingStuff(){
		Instantiate(movesfx, transform.position, Quaternion.identity);
//		StartCoroutine(FadeIn());
	}

	void Cursorfade(){
		Instantiate(cursorfade, whereami, Quaternion.identity);
//		StartCoroutine(FadeIn());
	}

	IEnumerator FadeIn(){
		Render.color = new Color(0,0,0,0);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(.15f * totalfilled,.15f * totalfilled,.15f * totalfilled,.15f * totalfilled);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(.3f * totalfilled,.3f * totalfilled,.3f * totalfilled,.3f * totalfilled);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(.45f * totalfilled,.45f * totalfilled,.45f * totalfilled,.45f * totalfilled);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(.6f * totalfilled,.6f * totalfilled,.6f * totalfilled,.6f * totalfilled);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(.75f * totalfilled,.75f * totalfilled,.75f * totalfilled,.75f * totalfilled);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(.9f * totalfilled,.9f * totalfilled,.9f * totalfilled,.9f * totalfilled);
		yield return new WaitForSeconds(delaytime);
		Render.color = new Color(totalfilled,totalfilled,totalfilled,totalfilled);
	}
	//WHY DOESNT THIS FADE WORK??? EVERYTHING GETS CALLED PROPERLY AND ONLY ONCE
	//AND ITS THE SAME EXACT SEQUENCE I USE WITH NO ISSUES IN THE FADING SCRIPTS
	//BUT FOR SOME REASON WHENEVER THIS GETS CALLED IT DOES THIS WEIRD FLICKERING
	//THING AS ITS FADING IN!?!? UGH CURSED SCRIPT!!!!!
}
