using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    List<Transform> spawnPoints = new List<Transform>();
    public GameObject obsPrefab;

    void Start()
    {
        spawnPoints.Clear();
        foreach (Transform child in transform)
        {
            if (child.name[child.name.Length-1].ToString() == "O")
            {
                spawnPoints.Add(child.transform);
            }
        }
        //Debug.Log("Found " + spawnPoints.Count.ToString());

        int ran = Random.Range(0, spawnPoints.Count);

        SpawnAtPos(ran);

    }
    
    private void SpawnAtPos(int pos)
    {
        var spawned = Object.Instantiate(obsPrefab, spawnPoints[pos].position, obsPrefab.transform.rotation);
    }
}
