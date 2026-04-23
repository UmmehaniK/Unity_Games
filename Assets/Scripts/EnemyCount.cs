using UnityEngine;
using TMPro;

public class EnemyCount : MonoBehaviour
{
    public static EnemyCount Instance;
    public int enemyCount = 10;
    public EnemyAi enemy;
    public GameObject gameOverUI; // Game over panel
    public GameObject deathcamera;
    public TextMeshProUGUI count;

    void Awake()
    {
        Instance = this;
    }

    public void Update()
    {
        if(enemyCount<=0)
        {
            gameOverUI.SetActive(true); // show game over screen
            deathcamera.SetActive(true);
        }
    }
    public void EnemyDie()
    {
        enemyCount--;
        UpdateUI();
    }

    void UpdateUI()
    {
        count.text = enemyCount.ToString();
    }
}
