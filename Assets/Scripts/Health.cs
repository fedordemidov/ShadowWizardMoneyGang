using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private uint health = 100;
    [SerializeField] private uint maxHealth = 100;

    public void Damage(uint damagePoint)
    {
        health -= damagePoint;
        if (damagePoint >= health)
        {
            health = 0;
        }
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
    public void Heal(uint healPoint)
    {
        if (health + healPoint <= maxHealth)
        {
            health += healPoint;
        }
    }

    public uint GetHealth()
    {
        return health;
    }

    public uint GetMaxHealth()
    {
        return maxHealth;
    }
    
}
