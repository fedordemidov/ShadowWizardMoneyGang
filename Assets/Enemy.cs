using UnityEngine;
using UnityEngine.AI;

 public class Enemy : MonoBehaviour
{
    // ��������� ����� ����������
    public Transform goal;
    UnityEngine.AI.NavMeshAgent agent;
    void Start()
    {
        // ��������� ���������� ������
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        // ������� ����� ����������

    }
    void Update()
    {
        agent.destination = goal.position;

    }
}