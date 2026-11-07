using UnityEngine;

public class EnergyOrb : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.CollectOrb();

            Destroy(gameObject);

            Debug.Log("Energy Orb Collected!");
        }
    }
}