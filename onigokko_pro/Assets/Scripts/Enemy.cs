using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
   
    private float rotationY = 0;
    public float speed = 1;
    
  

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        
        transform.position += transform.forward * speed * Time.deltaTime * 2;

        if (this.transform.position.y <= -3)
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        float turn = Random.Range(0, 2);
        float turn3 = Random.Range(0, 3);
        if (other.gameObject.tag == "EnemyM")
        {
            
            if (turn == 0)
            {
                Debug.Log("0や！");
                rotationY += 90f;
                gameObject.transform.rotation = Quaternion.Euler(0,rotationY, 0);
            }
            else if(turn == 1)
            {
                Debug.Log("１や！");
                rotationY -= 90f;
                gameObject.transform.rotation = Quaternion.Euler(0, rotationY, 0);
            }
        }
        if(other.gameObject.tag == "EnemyM3")
        {
            if (turn3 == 0)
            {
                Debug.Log("0や！");
                rotationY += 90f;
                gameObject.transform.rotation = Quaternion.Euler(0, rotationY, 0);
            }
            else if (turn3 == 1)
            {
                Debug.Log("１や！");
                rotationY -= 90f;
                gameObject.transform.rotation = Quaternion.Euler(0, rotationY, 0);
            }
            else if(turn3 == 2)
            {
                Debug.Log("2や！");
                rotationY += 0f;
                gameObject.transform.rotation = Quaternion.Euler(0, rotationY, 0);
            }
        }
        else if(other.gameObject.tag == "EnemyR")
        {
            rotationY += 90f;
            Debug.Log("あたってるよ");
            transform.rotation = Quaternion.Euler(0, rotationY, 0);
            
        }
        else if (other.gameObject.tag == "EnemyL")
        {
            rotationY -= 90f;
            Debug.Log("あたってるよ");
            transform.rotation = Quaternion.Euler(0, rotationY, 0);

        }

    }

}
