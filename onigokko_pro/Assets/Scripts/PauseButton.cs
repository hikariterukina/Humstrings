using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour {
    public GameObject Resume;
    public GameObject TitleGo;
    public GameObject Pause;

	// Use this for initialization
	void Start () {
        Resume.SetActive(false);
        TitleGo.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Pclick()
    {
        Time.timeScale = 0;
        Resume.SetActive(true);
        TitleGo.SetActive(true);
        Pause.SetActive(false);
    }
    public void ResumeClick()
    {
        Time.timeScale = 1;
        Resume.SetActive(false);
        TitleGo.SetActive(false);
        Pause.SetActive(true);
    }
    public void TitleGoClick()
    {
        SceneManager.LoadScene("Title");
    }
}
