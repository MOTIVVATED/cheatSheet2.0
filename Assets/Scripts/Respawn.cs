using System;
using System.Collections;
using UnityEngine;

public class Respawn : MonoBehaviour
{
	IEnumerator RespawnPlayer(Action<string> onComplete)
	{
		Debug.Log("Player died.");
		
		yield return new WaitForSeconds(3f);
		
		Debug.Log("Respawning...");
		
		onComplete("Player is back in the game!");
	}
	void Start()
	{
		StartCoroutine(RespawnPlayer(message => Debug.Log(message)));
	}
}
