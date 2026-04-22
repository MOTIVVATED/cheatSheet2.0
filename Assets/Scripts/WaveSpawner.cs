using System.Collections;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
	[SerializeField] private int waveNumber = 3;
	[SerializeField] private int enemyCount = 3;
	[SerializeField] private float timeBetweenEnemies = 0.5f;
	[SerializeField] private float timeBetweenWaves = 5f;

	private void Start()
	{
		StartCoroutine(RunWaves());
	}
	IEnumerator SpawnWave(int waveNumber, int enemyCount, float timeBetweenEnemies)
	{
		yield return new WaitForSeconds(timeBetweenEnemies);
	}
	IEnumerator RunWaves()
	{
		SpawnWave(waveNumber, enemyCount, timeBetweenEnemies);
		yield return new WaitForSeconds(timeBetweenWaves);
	}
}
