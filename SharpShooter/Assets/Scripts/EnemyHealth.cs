using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int startHealth = 3;
    [SerializeField] GameObject robotExplosionVFX;

    int currentHealth;

    void Awake()
    {
        currentHealth = startHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            Instantiate(robotExplosionVFX, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
