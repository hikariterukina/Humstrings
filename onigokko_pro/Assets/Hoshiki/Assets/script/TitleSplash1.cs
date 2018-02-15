using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleSplash1 : MonoBehaviour {
	bool  isMySplashShowing = false;
	float startTime = 0.0f;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (Application.isShowingSplashScreen == false) {
			if (!isMySplashShowing) {
				startTime = Time.time;
				isMySplashShowing = true;
			} else {
				// 広告などの処理.
				float now = Time.time;
				float elapsedTime = now - startTime;
				if (elapsedTime > 2.0f) {
					SceneManager.LoadScene("scenetest_2D");
				}
			}
		}
	}
}
