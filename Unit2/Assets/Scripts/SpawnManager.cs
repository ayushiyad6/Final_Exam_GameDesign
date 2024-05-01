using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[ ] animalPrefabs; 
    public int animalIndex;
    public int SpawnRange = 10;
    public Vector3 spawnpos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input. GetKeyDown (KeyCode. S)) {
        // Randomly generate animal index and spawn position
        SpawnRandomAnimal(); 
    }
    }
    void SpawnRandomAnimal() 
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        spawnpos = new Vector3(Random.Range(-SpawnRange, SpawnRange), 0, 0);
        Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20), spawnpos, animalPrefabs[animalIndex].transform.rotation);
    }
                    
}
