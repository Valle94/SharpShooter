using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int startHealth = 3;
    [SerializeField] GameObject robotExplosionVFX;
    [SerializeField] GameObject ammoContainer;
    [SerializeField] GameObject[] weapons;
    

    int currentHealth;

    GameManager gameManager;

    void Awake()
    {
        currentHealth = startHealth;
    }

    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        gameManager.AdjustEnemiesLeft(1);
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            gameManager.AdjustEnemiesLeft(-1);
            SelfDestruct();
        }
    }

    public void SelfDestruct()
    {
        Instantiate(robotExplosionVFX, transform.position, Quaternion.identity);
        SpawnPickup();
        Destroy(this.gameObject);
    }

    void SpawnPickup()
    {
        int randNum = Random.Range(0, 10);
        if (0 <= randNum && randNum <= 2)
        {
            Instantiate(ammoContainer, transform.position, Quaternion.identity);
        }
        else if (randNum == 9)
        {
            randNum = Random.Range(0, 3);
            Instantiate(weapons[randNum], transform.position, Quaternion.identity);
        }
    }
}
