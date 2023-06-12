using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private bool levelCompleted = false;
    private bool noBoss = true;
    private FinishPublisher finishPublisher;
    private Collider2D trigger;
    private SpriteRenderer rend;
    //Start is called before the first frame update
    void Start()
    {
        trigger = GetComponent<Collider2D>();
        rend = GetComponent<SpriteRenderer>();
        finishPublisher = GetComponent<FinishPublisher>();
        trigger.enabled = false;
        rend.enabled = false;
        finishPublisher.InitializeFinish(UpdateFinish);
        if (GameObject.FindGameObjectsWithTag("Boss").Length != 0)
        {
            this.noBoss = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            FindObjectOfType<SoundManager>().PlaySoundEffect("NextLevel");
            levelCompleted = true;
            Invoke("FinishLevel", 1f);
        }
    }

    private void FinishLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        if (String.Equals(FindObjectOfType<SoundManager>().GetMusicName(), "Level1"))
        {
            FindObjectOfType<SoundManager>().PlayMusicTrack("Level2");
        }
        else if (String.Equals(FindObjectOfType<SoundManager>().GetMusicName(), "Level2"))
        {
            FindObjectOfType<SoundManager>().PlayMusicTrack("Level3");
        }
        else if (String.Equals(FindObjectOfType<SoundManager>().GetMusicName(), "Level3"))
        {
            FindObjectOfType<SoundManager>().PlayMusicTrack("Finish");
        }
    }

    public void UpdateFinish(bool bossDead)
    {
        if ((bossDead && GameObject.FindGameObjectsWithTag("Cherry").Length == 0) 
        || (this.noBoss && GameObject.FindGameObjectsWithTag("Cherry").Length <= 1))
        {
            trigger.enabled = true;
            rend.enabled = true;
        }
        if (bossDead)
        {
            this.noBoss = true;
        }
    }
}
