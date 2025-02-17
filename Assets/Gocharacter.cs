using UnityEngine;

public class Gocharacter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 2.5f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey("w"))
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        transform.position = pos;
    }
}
