using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth;

    public void UpdateHealth(int damageAmount)
    {
        currentHealth = Mathf.Clamp(currentHealth -= damageAmount, 0, maxHealth);
    }
}
