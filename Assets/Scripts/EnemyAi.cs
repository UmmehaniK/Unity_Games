using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public Transform player;        // player target
    public float speed = 3f;        // movement speed
    public float stopDistance = 8f; // distance to stop & shoot
    public float health = 100f;

    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 1f;

    float nextFireTime;

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(transform.position, player.position);

        // Look at player
        transform.LookAt(player);

        // Move towards player
        if (distance > stopDistance)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + 1f / fireRate;

            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }

    // Enemy takes damage
    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log($"Health : {health}");
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log($"Enemy die");
        EnemyCount.Instance.EnemyDie();
        Destroy(gameObject);
    }
}