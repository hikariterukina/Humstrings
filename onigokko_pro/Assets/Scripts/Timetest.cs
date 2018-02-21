using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timetest : MonoBehaviour {
    //　トータル制限時間
    private static float totalTime;
    //　制限時間（分）
    public  int minute;
    //　制限時間（秒）
    public float seconds;
    //　前回Update時の秒数
    public static float oldSeconds;
    private Text timerText;
    public static bool timercount;
    public static float resultcount;
    void Start()
    {
        totalTime = minute * 60 + seconds;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<Text>();
        timercount = true;
        
    }

    void Update()
    {
        if (player.Posing == false)
        {
            if (timercount)
            {
                resultcount += Time.deltaTime;
            }
            //　制限時間が0秒以下なら
            if (totalTime <= 0f)
            {
                return;
            }
            //　一旦トータルの制限時間を計測；
            totalTime = minute * 60 + seconds;
            totalTime -= Time.deltaTime;

            //　再設定
            minute = (int)totalTime / 60;
            seconds = totalTime - minute * 60;

            //　タイマー表示用UIテキストに時間を表示する
            if ((int)seconds != (int)oldSeconds)
            {
                timerText.text = minute.ToString("0") + "分" + ((int)seconds).ToString("00") + "秒";
            }
            oldSeconds = seconds;
            //　制限時間たったらシーン移動する
            if (totalTime <= 0f)
            {
                timercount = false;
                Invoke("SceneM", 0.7f);
            }
        }
    }
   
    void SceneM()
    {
        SceneManager.LoadScene("Result");
    }
}
