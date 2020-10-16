using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nameselect_cursor : MonoBehaviour {

	//player inputs character name from navigable alphabet
	//"redo" resets name, "done" initiates game start

	Rigidbody2D rb2d;
	int position = 1, oldposition = 1;
	public float ax, ay, bx, by, cx, cy, dx, dy, ex, ey, fx, fy, gx, gy, hx, hy,
	ix, iy, jx, jy, kx, ky, lx, ly, mx, my, nx, ny, ox, oy, px, py, qx, qy, rx, ry,
	sx, sy, tx, ty, ux, uy, vx, vy, wx, wy, xx, xy, yx, yy, zx, zy, dashx, dashy,
	apostrox, apostroy, redox, redoy, donex, doney;
	bool begin = true;
	string name = "";
	public GameObject redosound, denysound, movesound;

	void Update () {
		if(begin){
			begin = false;
			rb2d = GetComponent<Rigidbody2D> ();
		}
		if(oldposition != position){
			oldposition = position;
			Instantiate(movesound, transform.position, Quaternion.identity);
		}
		if(position == 1){
			//a
			rb2d.MovePosition(new Vector2(transform.parent.position.x + ax,
			transform.parent.position.y + ay));
			if(Input.GetKeyDown("up")){
				position = 29;
			}
			if(Input.GetKeyDown("right")){
				position = 2;
			}
			if(Input.GetKeyDown("down")){
				position = 11;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "a";
				}
			}
		}
		else if(position == 2){
			//b
			rb2d.MovePosition(new Vector2(transform.parent.position.x + bx,
			transform.parent.position.y + by));
			if(Input.GetKeyDown("left")){
				position = 1;
			}
			if(Input.GetKeyDown("right")){
				position = 3;
			}
			if(Input.GetKeyDown("down")){
				position = 12;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "b";
				}
			}
		}
		else if(position == 3){
			//c
			rb2d.MovePosition(new Vector2(transform.parent.position.x + cx,
			transform.parent.position.y + cy));
			if(Input.GetKeyDown("left")){
				position = 2;
			}
			if(Input.GetKeyDown("right")){
				position = 4;
			}
			if(Input.GetKeyDown("down")){
				position = 13;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "c";
				}
			}
		}
		else if(position == 4){
			//d
			rb2d.MovePosition(new Vector2(transform.parent.position.x + dx,
			transform.parent.position.y + dy));
			if(Input.GetKeyDown("left")){
				position = 3;
			}
			if(Input.GetKeyDown("right")){
				position = 5;
			}
			if(Input.GetKeyDown("down")){
				position = 14;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "d";
				}
			}
		}
		else if(position == 5){
			//e
			rb2d.MovePosition(new Vector2(transform.parent.position.x + ex,
			transform.parent.position.y + ey));
			if(Input.GetKeyDown("left")){
				position = 4;
			}
			if(Input.GetKeyDown("right")){
				position = 6;
			}
			if(Input.GetKeyDown("down")){
				position = 15;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "e";
				}
			}
		}
		else if(position == 6){
			//f
			rb2d.MovePosition(new Vector2(transform.parent.position.x + fx,
			transform.parent.position.y + fy));
			if(Input.GetKeyDown("left")){
				position = 5;
			}
			if(Input.GetKeyDown("right")){
				position = 7;
			}
			if(Input.GetKeyDown("down")){
				position = 16;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "f";
				}
			}
		}
		else if(position == 7){
			//g
			rb2d.MovePosition(new Vector2(transform.parent.position.x + gx,
			transform.parent.position.y + gy));
			if(Input.GetKeyDown("left")){
				position = 6;
			}
			if(Input.GetKeyDown("right")){
				position = 8;
			}
			if(Input.GetKeyDown("down")){
				position = 17;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "g";
				}
			}
		}
		else if(position == 8){
			//h
			rb2d.MovePosition(new Vector2(transform.parent.position.x + hx,
			transform.parent.position.y + hy));
			if(Input.GetKeyDown("left")){
				position = 7;
			}
			if(Input.GetKeyDown("right")){
				position = 9;
			}
			if(Input.GetKeyDown("down")){
				position = 18;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "h";
				}
			}
		}
		else if(position == 9){
			//i
			rb2d.MovePosition(new Vector2(transform.parent.position.x + ix,
			transform.parent.position.y + iy));
			if(Input.GetKeyDown("left")){
				position = 8;
			}
			if(Input.GetKeyDown("right")){
				position = 10;
			}
			if(Input.GetKeyDown("down")){
				position = 19;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "i";
				}
			}
		}
		else if(position == 10){
			//j
			rb2d.MovePosition(new Vector2(transform.parent.position.x + jx,
			transform.parent.position.y + jy));
			if(Input.GetKeyDown("up")){
				position = 30;
			}
			if(Input.GetKeyDown("left")){
				position = 9;
			}
			if(Input.GetKeyDown("down")){
				position = 20;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "j";
				}
			}
		}
		else if(position == 11){
			//k
			rb2d.MovePosition(new Vector2(transform.parent.position.x + kx,
			transform.parent.position.y + ky));
			if(Input.GetKeyDown("up")){
				position = 1;
			}
			if(Input.GetKeyDown("right")){
				position = 12;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "k";
				}
			}
		}
		else if(position == 12){
			//l
			rb2d.MovePosition(new Vector2(transform.parent.position.x + lx,
			transform.parent.position.y + ly));
			if(Input.GetKeyDown("up")){
				position = 2;
			}
			if(Input.GetKeyDown("left")){
				position = 11;
			}
			if(Input.GetKeyDown("down")){
				position = 21;
			}
			if(Input.GetKeyDown("right")){
				position = 13;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "l";
				}
			}
		}
		else if(position == 13){
			//m
			rb2d.MovePosition(new Vector2(transform.parent.position.x + mx,
			transform.parent.position.y + my));
			if(Input.GetKeyDown("up")){
				position = 3;
			}
			if(Input.GetKeyDown("left")){
				position = 12;
			}
			if(Input.GetKeyDown("down")){
				position = 22;
			}
			if(Input.GetKeyDown("right")){
				position = 14;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "m";
				}
			}
		}
		else if(position == 14){
			//n
			rb2d.MovePosition(new Vector2(transform.parent.position.x + nx,
			transform.parent.position.y + ny));
			if(Input.GetKeyDown("up")){
				position = 4;
			}
			if(Input.GetKeyDown("left")){
				position = 13;
			}
			if(Input.GetKeyDown("down")){
				position = 23;
			}
			if(Input.GetKeyDown("right")){
				position = 15;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "n";
				}
			}
		}
		else if(position == 15){
			//o
			rb2d.MovePosition(new Vector2(transform.parent.position.x + ox,
			transform.parent.position.y + oy));
			if(Input.GetKeyDown("up")){
				position = 5;
			}
			if(Input.GetKeyDown("left")){
				position = 14;
			}
			if(Input.GetKeyDown("down")){
				position = 24;
			}
			if(Input.GetKeyDown("right")){
				position = 16;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "o";
				}
			}
		}
		else if(position == 16){
			//p
			rb2d.MovePosition(new Vector2(transform.parent.position.x + px,
			transform.parent.position.y + py));
			if(Input.GetKeyDown("up")){
				position = 6;
			}
			if(Input.GetKeyDown("left")){
				position = 15;
			}
			if(Input.GetKeyDown("down")){
				position = 25;
			}
			if(Input.GetKeyDown("right")){
				position = 17;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "p";
				}
			}
		}
		else if(position == 17){
			//q
			rb2d.MovePosition(new Vector2(transform.parent.position.x + qx,
			transform.parent.position.y + qy));
			if(Input.GetKeyDown("up")){
				position = 7;
			}
			if(Input.GetKeyDown("left")){
				position = 16;
			}
			if(Input.GetKeyDown("down")){
				position = 26;
			}
			if(Input.GetKeyDown("right")){
				position = 18;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "q";
				}
			}
		}
		else if(position == 18){
			//r
			rb2d.MovePosition(new Vector2(transform.parent.position.x + rx,
			transform.parent.position.y + ry));
			if(Input.GetKeyDown("up")){
				position = 8;
			}
			if(Input.GetKeyDown("left")){
				position = 17;
			}
			if(Input.GetKeyDown("down")){
				position = 27;
			}
			if(Input.GetKeyDown("right")){
				position = 19;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "r";
				}
			}
		}
		else if(position == 19){
			//s
			rb2d.MovePosition(new Vector2(transform.parent.position.x + sx,
			transform.parent.position.y + sy));
			if(Input.GetKeyDown("up")){
				position = 9;
			}
			if(Input.GetKeyDown("left")){
				position = 18;
			}
			if(Input.GetKeyDown("down")){
				position = 28;
			}
			if(Input.GetKeyDown("right")){
				position = 20;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "s";
				}
			}
		}
		else if(position == 20){
			//t
			rb2d.MovePosition(new Vector2(transform.parent.position.x + tx,
			transform.parent.position.y + ty));
			if(Input.GetKeyDown("up")){
				position = 10;
			}
			if(Input.GetKeyDown("left")){
				position = 19;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "t";
				}
			}
		}
		else if(position == 21){
			//u
			rb2d.MovePosition(new Vector2(transform.parent.position.x + ux,
			transform.parent.position.y + uy));
			if(Input.GetKeyDown("up")){
				position = 12;
			}
			if(Input.GetKeyDown("right")){
				position = 22;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "u";
				}
			}
		}
		else if(position == 22){
			//v
			rb2d.MovePosition(new Vector2(transform.parent.position.x + vx,
			transform.parent.position.y + vy));
			if(Input.GetKeyDown("up")){
				position = 13;
			}
			if(Input.GetKeyDown("left")){
				position = 21;
			}
			if(Input.GetKeyDown("right")){
				position = 23;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "v";
				}
			}
		}
		else if(position == 23){
			//w
			rb2d.MovePosition(new Vector2(transform.parent.position.x + wx,
			transform.parent.position.y + wy));
			if(Input.GetKeyDown("up")){
				position = 14;
			}
			if(Input.GetKeyDown("left")){
				position = 22;
			}
			if(Input.GetKeyDown("right")){
				position = 24;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "w";
				}
			}
		}
		else if(position == 24){
			//x
			rb2d.MovePosition(new Vector2(transform.parent.position.x + xx,
			transform.parent.position.y + xy));
			if(Input.GetKeyDown("up")){
				position = 15;
			}
			if(Input.GetKeyDown("left")){
				position = 23;
			}
			if(Input.GetKeyDown("right")){
				position = 25;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "x";
				}
			}
		}
		else if(position == 25){
			//y
			rb2d.MovePosition(new Vector2(transform.parent.position.x + yx,
			transform.parent.position.y + yy));
			if(Input.GetKeyDown("up")){
				position = 16;
			}
			if(Input.GetKeyDown("left")){
				position = 24;
			}
			if(Input.GetKeyDown("right")){
				position = 26;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "y";
				}
			}
		}
		else if(position == 26){
			//z
			rb2d.MovePosition(new Vector2(transform.parent.position.x + zx,
			transform.parent.position.y + zy));
			if(Input.GetKeyDown("up")){
				position = 17;
			}
			if(Input.GetKeyDown("left")){
				position = 25;
			}
			if(Input.GetKeyDown("right")){
				position = 27;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "z";
				}
			}
		}
		else if(position == 27){
			//-
			rb2d.MovePosition(new Vector2(transform.parent.position.x + dashx,
			transform.parent.position.y + dashy));
			if(Input.GetKeyDown("up")){
				position = 18;
			}
			if(Input.GetKeyDown("left")){
				position = 26;
			}
			if(Input.GetKeyDown("right")){
				position = 28;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "-";
				}
			}
		}
		else if(position == 28){
			//'
			rb2d.MovePosition(new Vector2(transform.parent.position.x + apostrox,
			transform.parent.position.y + apostroy));
			if(Input.GetKeyDown("up")){
				position = 19;
			}
			if(Input.GetKeyDown("left")){
				position = 27;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length < 12){
					name += "\'";
				}
			}
		}
		else if(position == 29){
			//redo
			rb2d.MovePosition(new Vector2(transform.parent.position.x + redox,
			transform.parent.position.y + redoy));
			if(Input.GetKeyDown("down")){
				position = 1;
			}
			if(Input.GetKeyDown("right")){
				position = 30;
			}
			if(Input.GetKeyDown("space")){
				name = "";
				Instantiate(redosound, transform.position, Quaternion.identity);
			}
		}
		else if(position == 30){
			//done
			rb2d.MovePosition(new Vector2(transform.parent.position.x + donex,
			transform.parent.position.y + doney));
			if(Input.GetKeyDown("down")){
				position = 10;
			}
			if(Input.GetKeyDown("left")){
				position = 29;
			}
			if(Input.GetKeyDown("space")){
				if(name.Length > 0){
					PlayerPrefs.SetInt("screenclear", 1);
				}
				else{
					Instantiate(denysound, transform.position, Quaternion.identity);
				}
			}
		}
		PlayerPrefs.SetString("playername", name);
	}
}
