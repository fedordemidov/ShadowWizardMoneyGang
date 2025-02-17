using UnityEngine;

public class Gocamera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject player;
    private Vector3 offset = new Vector3(0, 1.67f, -4);

    // Update is called once per frame
    void Update()
    {
        transform.position=player.transform.position+offset;
    }
     void LateUpdate()
    {
        transform.position = player.transform.position + offset;  
    }
}
