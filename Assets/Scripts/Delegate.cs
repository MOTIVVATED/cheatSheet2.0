using UnityEngine;
using System;

public class Delegate : MonoBehaviour
{
	static int Multyply(int a, int b)
	{
		return a * b;
	}

	static int Sum(int a, int b)
	{
		return a + b;
	}

	private void Start()
	{
		Func<int, int, int> mathOperation = Multyply;
		
		ExecuteMathOperation(mathOperation, 5, 10);
	}

	static void ExecuteMathOperation(Func<int, int, int> mathOperation, int a, int b)
	{
		Debug.Log("Very important code");

		var operationResult = mathOperation(a, b);

		Debug.Log($"Result: {operationResult}");

		Debug.Log("Super important code");
	}
}
