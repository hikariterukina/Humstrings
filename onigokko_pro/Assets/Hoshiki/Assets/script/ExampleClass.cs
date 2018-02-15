using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class ExampleClass : MonoBehaviour {
	public AudioClip impact;
	AudioSource audio;
    Button btn;
     

    void Start() {
        audio = GetComponent<AudioSource>();
        btn = GetComponent<Button>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        audio.PlayOneShot(impact, 1.0F);
    }
    public void OneClick()
    {
        btn.interactable = false;
    }
    
    
}