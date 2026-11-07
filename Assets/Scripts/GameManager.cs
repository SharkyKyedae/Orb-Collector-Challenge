using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int totalOrbs = 5;
    private int collectedOrbs = 0;

    public GameObject portalPrefab;
    public Transform portalSpawnPoint;

    void Awake()
    {
        instance = this;
    }

    public void CollectOrb()
    {
        collectedOrbs++;

        Debug.Log("Orbs Collected: " + collectedOrbs);

        if (collectedOrbs >= totalOrbs)
        {
            SpawnPortal();
        }
    }

    void SpawnPortal()
    {
        Instantiate(portalPrefab, portalSpawnPoint.position, portalSpawnPoint.rotation);
        Debug.Log("All orbs collected! Portal appeared!");
    }
}