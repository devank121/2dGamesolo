using UnityEngine;

public class Cake : MonoBehaviour
{

    GameObject cakePrefab;
    public FoodSpawner foodSpawner;
    public GameManager gameManager;
    public int points;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("the script is running mate");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDown()
    {
        foodSpawner.SpawnCake();
        Debug.Log("you smacked da cake");
        Destroy(gameObject);
        gameManager.AddScore(points);
    }
}
