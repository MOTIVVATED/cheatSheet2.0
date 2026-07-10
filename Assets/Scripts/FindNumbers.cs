using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class FindNumbers : MonoBehaviour
{
	private void Start()
	{
		var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

		var result = numbers.Where(number => number % 2 == 0);

		foreach (var number in result)
		{
			Debug.Log(number);
		}
	}
}
