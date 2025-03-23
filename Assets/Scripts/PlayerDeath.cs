using System.Net.Sockets;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private Health health;
    private FirstPersonController firstPersonController;
    [SerializeField] private GameObject LoseScreen;
    [SerializeField] private GameObject HealthScreen;
    [SerializeField] private GameObject RocketLauncher;
    

    private void OnEnable()
    {
        Health.GetDamage += isLive;
    }

    private void OnDisable()
    {
        Health.GetDamage -= isLive;
    }

    void Start()
    {
        health = GetComponent<Health>();
        firstPersonController = GetComponent<FirstPersonController>();
    }

    private void isLive()
    {
        if (health != null)
        {
            if (health.GetHealth() <= 0)
            {
                Death();
            }
        }
    }

    private void Death()
    {
        firstPersonController.enabled = false;
        if (LoseScreen != null) LoseScreen.SetActive(true);
        if (HealthScreen != null) HealthScreen.SetActive(false);
        if (RocketLauncher != null) RocketLauncher.SetActive(false);
        Cursor.lockState = CursorLockMode.Confined;
    }
}
