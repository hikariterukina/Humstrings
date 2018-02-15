using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;



public class scenetest : MonoBehaviour {
	public float scenespeed = 2.0f;

	public void SelectStage()
	{
		Invoke ("stageselect", scenespeed);
	}
	public void SelectStage1()
	{
		Invoke ("stageselect2", scenespeed);
	}

	public void SelectStage2()
	{
		Invoke ("stageselect3", scenespeed);
	}

	public void SelectStage3()
	{
		Invoke ("stageselect4", scenespeed);
	}

	public void SelectStage4()
	{
		Invoke ("stageselect5", scenespeed);
	}

	public void SelectStage5()
	{
		Invoke ("stageselect6", scenespeed);
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