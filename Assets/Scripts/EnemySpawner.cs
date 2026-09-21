using UnityEngine;
using UnityEngine.Events;
public class EnemySpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject spawnedEnemy;
    private int spawnedCount = 0;
    private int deadCount = 0;
    public FoodSpawner foodSpawner;

    public int totalEnemies = 20;
    public int maxEnemiesAlive = 5;
    public float bossTime = 20f;

    private bool bossActive = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnemyDead()
    {
        deadCount += 1;
    }

    void SpawnEnemy()
    {
        GameObject spawnedObject = Instantiate(spawnedEnemy, transform.position, Quaternion.identity);
        spawnedCount += 1;
        IDamageable damageable = spawnedObject.GetComponent<IDamageable>();
        damageable.AddDeathListener(OnEnemyDead);
    }

}
