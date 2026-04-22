using System;
using System.Collections;
using UnityEngine;

public class Respawn : MonoBehaviour
{
	IEnumerator RespawnPlayer(Action onComplete)
	{
		Debug.Log("Player died.");
		
		yield return new WaitForSeconds(3f);
		
		Debug.Log("Respawning...");
		
		onComplete();
	}
	void Start()
	{
		StartCoroutine(RespawnPlayer(() => Debug.Log("Player is back in the game!")));
	}
}
