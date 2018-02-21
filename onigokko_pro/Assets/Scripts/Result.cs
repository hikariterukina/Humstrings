using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Result : MonoBehaviour {
    private int resultime;
    private Timetest resultcount;
    public Text resulttext;
    public AudioSource Voice1;
    public AudioSource Voice2;
    public AudioSource Voice3;
    public AudioSource Voicelose;
    private bool Voi;


    // Use this for initialization
    void Start () {
        if (Timetest.resultcount >= 120)
        {
            Voi = false;
            Voicelose.Play();
        }
        if (Voi)
        {
            float Voice = Random.Range(0, 2);
            if (Voice == 0)
            {
                Debug.Log("a");
                Voice1.Play();
            }
            else if (Voice == 1)
            {
                Debug.Log("b");
                Voice2.Play();
            }
            else if (Voice == 2)
            {
                Debug.Log("c");
                Voice3.Play();
            }
        }
        

        resulttext = GetComponentInChildren<Text>();
        int M = (int)Timetest.resultcount/60;
        int S = (int)Timetest.resultcount % 60;
        //resulttext.text = Timetest.resultcount.ToString("F0");
        string Mtext, Stext;
        if(M < 10)
        {
            Mtext =  M.ToString();
        }
        else
        {
            Mtext = M.ToString();
        }
        if(S < 10)
        {
            Stext = "0" + S.ToString();
        }
        else
        {
            Stext = S.ToString();
        }

        resulttext.text = Mtext + "分" + Stext + "秒" ;
        
    }
	
	// Update is called once per frame
	void Update () {

    }
}
