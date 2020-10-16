using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud_drift : MonoBehaviour {

	//clouds pick a random shape and random y coordinate upon load
	//drift right at random rate between .5x and 2x 'speed' input
	//destroy upon contact with 'kloudkiller' object at far end

	Rigidbody2D rb2d;
	public float speed;
	public Sprite c1, c2, c3, c4, c5, c6, c7, c8, c9;
	SpriteRenderer renderer;
	int numero;

	void Start () {
		renderer = GetComponent<SpriteRenderer>();
		rb2d = GetComponent<Rigidbody2D> ();
		numero = (Random.Range(1, 10));
		if(numero == 1){
			renderer.sprite = c1;
		}
		if(numero == 2){
			renderer.sprite = c2;
		}
		if(numero == 3){
			renderer.sprite = c3;
		}
		if(numero == 4){
			renderer.sprite = c4;
		}
		if(numero == 5){
			renderer.sprite = c5;
		}
		if(numero == 6){
			renderer.sprite = c6;
		}
		if(numero == 7){
			renderer.sprite = c7;
		}
		if(numero == 8){
			renderer.sprite = c8;
		}
		if(numero == 9){
			renderer.sprite = c9;
		}
		rb2d.MovePosition(new Vector2(transform.position.x, Random.Range(-3.8f, 3.8f)));
		StartCoroutine(StartMoving());

	}

	IEnumerator StartMoving(){
		yield return new WaitForSeconds(.5f);
		rb2d.AddForce(new Vector2(1, 0) * speed * Random.Range(0.5f, 2.0f));
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "kloudkiller"){
			Destroy(gameObject);
		}
	}
}
