using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    Rigidbody2D rigid;
    SpriteRenderer sr;
    Animator anim;
    public float moveSpeed;
    public bool controls = true;

    void Start(){
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator> ();
        sr = GetComponent<SpriteRenderer>();
        moveSpeed = 3;
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f ){
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
        }
        if(Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f ){
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
        }
        if (Input.GetAxisRaw ("Horizontal") > 0) {
				anim.SetBool ("MoveX", true);
				anim.SetBool ("MoveUp", false);
				anim.SetBool ("MoveDown", false);
				sr.flipX = true;
				anim.speed = 1;
			} else if (Input.GetAxisRaw ("Horizontal") < 0) {
				anim.SetBool ("MoveX", true);
				anim.SetBool ("MoveUp", false);
				anim.SetBool ("MoveDown", false);
				sr.flipX = false;
				anim.speed = 1;
		} else if (Input.GetAxisRaw ("Vertical") < 0) {
				anim.SetBool ("MoveX", false);
				anim.SetBool ("MoveUp", false);
				anim.SetBool ("MoveDown", true);
				anim.speed = 1;
		} else if (Input.GetAxisRaw ("Vertical") > 0) {
				anim.SetBool ("MoveX", false);
				anim.SetBool ("MoveUp", true);
				anim.SetBool ("MoveDown", false);
				anim.speed = 1;
			} else {
				anim.speed = 0;
			}
    }

}
