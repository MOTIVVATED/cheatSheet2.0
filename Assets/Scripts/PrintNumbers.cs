using System.Collections;
using UnityEngine;

public class PrintNumbers : MonoBehaviour
{
	private void Start()
	{
		StartCoroutine(PrintLoop(10, 0.5f));
	}
	IEnumerator Print()
	{
		Debug.Log("1");
		yield return new WaitForSeconds(1f);
		Debug.Log("2");
		yield return new WaitForSeconds(1f);
		Debug.Log("3");
		yield return new WaitForSeconds(1f);
		Debug.Log("4");
		yield return new WaitForSeconds(1f);
		Debug.Log("5");
	}
	IEnumerator PrintLoop(int upTo, float delay)
	{ 
		for (int i = 1; i <= upTo; i++)
		{
			Debug.Log(i);
			yield return new WaitForSeconds(delay);
		}
	}
}
