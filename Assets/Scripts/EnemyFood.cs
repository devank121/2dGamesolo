using UnityEngine;
using UnityEngine.Events;

public class EnemyFood : MonoBehaviour, IDamageable
{
    private UnityAction deathEvent;

    public void OnMouseDown()
    {
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