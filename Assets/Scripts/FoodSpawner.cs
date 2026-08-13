using UnityEngine;

public class FoodSpawner : MonoBehaviour
{

    public GameObject cakePrefab;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnCake();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCake()
    {
        Vector3 spawnPosition =
            new Vector3
            (
                Random.Range(-8, 8),
                Random.Range(-4, 4),
                0
            );

        
        Cake newCake = Instantiate(cakePrefab, spawnPosition, Quaternion.identity).GetComponent<Cake>();
        newCake.foodSpawner = this;
    }

    
}
