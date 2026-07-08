using System;
using System.Collections;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
	private class Wave
	{
		public int waveNumber;
		public int enemyCount;
		public float timeBetweenEnemies;
		public Wave(int waveNumber, int enemyCount, float timeBetweenEnemies)
		{
			this.waveNumber = waveNumber;
			this.enemyCount = enemyCount;
			this.timeBetweenEnemies = timeBetweenEnemies;
		}
	}

	private static Wave Wave1 = new Wave(1, 3, 1f);
	private static Wave Wave2 = new Wave(2, 5, 0.75f);
	private static Wave Wave3 = new Wave(3, 8, 0.5f);

	private static Wave[] waves = { Wave1, Wave2, Wave3 };

	private void Start()
	{
		StartCoroutine(RunWaves(waves));
	}
	IEnumerator SpawnWave(Wave wave, Action OnComplete)
	{
			Debug.Log("Wave " + wave.waveNumber + " starting!");

			for (int i = 0; i < wave.enemyCount; i++)
			{
				Debug.Log("Spawning enemy " + (i + 1));
				yield return new WaitForSeconds(wave.timeBetweenEnemies);
			}

			OnComplete?.Invoke();
	}

	IEnumerator RunWaves(Wave[] waves)
	{
		for (int i = 0; i < waves.Length; i++)
		{
			int capturedNumber = waves[i].waveNumber; // Capture the wave number for the closure

			yield return StartCoroutine(SpawnWave(waves[i], () => Debug.Log("Wave " + capturedNumber + " completed!")));

			yield return new WaitForSeconds(5f);
		}
	}
}