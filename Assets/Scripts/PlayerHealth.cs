using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 1000;
    public int currentHealth;

    public Slider healthSlider;   // UI lifeline bar
    public GameObject gameOverUI; // Game over panel
     public GameObject deathcamera;

    void Start()
    {
        currentHealth = maxHealth;
        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;
    }

    // 🔴 This is the function enemy bullet will call
    public void TakeDamage(int damage)
    {
        currentHealth -= (damage/10);
        healthSlider.value = currentHealth;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Time.timeScale = 0f;        // stop game
        gameOverUI.SetActive(true); // show game over screen
        Debug.Log("Player Dead");
        //endgame.SetActive(true);
        deathcamera.SetActive(true);
    }
}