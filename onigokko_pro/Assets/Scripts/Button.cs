using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour {
    internal bool interactable;
    public AudioSource Ts;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClick()
    {
        Ts.Play();
        Invoke("Scene", 0.5f);
    }
    void Scene()
    {

        SceneManager.LoadScene("Title");
    }
}
