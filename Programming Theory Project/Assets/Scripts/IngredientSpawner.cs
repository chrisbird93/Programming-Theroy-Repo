using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientSpawner : MonoBehaviour
{
    public GameObject bread;
    public GameObject tomato;
    public GameObject lettuce;
    public GameObject ham;
    public GameObject cheese;
    public GameObject gherkin;

    float xMin, xMax, yMin, yMax, zMin, zMax, offset;

    private void Start()
    {
        offset = 0.4f;
        xMin = transform.position.x - offset;
        xMax = transform.position.x + offset;
        yMin = transform.position.y - offset;
        yMax = transform.position.y + offset;
        zMin = transform.position.z - offset;
        zMax = transform.position.z + offset;
    }

    public void SpawnBread()
    {
        SpawnFood(bread);
    }
    public void SpawnTomato()
    {
        offset = 0.9f;
        xMin = transform.position.x - offset;
        xMax = transform.position.x + offset;
        yMin = transform.position.y - offset;
        yMax = transform.position.y + offset;
        zMin = transform.position.z - offset;
        zMax = transform.position.z + offset;

        SpawnFood(tomato);

        offset = 0.4f;
        xMin = transform.position.x - offset;
        xMax = transform.position.x + offset;
        yMin = transform.position.y - offset;
        yMax = transform.position.y + offset;
        zMin = transform.position.z - offset;
        zMax = transform.position.z + offset;
    }
    public void SpawnLettuce()
    {
        SpawnFood(lettuce);
    }
    public void SpawnHam()
    {
        SpawnFood(ham);
    }
    public void SpawnCheese()
    {
        SpawnFood(cheese);
    }
    public void SpawnGherkin()
    {
        offset = 1f;
        xMin = transform.position.x - offset;
        xMax = transform.position.x + offset;
        yMin = transform.position.y - offset;
        yMax = transform.position.y + offset;
        zMin = transform.position.z - offset;
        zMax = transform.position.z + offset;

        SpawnFood(gherkin);

        offset = 0.4f;
        xMin = transform.position.x - offset;
        xMax = transform.position.x + offset;
        yMin = transform.position.y - offset;
        yMax = transform.position.y + offset;
        zMin = transform.position.z - offset;
        zMax = transform.position.z + offset;
    }

    void SpawnFood(GameObject foodToSpawn)
    {
        float spawnXPosition = Random.Range(xMin, xMax);
        float spawnYPosition = Random.Range(yMin, yMax);
        float spawnZPosition = Random.Range(zMin, zMax);

        Vector3 spawnPosition = new Vector3(spawnXPosition, spawnYPosition, spawnZPosition);

        Instantiate(foodToSpawn, spawnPosition, Quaternion.identity);
    }
}
