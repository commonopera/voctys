using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talktake : MonoBehaviour {

	//controls talktake menu cursor
	//spawns dialogue based on character and dialogue sequence

	Rigidbody2D rb2d;
	int position = 1;
	bool begin = true;
	public bool chelbo, elazar, komlin, machir, meir, natronai, shabsai, sulam,
	uri, zuiskind;
	public GameObject fade, d000a, d000b, d001a, d002a, d003a, d004a, d005a, d006a,
	d007a, d008a, d009a, d010a, d011a, d012a, d013a, d014a, d015a, d016a, d017a, d018a,
	d019a, d020a, d021a, d022a,
	d100a, d100b, d101a, d102a, d103a, d104a, d105a, d106a, d107a, d108a,
	d150a, d151a, d152a, d153a, d154a, d155a, d156a, d157a, d158a, d159a,
	d200a, d200b, d201a, d202a, d203a, d204a, d205a, d206a, d207a, d208a, d209a, d210a,
	d211a, d250a, d251a, d252a, d253a, d254a, d275a, d276a, d277a, d278a, d279a, d280a,
	d281a, d282a, d283a,
	d300a, d300b, d301a, d302a, d303a, d304a, d305a, d306a, d307a, d308a, d309a, d310a,
	d311a, d312a, d313a, d351a, d352a, d353a, d354a, d375a, d376a, d377a, d378a, d379a,
	d400a, d400b, d401a, d402a, d403a, d404a, d405a, d451a, d452a, d453a, d454a, d455a,
	d456a, d470a, d471a, d472a,
	d500a, d500b, d501a, d502a, d503a, d504a, d505a, d506a, d507a, d508a, d509a, d510a,
	d511a, d550a, d551a, d552a, d553a, d554a, d555a, d556a, d557a, d558a, d559a,
	d600a, d600b, d601a, d602a, d603a, d604a, d605a, d606a, d607a, d608a, d609a, d610a,
	d650a, d651a, d652a, d653a, d654a, d675a, d676a, d677a, d678a, d679a,
	d700a, d700b, d701a, d702a, d703a, d704a, d705a, d706a, d707a, d708a, d709a, d710a,
	d751a, d752a, d753a, d754a, d755a, d756a, d757a, d775a, d776a,
	d800a, d800b, d801a, d802a, d803a, d804a, d805a, d806a, d807a, d808a, d809a, d810a,
	d811a, d812a, d813a, d814a, d850a, d851a, d852a, d853a, d854a, d855a, d856a, d857a,
	d875a, d876a, d877a,
	d900a, d900b, d901a, d902a, d903a, d904a, d905a, d906a, d907a, d950a, d951a, d975a,
	d976a, d977a, d978a, d979a, d980a,
	switchsfx;
	public float diax, diay = -2.585f;

	void Update () {
		if(begin){
			begin = false;
			rb2d = GetComponent<Rigidbody2D> ();
			PlayerPrefs.SetInt("frozen", 1);
		}
		if(position == 1){
			//talk
			rb2d.MovePosition(new Vector2(transform.parent.position.x,
			transform.parent.position.y + 0.055f));
			if(Input.GetKeyDown("space")){

				//CHELBO:
				if(chelbo){
					if(PlayerPrefs.GetInt("seq_chelbo") == 0){
						Instantiate(d000b, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 1){
						Instantiate(d001a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 2){
						Instantiate(d002a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 3){
						Instantiate(d003a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 4){
						Instantiate(d004a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 5){
						Instantiate(d005a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 6){
						Instantiate(d006a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 7){
						Instantiate(d007a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 8){
						Instantiate(d008a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 9){
						Instantiate(d009a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 10){
						Instantiate(d010a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 11){
						Instantiate(d011a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 12){
						Instantiate(d012a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 13){
						Instantiate(d013a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 14){
						Instantiate(d014a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 15){
						Instantiate(d015a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 16){
						Instantiate(d016a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 17){
						Instantiate(d017a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 18){
						Instantiate(d018a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 19){
						Instantiate(d019a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 20){
						Instantiate(d020a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 21){
						Instantiate(d021a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_chelbo") == 22){
						Instantiate(d022a, new Vector2(diax, diay), Quaternion.identity);
					}
				}

				//ELAZAR:
				if(elazar){
					if(PlayerPrefs.GetInt("seq_elazar") == 0){
						Instantiate(d100b, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_elazar") == 1){
						Instantiate(d101a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_elazar") == 2){
						Instantiate(d102a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_elazar") == 3){
						Instantiate(d103a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_elazar") == 4){
						Instantiate(d104a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_elazar") == 5){
						Instantiate(d105a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_elazar") == 6){
						Instantiate(d106a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_elazar") == 7){
						Instantiate(d107a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_elazar") == 8){
						Instantiate(d108a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_elazar") == 50){
						Instantiate(d150a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_elazar") == 51){
						Instantiate(d151a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_elazar") == 52){
						Instantiate(d152a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_elazar") == 53){
						Instantiate(d153a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_elazar") == 54){
						Instantiate(d154a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_elazar") == 55){
						Instantiate(d155a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_elazar") == 56){
						Instantiate(d156a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_elazar") == 57){
						Instantiate(d157a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_elazar") == 58){
						Instantiate(d158a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_elazar") == 59){
						Instantiate(d159a, new Vector2(diax, diay), Quaternion.identity);
					}
				}

				//KOMLIN:
				if(komlin){
					if(PlayerPrefs.GetInt("seq_komlin") == 0){
						Instantiate(d200b, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 1){
						Instantiate(d201a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 2){
						Instantiate(d202a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 3){
						Instantiate(d203a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 4){
						Instantiate(d204a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 5){
						Instantiate(d205a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 6){
						Instantiate(d206a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 7){
						Instantiate(d207a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 8){
						Instantiate(d208a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 9){
						Instantiate(d209a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 10){
						Instantiate(d210a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 11){
						Instantiate(d211a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 50){
						Instantiate(d250a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 51){
						Instantiate(d251a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 52){
						Instantiate(d252a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 53){
						Instantiate(d253a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 54){
						Instantiate(d254a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 75){
						Instantiate(d275a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 76){
						Instantiate(d276a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 77){
						Instantiate(d277a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 78){
						Instantiate(d278a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 79){
						Instantiate(d279a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 80){
						Instantiate(d280a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 81){
						Instantiate(d281a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 82){
						Instantiate(d282a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_komlin") == 83){
						Instantiate(d283a, new Vector2(diax, diay), Quaternion.identity);
					}
				}

				//MACHIR:
				if(machir){
					if(PlayerPrefs.GetInt("seq_machir") == 0){
						Instantiate(d300b, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 1){
						Instantiate(d301a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 2){
						Instantiate(d302a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 3){
						Instantiate(d303a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 4){
						Instantiate(d304a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 5){
						Instantiate(d305a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 6){
						Instantiate(d306a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 7){
						Instantiate(d307a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 8){
						Instantiate(d308a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 9){
						Instantiate(d309a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 10){
						Instantiate(d310a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 11){
						Instantiate(d311a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 12){
						Instantiate(d312a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 13){
						Instantiate(d313a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 51){
						Instantiate(d351a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 52){
						Instantiate(d352a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 53){
						Instantiate(d353a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 54){
						Instantiate(d354a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 75){
						Instantiate(d375a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 76){
						Instantiate(d376a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 77){
						Instantiate(d377a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 78){
						Instantiate(d378a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_machir") == 79){
						Instantiate(d379a, new Vector2(diax, diay), Quaternion.identity);
					}
				}

				//MEIR:
				if(meir){
					if(PlayerPrefs.GetInt("seq_meir") == 0){
						Instantiate(d400b, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_meir") == 1){
						Instantiate(d401a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_meir") == 2){
						Instantiate(d402a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_meir") == 3){
						Instantiate(d403a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_meir") == 4){
						Instantiate(d404a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_meir") == 5){
						Instantiate(d405a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_meir") == 51){
						Instantiate(d451a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_meir") == 52){
						Instantiate(d452a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_meir") == 53){
						Instantiate(d453a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_meir") == 54){
						Instantiate(d454a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_meir") == 55){
						Instantiate(d455a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_meir") == 56){
						Instantiate(d456a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_meir") == 70){
						Instantiate(d470a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_meir") == 71){
						Instantiate(d471a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_meir") == 72){
						Instantiate(d472a, new Vector2(diax, diay), Quaternion.identity);
					}
				}

				//NATRONAI:
				if(natronai){
					if(PlayerPrefs.GetInt("seq_natronai") == 0){
						Instantiate(d500b, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 1){
						Instantiate(d501a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 2){
						Instantiate(d502a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 3){
						Instantiate(d503a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 4){
						Instantiate(d504a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 5){
						Instantiate(d505a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 6){
						Instantiate(d506a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 7){
						Instantiate(d507a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 8){
						Instantiate(d508a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 9){
						Instantiate(d509a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 10){
						Instantiate(d510a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 11){
						Instantiate(d511a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 49 || PlayerPrefs.GetInt("seq_natronai") == 50){
						Instantiate(d550a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 51){
						Instantiate(d551a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 52){
						Instantiate(d552a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 53){
						Instantiate(d553a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 54){
						Instantiate(d554a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 55){
						Instantiate(d555a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 56){
						Instantiate(d556a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 57){
						Instantiate(d557a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 58){
						Instantiate(d558a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_natronai") == 59){
						Instantiate(d559a, new Vector2(diax, diay), Quaternion.identity);
					}
				}

				//SHABSAI:
				if(shabsai){
					if(PlayerPrefs.GetInt("seq_shabsai") == 0){
						Instantiate(d600b, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 1){
						Instantiate(d601a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 2){
						Instantiate(d602a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 3){
						Instantiate(d603a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 4){
						Instantiate(d604a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 5){
						Instantiate(d605a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 6){
						Instantiate(d606a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 7){
						Instantiate(d607a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 8){
						Instantiate(d608a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 9){
						Instantiate(d609a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 10){
						Instantiate(d610a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 50){
						Instantiate(d650a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 51){
						Instantiate(d651a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 52){
						Instantiate(d652a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 53){
						Instantiate(d653a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 54){
						Instantiate(d654a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 75){
						Instantiate(d675a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 76){
						Instantiate(d676a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 77){
						Instantiate(d677a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 78){
						Instantiate(d678a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_shabsai") == 79){
						Instantiate(d679a, new Vector2(diax, diay), Quaternion.identity);
					}
				}

				//SULAM:
				if(sulam){
					if(PlayerPrefs.GetInt("seq_sulam") == 0){
						Instantiate(d700b, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_sulam") == 1){
						Instantiate(d701a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_sulam") == 2){
						Instantiate(d702a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_sulam") == 3){
						Instantiate(d703a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_sulam") == 4){
						Instantiate(d704a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_sulam") == 5){
						Instantiate(d705a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_sulam") == 6){
						Instantiate(d706a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_sulam") == 7){
						Instantiate(d707a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_sulam") == 8){
						Instantiate(d708a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_sulam") == 9){
						Instantiate(d709a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_sulam") == 10){
						Instantiate(d710a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_sulam") == 51){
						Instantiate(d751a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_sulam") == 52){
						Instantiate(d752a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_sulam") == 53){
						Instantiate(d753a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_sulam") == 54){
						Instantiate(d754a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_sulam") == 55){
						Instantiate(d755a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_sulam") == 56){
						Instantiate(d756a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_sulam") == 57){
						Instantiate(d757a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_sulam") == 75){
						Instantiate(d775a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_sulam") == 76){
						Instantiate(d776a, new Vector2(diax, diay), Quaternion.identity);
					}
				}

				//URI:
				if(uri){
					if(PlayerPrefs.GetInt("seq_uri") == 0){
						Instantiate(d800b, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 1){
						Instantiate(d801a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 2){
						Instantiate(d802a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 3){
						Instantiate(d803a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 4){
						Instantiate(d804a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 5){
						Instantiate(d805a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 6){
						Instantiate(d806a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 7){
						Instantiate(d807a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 8){
						Instantiate(d808a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 9){
						Instantiate(d809a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 10){
						Instantiate(d810a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 11){
						Instantiate(d811a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 12){
						Instantiate(d812a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 13){
						Instantiate(d813a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 14){
						Instantiate(d814a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 50){
						Instantiate(d850a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 51){
						Instantiate(d851a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 52){
						Instantiate(d852a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 53){
						Instantiate(d853a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 54){
						Instantiate(d854a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 55){
						Instantiate(d855a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 56){
						Instantiate(d856a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 57){
						Instantiate(d857a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 75){
						Instantiate(d875a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 76){
						Instantiate(d876a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_uri") == 77){
						Instantiate(d877a, new Vector2(diax, diay), Quaternion.identity);
					}
				}

				//ZUISKIND:
				if(zuiskind){
					if(PlayerPrefs.GetInt("seq_zuiskind") == 0){
						Instantiate(d900b, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_zuiskind") == 1){
						Instantiate(d901a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_zuiskind") == 2){
						Instantiate(d902a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_zuiskind") == 3){
						Instantiate(d903a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_zuiskind") == 4){
						Instantiate(d904a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_zuiskind") == 5){
						Instantiate(d905a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_zuiskind") == 6){
						Instantiate(d906a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_zuiskind") == 7){
						Instantiate(d907a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_zuiskind") == 50){
						Instantiate(d950a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_zuiskind") == 51){
						Instantiate(d951a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_zuiskind") == 75){
						Instantiate(d975a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_zuiskind") == 76){
						Instantiate(d976a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_zuiskind") == 77){
						Instantiate(d977a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_zuiskind") == 78){
						Instantiate(d978a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_zuiskind") == 79){
						Instantiate(d979a, new Vector2(diax, diay), Quaternion.identity);
					}
					if(PlayerPrefs.GetInt("seq_zuiskind") == 80){
						Instantiate(d980a, new Vector2(diax, diay), Quaternion.identity);
					}
				}

				Instantiate(fade, transform.parent.position, Quaternion.identity);
				Destroy(transform.parent.gameObject);
			}
			if(Input.GetKeyDown("down")){
				position = 2;
				Instantiate(switchsfx, transform.position, Quaternion.identity);
			}
		}

		if(position == 2){
			//take
			rb2d.MovePosition(new Vector2(transform.parent.position.x,
			transform.parent.position.y - 0.035f));
			if(Input.GetKeyDown("space")){
				if(chelbo){
					if(PlayerPrefs.GetInt("seq_chelbo") > 0){
						Instantiate(d000a, new Vector2(diax, diay), Quaternion.identity);
						PlayerPrefs.SetInt("seq_chelbo", 0);
						PlayerPrefs.SetInt("sacrednames", (PlayerPrefs.GetInt("sacrednames") + 1));
						PlayerPrefs.SetInt("name11", 1);
					}
					else if(PlayerPrefs.GetInt("seq_chelbo") == 0){
						Instantiate(d000b, new Vector2(diax, diay), Quaternion.identity);
					}
				}
				if(elazar){
					if(PlayerPrefs.GetInt("seq_elazar") > 0){
						Instantiate(d100a, new Vector2(diax, diay), Quaternion.identity);
						PlayerPrefs.SetInt("seq_elazar", 0);
						PlayerPrefs.SetInt("sacrednames", (PlayerPrefs.GetInt("sacrednames") + 1));
						PlayerPrefs.SetInt("name12", 1);
					}
					else if(PlayerPrefs.GetInt("seq_elazar") == 0){
						Instantiate(d100b, new Vector2(diax, diay), Quaternion.identity);
					}
				}
				if(komlin){
					if(PlayerPrefs.GetInt("seq_komlin") > 0){
						Instantiate(d200a, new Vector2(diax, diay), Quaternion.identity);
						PlayerPrefs.SetInt("seq_komlin", 0);
						PlayerPrefs.SetInt("sacrednames", (PlayerPrefs.GetInt("sacrednames") + 1));
						PlayerPrefs.SetInt("name13", 1);
					}
					else if(PlayerPrefs.GetInt("seq_komlin") == 0){
						Instantiate(d200b, new Vector2(diax, diay), Quaternion.identity);
					}
				}
				if(machir){
					if(PlayerPrefs.GetInt("seq_machir") > 0){
						Instantiate(d300a, new Vector2(diax, diay), Quaternion.identity);
						PlayerPrefs.SetInt("seq_machir", 0);
						PlayerPrefs.SetInt("sacrednames", (PlayerPrefs.GetInt("sacrednames") + 1));
						PlayerPrefs.SetInt("name14", 1);
					}
					else if(PlayerPrefs.GetInt("seq_machir") == 0){
						Instantiate(d300b, new Vector2(diax, diay), Quaternion.identity);
					}
				}
				if(meir){
					if(PlayerPrefs.GetInt("seq_meir") > 0){
						Instantiate(d400a, new Vector2(diax, diay), Quaternion.identity);
						PlayerPrefs.SetInt("seq_meir", 0);
						PlayerPrefs.SetInt("sacrednames", (PlayerPrefs.GetInt("sacrednames") + 1));
						PlayerPrefs.SetInt("name15", 1);
					}
					else if(PlayerPrefs.GetInt("seq_meir") == 0){
						Instantiate(d400b, new Vector2(diax, diay), Quaternion.identity);
					}
				}
				if(natronai){
					if(PlayerPrefs.GetInt("seq_natronai") > 0){
						Instantiate(d500a, new Vector2(diax, diay), Quaternion.identity);
						PlayerPrefs.SetInt("seq_natronai", 0);
						PlayerPrefs.SetInt("sacrednames", (PlayerPrefs.GetInt("sacrednames") + 1));
						PlayerPrefs.SetInt("name16", 1);
					}
					else if(PlayerPrefs.GetInt("seq_natronai") == 0){
						Instantiate(d500b, new Vector2(diax, diay), Quaternion.identity);
					}
				}
				if(shabsai){
					if(PlayerPrefs.GetInt("seq_shabsai") > 0){
						Instantiate(d600a, new Vector2(diax, diay), Quaternion.identity);
						PlayerPrefs.SetInt("seq_shabsai", 0);
						PlayerPrefs.SetInt("sacrednames", (PlayerPrefs.GetInt("sacrednames") + 1));
						PlayerPrefs.SetInt("name17", 1);
					}
					else if(PlayerPrefs.GetInt("seq_shabsai") == 0){
						Instantiate(d600b, new Vector2(diax, diay), Quaternion.identity);
					}
				}
				if(sulam){
					if(PlayerPrefs.GetInt("seq_sulam") > 0){
						Instantiate(d700a, new Vector2(diax, diay), Quaternion.identity);
						PlayerPrefs.SetInt("seq_sulam", 0);
						PlayerPrefs.SetInt("sacrednames", (PlayerPrefs.GetInt("sacrednames") + 1));
						PlayerPrefs.SetInt("name18", 1);
					}
					else if(PlayerPrefs.GetInt("seq_sulam") == 0){
						Instantiate(d700b, new Vector2(diax, diay), Quaternion.identity);
					}
				}
				if(uri){
					if(PlayerPrefs.GetInt("seq_uri") > 0){
						Instantiate(d800a, new Vector2(diax, diay), Quaternion.identity);
						PlayerPrefs.SetInt("seq_uri", 0);
						PlayerPrefs.SetInt("sacrednames", (PlayerPrefs.GetInt("sacrednames") + 1));
						PlayerPrefs.SetInt("name10", 1);
					}
					else if(PlayerPrefs.GetInt("seq_uri") == 0){
						Instantiate(d800b, new Vector2(diax, diay), Quaternion.identity);
					}
				}
				if(zuiskind){
					if(PlayerPrefs.GetInt("seq_zuiskind") > 0){
						Instantiate(d900a, new Vector2(diax, diay), Quaternion.identity);
						PlayerPrefs.SetInt("seq_zuiskind", 0);
						PlayerPrefs.SetInt("sacrednames", (PlayerPrefs.GetInt("sacrednames") + 1));
						PlayerPrefs.SetInt("name19", 1);
					}
					else if(PlayerPrefs.GetInt("seq_zuiskind") == 0){
						Instantiate(d900b, new Vector2(diax, diay), Quaternion.identity);
					}
				}
				Instantiate(fade, transform.parent.position, Quaternion.identity);
				Destroy(transform.parent.gameObject);
			}
			if(Input.GetKeyDown("up")){
				position = 1;
				Instantiate(switchsfx, transform.position, Quaternion.identity);
			}
		}
	}
}
