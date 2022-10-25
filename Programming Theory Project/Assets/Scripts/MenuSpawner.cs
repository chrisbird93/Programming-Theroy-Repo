using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSpawner : MonoBehaviour
{
    [SerializeField]
    float waitTime;

    [SerializeField] 
    public GameObject[] objects;

    float minX, maxX;

    private void Start()
    {
        minX = -10f;
        maxX = 10f;
        StartCoroutine("Spawn");
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            float xSpawn = Random.Range(minX, maxX);
            Vector3 spawnPos = new Vector3(xSpawn, transform.position.y, transform.position.z);

            int objectToSpawnIndex = Random.Range(0, objects.Length);

            Instantiate(objects[objectToSpawnIndex], spawnPos, Random.rotation);

            yield return new WaitForSeconds(waitTime);
        }
    }
}
