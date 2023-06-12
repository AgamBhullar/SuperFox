using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    private StompManager stompManager;

    private void Start()
    {
        this.stompManager = GameObject.FindGameObjectWithTag("Player").GetComponent<StompManager>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("PlayerFoot"))
        {
            stompManager.ExecuteStomp();
            Die();
        }
    }

    public void Die()
    {
        // Destroy the enemy
        Destroy(gameObject);
    }
}
