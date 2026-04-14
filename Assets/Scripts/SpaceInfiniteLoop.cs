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
		while (true)
		{
			Debug.Log("This will print forever until you press the space key.");
			yield return new WaitForSeconds(0.5f);
		}
	}
}
