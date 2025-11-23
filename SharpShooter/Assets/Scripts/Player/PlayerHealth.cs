using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int startHealth = 5;

    int currentHealth;

    void Awake()
    {
        currentHealth = startHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        Debug.Log($"Current Health: {currentHealth}");

        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
