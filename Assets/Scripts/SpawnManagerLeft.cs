using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerLeft : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeZ = 10f;
    private float spawnPosX = -20f;

    private float centerZ = 10f;

    private float startDelay = 2f;
    private float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, centerZ+Random.Range(-spawnRangeZ,spawnRangeZ));

        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.AngleAxis(90,Vector3.up));
    }
}
