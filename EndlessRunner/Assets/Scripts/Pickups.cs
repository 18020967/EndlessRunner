using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
	List<Transform> spawnPoints = new List<Transform>();
	public GameObject pickupPrefab;

	void Start()
	{
		spawnPoints.Clear();
		foreach (Transform child in transform)
		{
			if (child.name[child.name.Length - 1].ToString() == "P")
			{
				spawnPoints.Add(child.transform);
			}
		}
		

		int ran = Random.Range(0, spawnPoints.Count);

		SpawnAtPos(ran);

	}

	private void SpawnAtPos(int pos)
	{
		var spawned = Object.Instantiate(pickupPrefab, spawnPoints[pos].position, pickupPrefab.transform.rotation);
	}
}
