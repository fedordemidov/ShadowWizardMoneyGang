using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

 public class Enemy : MonoBehaviour
{
    // Положение точки назначения
    public Transform goal;
    UnityEngine.AI.NavMeshAgent agent;
    [SerializeField] private float agrDistance = 20;
    [SerializeField] private float attackDistance = 1;
    [SerializeField] private int damage = 3;
    [SerializeField] private int couldoun = 1;
    private float currentCouldoun;
    private AnimatorActivator animatorActivator;
    public bool pursuit;

    void Start()
    {
        // Получение компонента агента
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        animatorActivator = GetComponent<AnimatorActivator>();
        // Указаие точки назначения

    }
    void Update()
    {
        float distance = Vector3.Distance(goal.position, transform.position);
        if (distance < agrDistance) 
        {
            agent.destination = goal.position;
            pursuit = true;
            agent.isStopped = false;
        }
        else
        {
            pursuit = false;
            agent.isStopped = true;
        }   
        
        if (distance <= attackDistance) 
        {
            agent.isStopped = true;
            Attack();
        }

        if (currentCouldoun > 0) 
        {
            currentCouldoun -= Time.deltaTime;
        }
    }

    public void Attack()
    {
        Health target = goal.gameObject.GetComponent<Health>();
        float distance = Vector3.Distance(goal.position, transform.position);

        if (distance <= attackDistance && currentCouldoun <= 0)
        {
            animatorActivator.Attack();
            currentCouldoun = couldoun;
            target.Damage(damage);
        }
    }
}