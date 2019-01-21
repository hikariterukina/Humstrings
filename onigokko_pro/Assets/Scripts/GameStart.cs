using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour {
    //public GameObject L_door;
    //public GameObject R_door;

    public void PushStartButton()
    {
        Invoke("SceneMove", 1);
    }

    void SceneMove()
    {
        SceneManager.LoadScene(1);
    }

    public void PushGoButton()
    {
        Invoke("fackyou", 1);
    }

    void fackyou()
    {
        SceneManager.LoadScene(2);
    }
    public void Stage1Button()
    {
        Invoke("Inu", 1);
    }
    void Inu()
    {
        SceneManager.LoadScene(4);
    }
    public void Stage2Button()
    {
        Invoke("Saru", 1);
    }
    void Saru()
    {
        SceneManager.LoadScene(5);
    }
    public void Description()
    {
        Invoke("Hika", 1);
    }
    void Hika()
    {
        SceneManager.LoadScene(3);
    }
    public void TitleButton()
    {
        Invoke("Yamato", 1);
    }
    void Yamato()
    {
        SceneManager.LoadScene(0);
    }
}
