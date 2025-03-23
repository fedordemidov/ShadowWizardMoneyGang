using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class EnemyDeath : MonoBehaviour
{
    [SerializeField] private Health enemy;
    [SerializeField] private AnimatorActivator animatorActivator;
    [SerializeField] private Enemy enemyLogic;
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Collider colider;

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
        colider = GetComponent<Collider>();
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
        animatorActivator.DeathAnimation();
        enemyLogic.enabled = false;
        agent.enabled = false;
        colider.enabled = false;
        //Destroy(this.gameObject);
    }
}
