using UnityEngine;

public class KitSpawn : MonoBehaviour
{
    [SerializeField] private float time = 10;
    public float currentTime;
    [SerializeField] private GameObject HeatKit;
    private GameObject CurrentHeatKit;

    private void Start()
    {
        currentTime = time;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;
        if (CurrentHeatKit != null)
        {
            currentTime = time;
        }

        if (currentTime <= 0)
        {
            CurrentHeatKit = Instantiate(HeatKit, transform.position, Quaternion.identity);
        }
    }
}
