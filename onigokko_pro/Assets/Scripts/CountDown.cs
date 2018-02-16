using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    //インスペクターで変更可能にするシステム
    [SerializeField]
    private Text _textCountdown;
    public int textcount = 0;
    public GameObject Player;
    public GameObject Rtime;
    private player P;
    private Timetest TT;


    void Start()
    {
        StartCoroutine(CountdownCoroutine());
        _textCountdown.text = "";
        P = Player.GetComponent<player>();
        TT = Rtime.GetComponent<Timetest>();
        P.enabled = false;
        TT.enabled = false;
    }

    void Update()
    {

    }

    IEnumerator CountdownCoroutine()
    {


        _textCountdown.gameObject.SetActive(true);

        _textCountdown.text = "3";
        yield return new WaitForSeconds(1.0f);


        _textCountdown.text = "3";
        yield return new WaitForSeconds(1.0f);


        _textCountdown.text = "2";
        yield return new WaitForSeconds(1.0f);


        _textCountdown.text = "1";
        yield return new WaitForSeconds(1.0f);


        _textCountdown.text = "始め";
        yield return new WaitForSeconds(1.0f);


        _textCountdown.text = "";

        _textCountdown.gameObject.SetActive(false);
        P.enabled = true;
        TT.enabled = true;

        

        // Use this for initialization


        // Update is called once per frame
        /*void Update () {

        }*/
    }
}
