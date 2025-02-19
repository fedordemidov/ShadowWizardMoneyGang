using UnityEngine;
using UnityEngine.AI;

 public class Enemy : MonoBehaviour
{
    // Положение точки назначения
    public Transform goal;
    UnityEngine.AI.NavMeshAgent agent;
    void Start()
    {
        // Получение компонента агента
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        // Указаие точки назначения

    }
    void Update()
    {
        agent.destination = goal.position;

    }
}