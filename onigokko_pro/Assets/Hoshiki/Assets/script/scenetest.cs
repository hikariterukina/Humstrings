using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;



public class scenetest : MonoBehaviour {
	public float scenespeed = 2.0f;
    private AudioSource Shouji_Close;
    bool OneSound;
    public AudioSource SB;

    private void Start()
    {
        OneSound = true;
    }
    public void SelectStage()
	{
        SB.Play();
		Invoke ("stageselect", scenespeed);
	}
	public void SelectStage1()
	{
        SB.Play();
        Invoke ("stageselect2", scenespeed);
	}

	public void SelectStage2()
	{
        SB.Play();
        Invoke ("stageselect3", scenespeed);
	}

	public void SelectStage3()
	{
        SB.Play();
        Invoke ("stageselect4", scenespeed);
	}

	public void SelectStage4()
	{
        SB.Play();
        Invoke ("stageselect5", scenespeed);
	}

	public void SelectStage5()
	{
        SB.Play();
        Invoke ("stageselect6", scenespeed);
	}
    public void Shoji()
    {
        if (OneSound)
        {
            Shouji_Close = GetComponent<AudioSource>();
            Shouji_Close.Play();
            OneSound = false;
        }
    }

	void stageselect(){
		SceneManager.LoadScene ("Story");
	}

	void stageselect2(){
		SceneManager.LoadScene ("Main1");
	}

	void stageselect3(){
		SceneManager.LoadScene ("Main2");
	}

	void stageselect4(){
		SceneManager.LoadScene ("Main3");
	}

	void stageselect5(){
		SceneManager.LoadScene ("StageSelect");
	}

	void stageselect6(){
		SceneManager.LoadScene ("Description");
	}

}