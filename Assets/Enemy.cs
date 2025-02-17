using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    public Transform Player;
    public float ChaseSpeed;

    public float MaxDist;
    public float MinDist;
    public bool Flee = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {

        float distance = Vector3.Distance(transform.position, Player.position);
        if (distance > MaxDist) return;
        if (distance <MinDist )return;
        
        transform.LookAt(Player);
        //if (!Flee) {transform.position=Vector3.MoveTowards(transform.position,Player.position,ChaseSpeed*Time.deltaTime); }
        transform.position = Vector3.MoveTowards(transform.position, Player.position, ChaseSpeed * Time.deltaTime);




    }

}


    