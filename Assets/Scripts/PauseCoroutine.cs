using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class PauseCoroutine : MonoBehaviour
{
	private Coroutine myCoroutine;

	private void Start()
	{
		myCoroutine = StartCoroutine(MyInfiniteLoop());
	}
	private void Update()
	{
		if (Keyboard.current.spaceKey.wasPressedThisFrame)
		{
			// PauseCoroutine(myCoroutine);
			// for now I don't know how to pause a coroutine
		}
	}

	IEnumerator MyInfiniteLoop()
	{
		int count = 1;
		while (true)
		{
			Debug.Log(count++);
			yield return new WaitForSeconds(0.5f);
		}
	}
}
