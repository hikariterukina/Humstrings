using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour {
	private Animator anim; 
	private float time;
	public float speed = 3.0f;
	private bool c = true;
	void Start()
	{
		anim = GetComponent<Animator> ();
	}
	// Update is called once per frame
	void Update ()
	{
		if (c == false) {
			time += Time.deltaTime;
			if (time >= 2) {
				c = true;
			}
		}
		if (Input.GetKeyDown("c")&& c == true){
			anim.SetTrigger ("get");
			time = 0;
			c = false;
		}
		if (Input.GetKey ("up")) {
			transform.position += transform.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey ("down")) {
			transform.position -= transform.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey ("right")) {
			transform.position += transform.right * speed * Time.deltaTime;
		}
		if (Input.GetKey ("left")) {
			transform.position -= transform.right * speed * Time.deltaTime;
		}
	}
}
