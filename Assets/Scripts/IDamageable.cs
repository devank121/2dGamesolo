using UnityEngine;
using UnityEngine.Events;

public interface IDamageable
{
    UnityAction GetDeathEvent();
}