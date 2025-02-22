using System.Collections;
using UnityEngine;

public class HealKit : MonoBehaviour
{
    [SerializeField] private int HealCount;
    [SerializeField] private ParticleSystem particle;
    [SerializeField] private GameObject mesh;

    private void OnTriggerEnter(Collider other)
    {
        if (other != null && other.GetComponent<Health>())
        {
            other.GetComponent<Health>().Heal(HealCount);
            particle.Play();
            mesh.SetActive(false);
            StartCoroutine("DoCheck");
            //Destroy(this.gameObject);
        }
    }

    IEnumerator DoCheck()
    {
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }
}
