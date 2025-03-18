using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    [field: SerializeField]
    private int health = 3;

    [SerializeField]
    private TMP_Text healthText; // Reference til UI-tekstkomponenten

    void Start()
    {
        // Initialize health or other stats if needed
        UpdateHealthUI();
    }

    void Update()
    {
        // Check if player is dead
        if (health <= 0)
        {
            Die();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hp")
        {
            health += 1;
            collision.gameObject.SetActive(false); // Deaktiverer HpUp-objektet
            UpdateHealthUI();
        }
        else if (collision.gameObject.tag == "Enemy1")
        {
            health -= 1;
            UpdateHealthUI();
        }
    }

    private void Die()
    {
        // Handle player death (e.g., disable player, show game over screen)
        gameObject.SetActive(false);
        Debug.Log("Player has died");
    }

    private void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + health;
        }
    }
}