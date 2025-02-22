using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyDeath : MonoBehaviour
{
    [SerializeField] private Health enemy;

    private void OnEnable()
    {
        Health.GetDamage += GetDamage;
    }

    private void OnDisable()
    {
        Health.GetDamage -= GetDamage;
    }

    void Start()
    {
        enemy = GetComponent<Health>();
    }

    private void GetDamage()
    {
        if (enemy.GetHealth() == 0)
        {
            Death();   
        }
    }

    private void Death()
    {
        Destroy(this.gameObject);
    }
}
