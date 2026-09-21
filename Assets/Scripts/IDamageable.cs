using UnityEngine;
using UnityEngine.Events;

public interface IDamageable
{
    UnityAction GetDeathEvent();
    void AddDeathListener(UnityAction listener);
}