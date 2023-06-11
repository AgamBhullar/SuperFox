using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("PlayerFoot"))
        {
            Die();
        }
    }

    public void Die()
    {
        // Destroy the enemy
        Destroy(gameObject);
    }
}
