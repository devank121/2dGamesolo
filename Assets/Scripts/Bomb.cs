using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class Bomb : MonoBehaviour, IDamageable
{
    public GameManager gameManager;
    public FoodSpawner foodSpawner;
    private Coroutine bombTimer;
    private UnityAction deathEvent;

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
        deathEvent?.Invoke();
        Destroy(gameObject);
    }

    IEnumerator BombTimer()
    {
        yield return new WaitForSeconds(2f);
        foodSpawner.SpawnCake();
        deathEvent?.Invoke();
        Destroy(gameObject);

    }

    public UnityAction GetDeathEvent()
    {
        return deathEvent;
    }

    public void AddDeathListener(UnityAction listener)
    {
        deathEvent += listener;
    }
}
