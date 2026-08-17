using UnityEngine;

public class FoodSpawner : MonoBehaviour
{

    public GameObject cakePrefab;
    public GameManager gameManager;
    public GameObject[] cakePrefabs;
    public GameObject[] negativePrefabs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnCake();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnCake()
    {
        int randomNumber = Random.Range(0, 100);
        Vector3 spawnPosition =
            new Vector3
            (
                Random.Range(-8, 8),
                Random.Range(-4, 4),
                0
            );

        
        if (randomNumber < 80)
        {
            int randomCakeIndex = Random.Range(0, cakePrefabs.Length);
            GameObject selectedCake = cakePrefabs[randomCakeIndex];
            GameObject spawnedObject = Instantiate(selectedCake, spawnPosition, Quaternion.identity);
            Cake newCake = spawnedObject.GetComponent<Cake>();
            newCake.foodSpawner = this;
            newCake.gameManager = gameManager;

        }
        else
        {

        }
        
        
        
    }

    
}
