using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    public GameObject energyOrbPrefab;
    public Transform[] spawnPoints;

    void Start()
    {
        StartCoroutine(SpawnOrbs());
    }

    IEnumerator SpawnOrbs()
    {
        foreach (Transform spawn in spawnPoints)
        {
            Instantiate(energyOrbPrefab, spawn.position, spawn.rotation);

            yield return new WaitForSeconds(2f);
        }
    }
}