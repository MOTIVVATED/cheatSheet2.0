using System.Collections;
using UnityEngine;

public class TalkToEachOther : MonoBehaviour
{
	// This is powerful, for sequencing things: cutscenes, totorials, multi-step animations,
	// enemy or npc behaviour patterns.	
	public void Start()
	{
		StartCoroutine(RunIntro());
	}
	IEnumerator RunIntro()
	{
		yield return StartCoroutine(DisplayTitle());
		yield return StartCoroutine(FadeIn());
		Debug.Log("Game Started!");
	}
	IEnumerator DisplayTitle()
	{
		Debug.Log("Title Screen");
		yield return new WaitForSeconds(2f);
	}
	IEnumerator FadeIn()
	{
		Debug.Log("Fading in...");
		yield return new WaitForSeconds(1f);
	}
}
