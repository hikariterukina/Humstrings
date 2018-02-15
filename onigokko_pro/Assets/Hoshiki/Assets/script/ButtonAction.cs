using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class ButtonAction : MonoBehaviour 
{
	[SerializeField]
	Animator animator;

	static readonly int hashStatesyouji_close = Animator.StringToHash("syouji_close_1");

	// button event
	public void OnOK()
	{
		animator.Play (hashStatesyouji_close);
	}


}