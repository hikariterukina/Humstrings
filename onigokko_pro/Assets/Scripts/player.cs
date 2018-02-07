﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class player : MonoBehaviour {
    public GameObject Player;
    //public GameObject Speedup;
    public float speed = 10;
    private float rotateY = 0;
    public float RotationSpeed = 1f;
    public float time;
    private Animator anim;
    private bool c = true;
    public GameObject Dush;

    //タッチテスト↓
    public bool widthReference = true;
    public float validWidth = 0.25f;
    public float timeout =  0.5f;

    Vector2 startPos;  //スワイプ開始座標
    Vector2 endPos;   //スワイプ終了座標
    float limiTime;   //スワイプ時間制限
    bool pressing; 　　//一つの指反応を取得

    Vector2 swipeDir = Vector2.zero;  //スワイプ距離で、スワイプ方向取得

    //↓スワイプ方向取得プロパティ　（フレーム毎取得用）
    public Vector2 Direction
    {
        get { return swipeDir; }
    }
    //スワイプイベントコールバック（インスペクタで変更用）
    [Serializable]
    public class SwipeHandler : UnityEvent<Vector2> {
    }

    public SwipeHandler OnSwipe;

    //アプリを中断した時とかにはリセットする
     void OnEnable()
    {
        pressing = false;
    }


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        speed = 10;
        
    }


	
	// Update is called once per frame
	void Update () { 
        
        transform.position += transform.forward * speed * Time.deltaTime * 2;
        swipeDir = Vector2.zero; //１フレームごとにタッチをリセット
#if !UNITY_EDITOR && (UNITY_ANDROID || UNITYIOS) //
        if(Input.touchCount == 1) 
#endif
        {
            if(!pressing && Input.GetMouseButtonDown(0))
            {
                pressing = true;
                startPos = Input.mousePosition;
                limiTime = Time.time + timeout;
            }
            else if(pressing && Input.GetMouseButtonUp(0))
            {
                pressing = false;
                if(Time.time < limiTime)
                {
                    endPos = Input.mousePosition;

                    Vector2 dist = endPos - startPos;
                    float dx = Mathf.Abs(dist.x);
                    float dy = Mathf.Abs(dist.y);
                    float requiredPX = widthReference ? Screen.width * validWidth : Screen.height * validWidth;

                    if(dy < dx)
                    {
                        if(requiredPX < dx)
                        {
                            
                            swipeDir = Mathf.Sign(dist.x) < 0 ? Vector2.left : Vector2.right;
                            if(swipeDir == Vector2.left)
                            {
                                Debug.Log("左決まった！");
                                StartCoroutine(Leftoon());    
                            }
                            else if(swipeDir == Vector2.right)
                            {
                                Debug.Log("右決まった！");
                                StartCoroutine(Rightoon());
                            }
                        }
                    }else
                    {
                        if(requiredPX < dy)
                        {
                            swipeDir = Mathf.Sign(dist.y) < 0 ? Vector2.down : Vector2.up;
                            if(swipeDir == Vector2.down)
                            {
                                Debug.Log("捕まえるんやで");
                                anim.SetTrigger("get");
                                time = 0;
                                c = false;
                                speed = 10;
                               
                            }
                            else if(swipeDir == Vector2.up)
                            { 
                                speed += 2;
                                Debug.Log("加速！！！");
                                Instantiate(Dush, new Vector3(100, -205, 125), Quaternion.identity);
                            }
                        }
                    }
                    if(swipeDir != Vector2.zero)
                    {
                        if(OnSwipe != null)
                        {
                            OnSwipe.Invoke(swipeDir);
                        }
                    }
                }
            }
        }
#if !UNITY_EDITOR && (UNITY_ANDROID || UNITY_IOS)
        else
        {
        pressing =false;
        }
#endif
        



        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            StartCoroutine(Rightoon());
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
        
            StartCoroutine(Leftoon());
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Instantiate(Dush, new Vector3(100, -205, 125), Quaternion.identity);
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
        if (Input.GetKeyDown(KeyCode.DownArrow) && c == true)
        {
            anim.SetTrigger("get");
            time = 0;
            c = false;
            speed = 10;
        }
        



    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" )
        {
            Destroy(collision.gameObject);
        }
    }
    IEnumerator Rightoon()
    {
        for(int i = 0; i < 5; i++)
        {
            rotateY += 18;
            transform.rotation = Quaternion.Euler(0, rotateY, 0);
            yield return new WaitForSeconds(0.0001f);
        }
        StopCoroutine(Rightoon());

    }
    IEnumerator Leftoon()
    {
        for(int i = 0; i < 5; i++)
        {
            rotateY -= 18;
            transform.rotation = Quaternion.Euler(0, rotateY, 0);
            yield return new WaitForSeconds(0.0001f);
        }
        StopCoroutine(Leftoon());

    }
}
