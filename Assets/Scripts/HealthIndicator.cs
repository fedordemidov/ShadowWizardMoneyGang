using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthIndicator : MonoBehaviour
{
    [SerializeField] private Health enemy;
    [SerializeField] private TMP_Text textDisplay;
    [SerializeField] private Image HealthBar;

    private void OnEnable()
    {
        Health.GetDamage += UpdateValue;
    }

    private void OnDisable()
    {
        Health.GetDamage -= UpdateValue;
    }

    private void Start()
    {
        UpdateValue();
    }

    private void UpdateValue()
    {
        textDisplay.text = enemy.GetHealth() + " HP";
        if (HealthBar != null)
        {
            HealthBar.fillAmount = (float)enemy.GetHealth() / (float)enemy.GetMaxHealth();
        }
    }
}
