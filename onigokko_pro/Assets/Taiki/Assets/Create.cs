using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour {

	//Prefabを入れる変数
	public GameObject sphere;
	//時間を入れる変数
	private float time = 0;
	//何秒ごとにSphereを出すか
	public float limit = 0.2f;

	void Start () {

	}

	void Update () {
		//時間が経つことに数値が増える
		time += Time.deltaTime;

		//一定時間が経ったら発動
		if(time >= limit)
		{
			//Prefabを生成する
			Instantiate(sphere);
			//数値を0に戻して一から時間を計り直す
			time = 0;
		}

	}
}