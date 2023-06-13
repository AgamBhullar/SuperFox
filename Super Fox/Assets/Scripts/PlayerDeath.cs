using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private Animator anim;
    private SoundManager soundManager;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        soundManager = FindObjectOfType<SoundManager>();
        
        if(rb2D == null)
        {
            Debug.LogError("No Rigidbody2D component found on the player object.");
        }
        
        if(anim == null)
        {
            Debug.LogError("No Animator component found on the player object.");
        }

        if(soundManager == null)
        {
            Debug.LogError("No SoundManager found in the scene.");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap") || collision.gameObject.CompareTag("Enemy"))
        {
            Die();
        }
    }

    private void Update()
    {
        if(rb2D != null && rb2D.velocity.y < -35f)
        {
            Die();
        }
    }

    public void Die()
    {
        if(rb2D != null)
        {
            rb2D.bodyType = RigidbodyType2D.Static;
        }

        if(soundManager != null)
        {
            soundManager.PlaySoundEffect("Dead");
        }
        
        if(anim != null)
        {
            anim.SetTrigger("death");
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
