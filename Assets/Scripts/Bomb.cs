using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour
{
    public GameManager gameManager;
    public FoodSpawner foodSpawner; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(BombTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        gameManager.LoseHeart();
    }

    IEnumerator BombTimer()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
