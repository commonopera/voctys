using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue_proto : MonoBehaviour {

	//freezes player (in room) and writes out inputted string one letter at a time
	//dialogue mostly centers around midpoint of object this script is on
	//(if there is an imbalance of m's and w's vs i's and l's the center may be off)
	//rate of letter display set by 'waittime', letter spacing set by 'pixelsize'
	//(individual letter sizes coordinated to "golemscript" font; if reusing, recalculate)
	//when message has fully appeared, spacebar kills
	//if 'subsequent' is checked, killing message spawns 'nextline'
	//PLAYERNAME gets substituted for player's inputted name
	//CHOSENNAME gets substituted for name inserted into golem
	//MIXNAME gets substituted for resulting name from synthesis
	//"justtext" displays text without freezing screen or destroying on space

	//this probably wastes a ton of memory?
	//but feels better than the other dialogue options ive tried
	//so i'll use it for now
	//hehe >_____>

	//(by this point ive got a much more comprehensive and flexible version of this
	//script made and in use in another in-development project but this one serves
	//its purpose within the context of this game so i am leaving it as this proto version!)

	bool begin = true, repeat = false, fin = false;
	public bool subsequent, justtext;
	public string text;
	string[] characters;
	int i;
	float ourx, ournewx;
	public float pixelsize, waittime;
	public GameObject nextline, la, lb, lc, ld, le, lf, lg, lh, li, lj, lk, ll, lm, ln,
	lo, lp, lq, lr, ls, lt, lu, lv, lw, lx, ly, lz, lcomma, lperiod, lexclaim, lquestion,
	lampersand, lasterisk, lcolon, ldoublequote, lsinglequote, lequals, lleftparenth, lrightparenth, lminus,
	lplus, lsemicolon, l0, l1, l2, l3, l4, l5, l6, l7, l8, l9;

	void Update () {
		if(fin && !justtext){
			if(Input.GetKeyDown("space")){
				if(subsequent){
					Instantiate(nextline, transform.position, Quaternion.identity);
				}
				Destroy(gameObject);
			}
		}
		if(begin){
			begin = false;
			SetUps();
		}
		if(repeat){
			repeat = false;
			if(i < text.Length){
				characters[i] = System.Convert.ToString(text[i]);
				if(characters[i] == "a"){
					Instantiate(la, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "b"){
					Instantiate(lb, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "c"){
					Instantiate(lc, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "d"){
					Instantiate(ld, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "e"){
					Instantiate(le, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "f"){
					Instantiate(lf, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 4);
					LetterIsSet();
				}
				else if(characters[i] == "g"){
					Instantiate(lg, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "h"){
					Instantiate(lh, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "i" || characters[i] == "I"){
					Instantiate(li, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 2);
					LetterIsSet();
				}
				else if(characters[i] == "j"){
					Instantiate(lj, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 3);
					LetterIsSet();
				}
				else if(characters[i] == "k"){
					Instantiate(lk, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "l"){
					Instantiate(ll, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 2);
					LetterIsSet();
				}
				else if(characters[i] == "m"){
					Instantiate(lm, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 6);
					LetterIsSet();
				}
				else if(characters[i] == "n"){
					Instantiate(ln, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "o"){
					Instantiate(lo, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "p"){
					Instantiate(lp, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "q"){
					Instantiate(lq, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "r"){
					Instantiate(lr, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "s"){
					Instantiate(ls, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "t"){
					Instantiate(lt, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 4);
					LetterIsSet();
				}
				else if(characters[i] == "u"){
					Instantiate(lu, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "v"){
					Instantiate(lv, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "w"){
					Instantiate(lw, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 6);
					LetterIsSet();
				}
				else if(characters[i] == "x"){
					Instantiate(lx, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "y"){
					Instantiate(ly, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "z"){
					Instantiate(lz, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == ","){
					Instantiate(lcomma, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 3);
					LetterIsSet();
				}
				else if(characters[i] == "."){
					Instantiate(lperiod, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 2);
					LetterIsSet();
				}
				else if(characters[i] == "?"){
					Instantiate(lquestion, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "!"){
					Instantiate(lexclaim, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 2);
					LetterIsSet();
				}
				else if(characters[i] == "&"){
					Instantiate(lampersand, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 6);
					LetterIsSet();
				}
				else if(characters[i] == "*"){
					Instantiate(lasterisk, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 4);
					LetterIsSet();
				}
				else if(characters[i] == ":"){
					Instantiate(lcolon, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 2);
					LetterIsSet();
				}
				else if(characters[i] == "\""){
					Instantiate(ldoublequote, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 4);
					LetterIsSet();
				}
				else if(characters[i] == "\'" || characters[i] == "’" || characters[i] == "‘"){
					Instantiate(lsinglequote, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 2);
					LetterIsSet();
				}
				else if(characters[i] == "="){
					Instantiate(lequals, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 4);
					LetterIsSet();
				}
				else if(characters[i] == "("){
					Instantiate(lleftparenth, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 4);
					LetterIsSet();
				}
				else if(characters[i] == "-"){
					Instantiate(lminus, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 4);
					LetterIsSet();
				}
				else if(characters[i] == "+"){
					Instantiate(lplus, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 4);
					LetterIsSet();
				}
				else if(characters[i] == ")"){
					Instantiate(lrightparenth, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 4);
					LetterIsSet();
				}
				else if(characters[i] == ";"){
					Instantiate(lsemicolon, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 3);
					LetterIsSet();
				}
				else if(characters[i] == "0"){
					Instantiate(l0, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "1"){
					Instantiate(l1, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 4);
					LetterIsSet();
				}
				else if(characters[i] == "2"){
					Instantiate(l2, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "3"){
					Instantiate(l3, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "4"){
					Instantiate(l4, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "5"){
					Instantiate(l5, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "6"){
					Instantiate(l6, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "7"){
					Instantiate(l7, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "8"){
					Instantiate(l8, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == "9"){
					Instantiate(l9, new Vector3(ourx, transform.position.y,
					(transform.position.z + (.001f * i))), Quaternion.identity, transform);
					ournewx = ourx + (pixelsize * 5);
					LetterIsSet();
				}
				else if(characters[i] == " "){
					ournewx = ourx + (pixelsize * 4);
					LetterIsSet();
				}
				else{
					ournewx = ourx + (pixelsize * 4);
					LetterIsSet();
				}
			}
			else{
				fin = true;
			}
		}
	}

	IEnumerator Repeater(){
		if(waittime >= (2 * Time.deltaTime)){
			yield return new WaitForSeconds(waittime - (2 * Time.deltaTime));
		}	
		repeat = true;
	}

	void OnDestroy(){
		if(!subsequent && !justtext){
			PlayerPrefs.SetInt("frozen", 0);
		}
	}

	void SetUps(){
		if(!justtext){
			PlayerPrefs.SetInt("frozen", 1);
		}
		text = text.Replace("PLAYERNAME", PlayerPrefs.GetString("playername"));
		i = 0;
		ourx = transform.position.x - (4 * pixelsize * (text.Length/2));
		if(PlayerPrefs.GetInt("chosenname") > 0){
			if(PlayerPrefs.GetInt("chosenname") == 1){
				text = text.Replace("CHOSENNAME", "'ezevb");
			}
			if(PlayerPrefs.GetInt("chosenname") == 2){
				text = text.Replace("CHOSENNAME", "qebv'e");
			}
			if(PlayerPrefs.GetInt("chosenname") == 3){
				text = text.Replace("CHOSENNAME", "tesnev'e");
			}
			if(PlayerPrefs.GetInt("chosenname") == 4){
				text = text.Replace("CHOSENNAME", "qan");
			}
			if(PlayerPrefs.GetInt("chosenname") == 5){
				text = text.Replace("CHOSENNAME", "metamenyem");
			}
			if(PlayerPrefs.GetInt("chosenname") == 6){
				text = text.Replace("CHOSENNAME", "meshephh");
			}
			if(PlayerPrefs.GetInt("chosenname") == 7){
				text = text.Replace("CHOSENNAME", "qetn");
			}
			if(PlayerPrefs.GetInt("chosenname") == 8){
				text = text.Replace("CHOSENNAME", "g'yen");
			}
			if(PlayerPrefs.GetInt("chosenname") == 9){
				text = text.Replace("CHOSENNAME", "tesreyk");
			}
			if(PlayerPrefs.GetInt("chosenname") == 10){
				text = text.Replace("CHOSENNAME", "tetsevgh");
			}
			if(PlayerPrefs.GetInt("chosenname") == 11){
				text = text.Replace("CHOSENNAME", "mevnegvelyh");
			}
			if(PlayerPrefs.GetInt("chosenname") == 12){
				text = text.Replace("CHOSENNAME", "bhedregh");
			}
			if(PlayerPrefs.GetInt("chosenname") == 13){
				text = text.Replace("CHOSENNAME", "leyhh");
			}
			if(PlayerPrefs.GetInt("chosenname") == 14){
				text = text.Replace("CHOSENNAME", "masher");
			}
			if(PlayerPrefs.GetInt("chosenname") == 15){
				text = text.Replace("CHOSENNAME", "yev");
			}
			if(PlayerPrefs.GetInt("chosenname") == 16){
				text = text.Replace("CHOSENNAME", "'ever");
			}
			if(PlayerPrefs.GetInt("chosenname") == 17){
				text = text.Replace("CHOSENNAME", "gedvel vhezq");
			}
			if(PlayerPrefs.GetInt("chosenname") == 18){
				text = text.Replace("CHOSENNAME", "deyneg");
			}
			if(PlayerPrefs.GetInt("chosenname") == 19){
				text = text.Replace("CHOSENNAME", "tev'elet");
			}
			if(PlayerPrefs.GetInt("chosenname") == 20){
				text = text.Replace("CHOSENNAME", "metqelp");
			}
			if(PlayerPrefs.GetInt("chosenname") == 21){
				text = text.Replace("CHOSENNAME", "mevrekb");
			}
			if(PlayerPrefs.GetInt("chosenname") == 22){
				text = text.Replace("CHOSENNAME", "vebken");
			}
			if(PlayerPrefs.GetInt("chosenname") == 23){
				text = text.Replace("CHOSENNAME", "her");
			}
			if(PlayerPrefs.GetInt("chosenname") == 24){
				text = text.Replace("CHOSENNAME", "la tevb");
			}
			if(PlayerPrefs.GetInt("chosenname") == 25){
				text = text.Replace("CHOSENNAME", "mevrh");
			}
			if(PlayerPrefs.GetInt("chosenname") == 26){
				text = text.Replace("CHOSENNAME", "l'elevt");
			}
			if(PlayerPrefs.GetInt("chosenname") == 27){
				text = text.Replace("CHOSENNAME", "kegven");
			}
			if(PlayerPrefs.GetInt("chosenname") == 28){
				text = text.Replace("CHOSENNAME", "helm");
			}
			if(PlayerPrefs.GetInt("chosenname") == 29){
				text = text.Replace("CHOSENNAME", "qevn");
			}
			if(PlayerPrefs.GetInt("chosenname") == 30){
				text = text.Replace("CHOSENNAME", "hevshelmh kebr");
			}
			if(PlayerPrefs.GetInt("chosenname") == 31){
				text = text.Replace("CHOSENNAME", "nepredyem");
			}
			if(PlayerPrefs.GetInt("chosenname") == 32){
				text = text.Replace("CHOSENNAME", "helyepyen");
			}
			if(PlayerPrefs.GetInt("chosenname") == 33){
				text = text.Replace("CHOSENNAME", "meynegyey");
			}
			if(PlayerPrefs.GetInt("chosenname") == 34){
				text = text.Replace("CHOSENNAME", "meqtesv'en");
			}
			if(PlayerPrefs.GetInt("chosenname") == 35){
				text = text.Replace("CHOSENNAME", "hetsetbervet");
			}
			if(PlayerPrefs.GetInt("chosenname") == 36){
				text = text.Replace("CHOSENNAME", "heyh gedvelh");
			}
			if(PlayerPrefs.GetInt("chosenname") == 37){
				text = text.Replace("CHOSENNAME", "la");
			}
			if(PlayerPrefs.GetInt("chosenname") == 38){
				text = text.Replace("CHOSENNAME", "em");
			}
			if(PlayerPrefs.GetInt("chosenname") == 39){
				text = text.Replace("CHOSENNAME", "melvheym");
			}
			if(PlayerPrefs.GetInt("chosenname") == 40){
				text = text.Replace("CHOSENNAME", "r'el");
			}
			if(PlayerPrefs.GetInt("chosenname") == 41){
				text = text.Replace("CHOSENNAME", "tayelnedy");
			}
			if(PlayerPrefs.GetInt("chosenname") == 42){
				text = text.Replace("CHOSENNAME", "nhedr");
			}
			if(PlayerPrefs.GetInt("chosenname") == 43){
				text = text.Replace("CHOSENNAME", "avetv adem");
			}
			if(PlayerPrefs.GetInt("chosenname") == 44){
				text = text.Replace("CHOSENNAME", "lest");
			}
			if(PlayerPrefs.GetInt("chosenname") == 45){
				text = text.Replace("CHOSENNAME", "hep mepsh'");
			}
			if(PlayerPrefs.GetInt("chosenname") == 46){
				text = text.Replace("CHOSENNAME", "peyterven");
			}
			if(PlayerPrefs.GetInt("chosenname") == 47){
				text = text.Replace("CHOSENNAME", "peng");
			}
			if(PlayerPrefs.GetInt("chosenname") == 48){
				text = text.Replace("CHOSENNAME", "yebsh");
			}
			if(PlayerPrefs.GetInt("chosenname") == 49){
				text = text.Replace("CHOSENNAME", "heyh qetnh");
			}
			if(PlayerPrefs.GetInt("chosenname") == 50){
				text = text.Replace("CHOSENNAME", "beryhh");
			}
			if(PlayerPrefs.GetInt("chosenname") == 51){
				text = text.Replace("CHOSENNAME", "qev");
			}
			if(PlayerPrefs.GetInt("chosenname") == 52){
				text = text.Replace("CHOSENNAME", "leyteygetseyh");
			}
			if(PlayerPrefs.GetInt("chosenname") == 53){
				text = text.Replace("CHOSENNAME", "hetyebh");
			}
			if(PlayerPrefs.GetInt("chosenname") == 54){
				text = text.Replace("CHOSENNAME", "nezq");
			}
			if(PlayerPrefs.GetInt("chosenname") == 55){
				text = text.Replace("CHOSENNAME", "rezvelvetseyh");
			}
			if(PlayerPrefs.GetInt("chosenname") == 56){
				text = text.Replace("CHOSENNAME", "hevzer lahevt");
			}
			if(PlayerPrefs.GetInt("chosenname") == 57){
				text = text.Replace("CHOSENNAME", "menvemnem");
			}
			if(PlayerPrefs.GetInt("chosenname") == 58){
				text = text.Replace("CHOSENNAME", "gedvel m");
			}
			if(PlayerPrefs.GetInt("chosenname") == 59){
				text = text.Replace("CHOSENNAME", "lheltes");
			}
			if(PlayerPrefs.GetInt("chosenname") == 60){
				text = text.Replace("CHOSENNAME", "gavelh");
			}
			if(PlayerPrefs.GetInt("chosenname") == 61){
				text = text.Replace("CHOSENNAME", "revh");
			}
			if(PlayerPrefs.GetInt("chosenname") == 62){
				text = text.Replace("CHOSENNAME", "z'vengepv");
			}
			if(PlayerPrefs.GetInt("chosenname") == 63){
				text = text.Replace("CHOSENNAME", "lhetpezr");
			}
			if(PlayerPrefs.GetInt("chosenname") == 64){
				text = text.Replace("CHOSENNAME", "pesteybel");
			}
			if(PlayerPrefs.GetInt("chosenname") == 1 ||
			PlayerPrefs.GetInt("chosenname") == 13 ||
			PlayerPrefs.GetInt("chosenname") == 16 ||
			PlayerPrefs.GetInt("chosenname") == 27 ||
			PlayerPrefs.GetInt("chosenname") == 30 ||
			PlayerPrefs.GetInt("chosenname") == 42 ||
			PlayerPrefs.GetInt("chosenname") == 53){
				text = text.Replace("ACTION1", "mars -");
			}
			if(PlayerPrefs.GetInt("chosenname") == 2 ||
			PlayerPrefs.GetInt("chosenname") == 6 ||
			PlayerPrefs.GetInt("chosenname") == 7 ||
			PlayerPrefs.GetInt("chosenname") == 10 ||
			PlayerPrefs.GetInt("chosenname") == 12 ||
			PlayerPrefs.GetInt("chosenname") == 18 ||
			PlayerPrefs.GetInt("chosenname") == 19 ||
			PlayerPrefs.GetInt("chosenname") == 21 ||
			PlayerPrefs.GetInt("chosenname") == 22 ||
			PlayerPrefs.GetInt("chosenname") == 26 ||
			PlayerPrefs.GetInt("chosenname") == 28 ||
			PlayerPrefs.GetInt("chosenname") == 32 ||
			PlayerPrefs.GetInt("chosenname") == 35 ||
			PlayerPrefs.GetInt("chosenname") == 37 ||
			PlayerPrefs.GetInt("chosenname") == 38 ||
			PlayerPrefs.GetInt("chosenname") == 47 ||
			PlayerPrefs.GetInt("chosenname") == 52 ||
			PlayerPrefs.GetInt("chosenname") == 56 ||
			PlayerPrefs.GetInt("chosenname") == 58 ||
			PlayerPrefs.GetInt("chosenname") == 61 ||
			PlayerPrefs.GetInt("chosenname") == 62){
				text = text.Replace("ACTION1", "jupiter -");
			}
			if(PlayerPrefs.GetInt("chosenname") == 3 ||
			PlayerPrefs.GetInt("chosenname") == 8 ||
			PlayerPrefs.GetInt("chosenname") == 15 ||
			PlayerPrefs.GetInt("chosenname") == 20 ||
			PlayerPrefs.GetInt("chosenname") == 23 ||
			PlayerPrefs.GetInt("chosenname") == 25 ||
			PlayerPrefs.GetInt("chosenname") == 29 ||
			PlayerPrefs.GetInt("chosenname") == 33 ||
			PlayerPrefs.GetInt("chosenname") == 39 ||
			PlayerPrefs.GetInt("chosenname") == 40 ||
			PlayerPrefs.GetInt("chosenname") == 44 ||
			PlayerPrefs.GetInt("chosenname") == 50 ||
			PlayerPrefs.GetInt("chosenname") == 54 ||
			PlayerPrefs.GetInt("chosenname") == 59){
				text = text.Replace("ACTION1", "saturn -");
			}
			if(PlayerPrefs.GetInt("chosenname") == 4 ||
			PlayerPrefs.GetInt("chosenname") == 11 ||
			PlayerPrefs.GetInt("chosenname") == 14 ||
			PlayerPrefs.GetInt("chosenname") == 24 ||
			PlayerPrefs.GetInt("chosenname") == 46 ||
			PlayerPrefs.GetInt("chosenname") == 51 ||
			PlayerPrefs.GetInt("chosenname") == 63 ||
			PlayerPrefs.GetInt("chosenname") == 64){
				text = text.Replace("ACTION1", "mercury -");
			}
			if(PlayerPrefs.GetInt("chosenname") == 5 ||
			PlayerPrefs.GetInt("chosenname") == 9 ||
			PlayerPrefs.GetInt("chosenname") == 17 ||
			PlayerPrefs.GetInt("chosenname") == 31 ||
			PlayerPrefs.GetInt("chosenname") == 34 ||
			PlayerPrefs.GetInt("chosenname") == 36 ||
			PlayerPrefs.GetInt("chosenname") == 41 ||
			PlayerPrefs.GetInt("chosenname") == 43 ||
			PlayerPrefs.GetInt("chosenname") == 45 ||
			PlayerPrefs.GetInt("chosenname") == 48 ||
			PlayerPrefs.GetInt("chosenname") == 49 ||
			PlayerPrefs.GetInt("chosenname") == 55 ||
			PlayerPrefs.GetInt("chosenname") == 57 ||
			PlayerPrefs.GetInt("chosenname") == 60){
				text = text.Replace("ACTION1", "venus -");
			}
			if(PlayerPrefs.GetInt("chosenname") == 1 ||
			PlayerPrefs.GetInt("chosenname") == 6 ||
			PlayerPrefs.GetInt("chosenname") == 8 ||
			PlayerPrefs.GetInt("chosenname") == 18 ||
			PlayerPrefs.GetInt("chosenname") == 24 ||
			PlayerPrefs.GetInt("chosenname") == 31 ||
			PlayerPrefs.GetInt("chosenname") == 33 ||
			PlayerPrefs.GetInt("chosenname") == 43 ||
			PlayerPrefs.GetInt("chosenname") == 47){
				text = text.Replace("ACTION2", "mars +");
			}
			if(PlayerPrefs.GetInt("chosenname") == 2 ||
			PlayerPrefs.GetInt("chosenname") == 13 ||
			PlayerPrefs.GetInt("chosenname") == 15 ||
			PlayerPrefs.GetInt("chosenname") == 19 ||
			PlayerPrefs.GetInt("chosenname") == 28 ||
			PlayerPrefs.GetInt("chosenname") == 40 ||
			PlayerPrefs.GetInt("chosenname") == 44 ||
			PlayerPrefs.GetInt("chosenname") == 45 ||
			PlayerPrefs.GetInt("chosenname") == 46 ||
			PlayerPrefs.GetInt("chosenname") == 49 ||
			PlayerPrefs.GetInt("chosenname") == 61 ||
			PlayerPrefs.GetInt("chosenname") == 63){
				text = text.Replace("ACTION2", "jupiter +");
			}
			if(PlayerPrefs.GetInt("chosenname") == 3 ||
			PlayerPrefs.GetInt("chosenname") == 7 ||
			PlayerPrefs.GetInt("chosenname") == 10 ||
			PlayerPrefs.GetInt("chosenname") == 11 ||
			PlayerPrefs.GetInt("chosenname") == 12 ||
			PlayerPrefs.GetInt("chosenname") == 14 ||
			PlayerPrefs.GetInt("chosenname") == 20 ||
			PlayerPrefs.GetInt("chosenname") == 21 ||
			PlayerPrefs.GetInt("chosenname") == 23 ||
			PlayerPrefs.GetInt("chosenname") == 26 ||
			PlayerPrefs.GetInt("chosenname") == 27 ||
			PlayerPrefs.GetInt("chosenname") == 29 ||
			PlayerPrefs.GetInt("chosenname") == 34 ||
			PlayerPrefs.GetInt("chosenname") == 36 ||
			PlayerPrefs.GetInt("chosenname") == 37 ||
			PlayerPrefs.GetInt("chosenname") == 41 ||
			PlayerPrefs.GetInt("chosenname") == 51 ||
			PlayerPrefs.GetInt("chosenname") == 53){
				text = text.Replace("ACTION2", "saturn +");
			}
			if(PlayerPrefs.GetInt("chosenname") == 4 ||
			PlayerPrefs.GetInt("chosenname") == 9 ||
			PlayerPrefs.GetInt("chosenname") == 22 ||
			PlayerPrefs.GetInt("chosenname") == 25 ||
			PlayerPrefs.GetInt("chosenname") == 30 ||
			PlayerPrefs.GetInt("chosenname") == 35 ||
			PlayerPrefs.GetInt("chosenname") == 52 ||
			PlayerPrefs.GetInt("chosenname") == 57){
				text = text.Replace("ACTION2", "mercury +");
			}
			if(PlayerPrefs.GetInt("chosenname") == 5 ||
			PlayerPrefs.GetInt("chosenname") == 16 ||
			PlayerPrefs.GetInt("chosenname") == 17 ||
			PlayerPrefs.GetInt("chosenname") == 32 ||
			PlayerPrefs.GetInt("chosenname") == 38 ||
			PlayerPrefs.GetInt("chosenname") == 39 ||
			PlayerPrefs.GetInt("chosenname") == 42 ||
			PlayerPrefs.GetInt("chosenname") == 48 ||
			PlayerPrefs.GetInt("chosenname") == 50 ||
			PlayerPrefs.GetInt("chosenname") == 54 ||
			PlayerPrefs.GetInt("chosenname") == 55 ||
			PlayerPrefs.GetInt("chosenname") == 56 ||
			PlayerPrefs.GetInt("chosenname") == 58 ||
			PlayerPrefs.GetInt("chosenname") == 59 ||
			PlayerPrefs.GetInt("chosenname") == 60 ||
			PlayerPrefs.GetInt("chosenname") == 62 ||
			PlayerPrefs.GetInt("chosenname") == 64){
				text = text.Replace("ACTION2", "venus +");
			}
		}
		if(PlayerPrefs.GetInt("mixproduct") > 0){
			if(PlayerPrefs.GetInt("mixproduct") == 1){
				text = text.Replace("MIXNAME", "'ezevb");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 2){
				text = text.Replace("MIXNAME", "qebv'e");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 3){
				text = text.Replace("MIXNAME", "tesnev'e");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 4){
				text = text.Replace("MIXNAME", "qan");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 5){
				text = text.Replace("MIXNAME", "metamenyem");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 6){
				text = text.Replace("MIXNAME", "meshephh");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 7){
				text = text.Replace("MIXNAME", "qetn");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 8){
				text = text.Replace("MIXNAME", "g'yen");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 9){
				text = text.Replace("MIXNAME", "tesreyk");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 10){
				text = text.Replace("MIXNAME", "tetsevgh");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 11){
				text = text.Replace("MIXNAME", "mevnegvelyh");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 12){
				text = text.Replace("MIXNAME", "bhedregh");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 13){
				text = text.Replace("MIXNAME", "leyhh");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 14){
				text = text.Replace("MIXNAME", "masher");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 15){
				text = text.Replace("MIXNAME", "yev");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 16){
				text = text.Replace("MIXNAME", "'ever");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 17){
				text = text.Replace("MIXNAME", "gedvel vhezq");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 18){
				text = text.Replace("MIXNAME", "deyneg");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 19){
				text = text.Replace("MIXNAME", "tev'elet");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 20){
				text = text.Replace("MIXNAME", "metqelp");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 21){
				text = text.Replace("MIXNAME", "mevrekb");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 22){
				text = text.Replace("MIXNAME", "vebken");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 23){
				text = text.Replace("MIXNAME", "her");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 24){
				text = text.Replace("MIXNAME", "la tevb");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 25){
				text = text.Replace("MIXNAME", "mevrh");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 26){
				text = text.Replace("MIXNAME", "l'elevt");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 27){
				text = text.Replace("MIXNAME", "kegven");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 28){
				text = text.Replace("MIXNAME", "helm");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 29){
				text = text.Replace("MIXNAME", "qevn");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 30){
				text = text.Replace("MIXNAME", "hevshelmh kebr");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 31){
				text = text.Replace("MIXNAME", "nepredyem");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 32){
				text = text.Replace("MIXNAME", "helyepyen");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 33){
				text = text.Replace("MIXNAME", "meynegyey");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 34){
				text = text.Replace("MIXNAME", "meqtesv'en");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 35){
				text = text.Replace("MIXNAME", "hetsetbervet");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 36){
				text = text.Replace("MIXNAME", "heyh gedvelh");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 37){
				text = text.Replace("MIXNAME", "la");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 38){
				text = text.Replace("MIXNAME", "em");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 39){
				text = text.Replace("MIXNAME", "melvheym");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 40){
				text = text.Replace("MIXNAME", "r'el");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 41){
				text = text.Replace("MIXNAME", "tayelnedy");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 42){
				text = text.Replace("MIXNAME", "nhedr");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 43){
				text = text.Replace("MIXNAME", "avetv adem");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 44){
				text = text.Replace("MIXNAME", "lest");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 45){
				text = text.Replace("MIXNAME", "hep mepsh'");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 46){
				text = text.Replace("MIXNAME", "peyterven");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 47){
				text = text.Replace("MIXNAME", "peng");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 48){
				text = text.Replace("MIXNAME", "yebsh");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 49){
				text = text.Replace("MIXNAME", "heyh qetnh");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 50){
				text = text.Replace("MIXNAME", "beryhh");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 51){
				text = text.Replace("MIXNAME", "qev");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 52){
				text = text.Replace("MIXNAME", "leyteygetseyh");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 53){
				text = text.Replace("MIXNAME", "hetyebh");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 54){
				text = text.Replace("MIXNAME", "nezq");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 55){
				text = text.Replace("MIXNAME", "rezvelvetseyh");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 56){
				text = text.Replace("MIXNAME", "hevzer lahevt");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 57){
				text = text.Replace("MIXNAME", "menvemnem");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 58){
				text = text.Replace("MIXNAME", "gedvel m");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 59){
				text = text.Replace("MIXNAME", "lheltes");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 60){
				text = text.Replace("MIXNAME", "gavelh");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 61){
				text = text.Replace("MIXNAME", "revh");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 62){
				text = text.Replace("MIXNAME", "z'vengepv");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 63){
				text = text.Replace("MIXNAME", "lhetpezr");
			}
			if(PlayerPrefs.GetInt("mixproduct") == 64){
				text = text.Replace("MIXNAME", "pesteybel");
			}
		}
		characters = new string[text.Length];
		repeat = true;
	}

	void LetterIsSet(){
		ourx = ournewx;
		i += 1;
		StartCoroutine(Repeater());
	}
}
