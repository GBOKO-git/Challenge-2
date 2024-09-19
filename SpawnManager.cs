using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Variable gameobject pour contenir les animaux
    public GameObject[] animalPrefefabs;
    // modification l'indix du tableau de animalPrefab
    // public int animalIndex;
    // VARIABLE priver pour modifier les valeur de vecteur3
    private float spanRangeX  = 20;
    private float spanPosZ  = 20;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
          
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update() 
    { 
        
            {
               
            }
        
    }

    // CREAT my first fonction
    void SpawnRandomAnimal()
    {
// Deplacer l'indix du tableau de animalPrefab ici
int animalIndex = Random.Range(0, animalPrefefabs.Length);
Instantiate(animalPrefefabs[animalIndex], new Vector3(Random.Range(-spanRangeX, spanRangeX), 0, spanPosZ), animalPrefefabs[animalIndex].transform.rotation);
    }
}
