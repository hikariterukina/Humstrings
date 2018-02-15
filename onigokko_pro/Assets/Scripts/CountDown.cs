using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {
    //インスペクターで変更可能にするシステム
    [SerializeField]
    private Text _textCountdown;
    public int textcount = 0;

    void Start()
    {
        StartCoroutine(CountdownCoroutine());
        _textCountdown.text = "";
        
    }

    void Update()
    {
        
        if (textcount == 6)
        {
            Time.timeScale = 1f;
        }
        
    }

    IEnumerator CountdownCoroutine()
    {
        
        _textCountdown.gameObject.SetActive(true);

        _textCountdown.text = "3";
        yield return new WaitForSeconds(1.0f);
        textcount++;
    

        _textCountdown.text = "3";
        yield return new WaitForSeconds(1.0f);
        textcount++;

        _textCountdown.text = "2";
        yield return new WaitForSeconds(1.0f);
        textcount++;

        _textCountdown.text = "1";
        yield return new WaitForSeconds(1.0f);
        textcount++;

        _textCountdown.text = "始め";
        yield return new WaitForSeconds(1.0f);
        textcount++;

        _textCountdown.text = "";
        textcount++;
        if(_textCountdown.)
        _textCountdown.gameObject.SetActive(false);
        
    }

    // Use this for initialization
 
	
	// Update is called once per frame
	/*void Update () {
		
	}*/
}
