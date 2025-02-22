using UnityEngine;

public class ExplosionPush : MonoBehaviour
{
    [SerializeField] float radius = 5.0F;
    [SerializeField] float explosionStrength = 10.0F;

    void Awake()
    {
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(explosionStrength, explosionPos, radius, 3.0F);
        }
    }
}
