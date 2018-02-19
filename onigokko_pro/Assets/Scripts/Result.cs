using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Result : MonoBehaviour {
    private int resultime;
    private Timetest resultcount;
    public Text resulttext;


    // Use this for initialization
    void Start () {
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
