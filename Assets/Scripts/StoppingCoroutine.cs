using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
public class StoppingCoroutine : MonoBehaviour
{
	private Coroutine myCoroutine;

	private void Start()
	{
		myCoroutine = StartCoroutine(PrintLoop(10, 0.5f));
	}
	private void Update()
	{
		if (Keyboard.current.spaceKey.wasPressedThisFrame)
		{
			StopCoroutine(myCoroutine);
		}
	}
	IEnumerator PrintLoop(int upTo, float delay)
	{
		for (int i = 0; i <= upTo; i++)
		{
			Debug.Log(i);
			yield return new WaitForSeconds(delay);
		}
	}
}

