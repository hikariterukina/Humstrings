using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour {
    public float time;
	// Use this for initialization
	void Start () {
     
		
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        GetComponent<Text>().text = time.ToString("F");

        if (time < 0)
        {
            enabled = false;
        }
	}
}
