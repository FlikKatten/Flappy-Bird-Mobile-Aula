using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{
    public GameObject collectable;
    public float initalX;
    public float minY, maxY;
    public float minSpawnTime, maxSpawnTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    public IEnumerator Spawn()
    {
        var randomTime = Random.Range(minSpawnTime, maxSpawnTime);

        yield return new WaitForSeconds(randomTime);

        Vector2 spawnPosition = new Vector2(initalX, Random.Range(minY, maxY));

        Instantiate(collectable, spawnPosition, Quaternion.identity);

        StartCoroutine(Spawn());
    }
}
