using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public GameObject Player;
    public float speed = 10;
    public float rotateY = 0;
    public float RotationSpeed = 10f;
    public float time;
    private Animator anim;
    private bool c = true;


    float step = 2f;     // 移動速度


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        speed = 10;
    }
	
	// Update is called once per frame
	void Update () { 
        
        transform.position += transform.forward * speed * Time.deltaTime * 2;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rotateY += 90;
            //Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, rotateY, 0), 45 * RotationSpeed);
            transform.rotation = Quaternion.Euler(0,rotateY, 0);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
           
            rotateY -= 90;
            //Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, rotateY, 0), 45 * RotationSpeed);
            transform.rotation = Quaternion.Euler(0, rotateY, 0);  
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            speed += 2;
        }

        if (this.transform.position.y <= -3)
        {
            Debug.Log("やしが死んだよや！！");
            
            Instantiate(Player, new Vector3(0, 0, 0), Quaternion.identity);
            Destroy(gameObject);
            
        }
        if (c == false)
        {
            time += Time.deltaTime;
            if (time >= 2)
            {
                c = true;
            }
        }
        if (Input.GetKeyDown("c") && c == true)
        {
            anim.SetTrigger("get");
            time = 0;
            c = false;
        }
        



    }
    /*void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy" && anim)
        {
            Destroy(collision);
        }
    }*/
}
