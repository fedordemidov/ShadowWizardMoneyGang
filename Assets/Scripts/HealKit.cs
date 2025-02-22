using UnityEngine;

public class HealKit : MonoBehaviour
{
    [SerializeField] private int HealCount;
    [SerializeField] private ParticleSystem particle;

    private void OnTriggerEnter(Collider other)
    {
        if (other != null && other.GetComponent<Health>())
        {
            other.GetComponent<Health>().Heal(HealCount);
            particle.Play();
            Destroy(this.gameObject);
        }
    }
}
