using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour {
    public GameObject Resume;
    public GameObject TitleGo;
    public GameObject Pause;
    public GameObject Player;
    public GameObject Enemy;
    private Animator PlayerAnim;
    private Animator EnemyAnim;
    public AudioSource Psound;
    public AudioSource Rsound;
    public AudioSource Tsound;
    

	// Use this for initialization
	void Start () {
        Resume.SetActive(false);
        TitleGo.SetActive(false);
        PlayerAnim = Player.GetComponent<Animator>();
        EnemyAnim = Enemy.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Pclick()
    {
        Psound.Play();
        Resume.SetActive(true);
        TitleGo.SetActive(true);
        Pause.SetActive(false);
        player.Posing = true;
    }
    public void ResumeClick()
    {
        Rsound.Play();
        Resume.SetActive(false);
        TitleGo.SetActive(false);
        Pause.SetActive(true);
        player.Posing = false;
    }
    public void TitleGoClick()
    {
        Tsound.Play();
        Invoke("Scene", 0.5f);
    }
    void Scene()
    {
        SceneManager.LoadScene(2);
    }
}
