using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;
public class SpaceInfiniteLoop : MonoBehaviour
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
			StopCoroutine(myCoroutine);
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
