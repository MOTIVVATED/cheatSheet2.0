using System;
using UnityEngine;

public class MyOwnDelegate : MonoBehaviour
{
	delegate int MathOperation(int a, int b);

	static int Multiply(int a, int b)
	{
		return a * b;
	}

	static int Sum(int a, int b)
	{
		return a + b;
	}

	private void Start()
	{
		MathOperation mathOperation = Multiply;

		ExecuteMathOperation(mathOperation, 5, 10);
	}

	static void ExecuteMathOperation(MathOperation mathOperation, int a, int b)
	{
		Debug.Log("Very important code");

		var operationResult = mathOperation(a, b);

		Debug.Log($"Result: {operationResult}");

		Debug.Log("Super important code");
	}
}
