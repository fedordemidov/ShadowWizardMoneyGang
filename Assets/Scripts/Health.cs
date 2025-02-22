using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public static event Action GetDamage;
    [SerializeField] private int health = 100;
    [SerializeField] private int maxHealth = 100;

    public void Damage(int damagePoint)
    {
        health -= damagePoint;
        GetDamage?.Invoke();
    }
    public void Heal(int healPoint)
    {
        if (health + healPoint <= maxHealth)
        {
            health += healPoint;
            GetDamage?.Invoke();
        }
    }

    public int GetHealth()
    {
        return health;
    }

    public int GetMaxHealth()
    {
        return maxHealth;
    }
    
}
