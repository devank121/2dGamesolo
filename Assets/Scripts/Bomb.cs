using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour
{
    public GameManager gameManager;
    public FoodSpawner foodSpawner;
    private Coroutine bombTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bombTimer = StartCoroutine(BombTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        gameManager.LoseHeart();
        foodSpawner.SpawnCake();
        StopCoroutine(bombTimer);
        Destroy(gameObject);
    }

    IEnumerator BombTimer()
    {
        yield return new WaitForSeconds(2f);
        foodSpawner.SpawnCake();
        Destroy(gameObject);

    }
}
