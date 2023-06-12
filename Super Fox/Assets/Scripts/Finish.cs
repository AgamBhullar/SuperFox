using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    [SerializeField] private Text popUp;

    private bool levelCompleted = false;
    private bool noBoss = true;
    private FinishPublisher finishPublisher;
    //Start is called before the first frame update
    void Start()
    {
        finishPublisher = GetComponent<FinishPublisher>();
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
            FindObjectOfType<SoundManager>().PlaySoundEffect("NextLevelDenied");
            if (this.noBoss)
            {
                popUp.text = "Collect all the items to finish the level!";
            }
            else
            {
                popUp.text = "Collect all the items and defeat the bear to finish the level!";
            }
            popUp.gameObject.SetActive(true);
            StartCoroutine(CloseMessageAfterSeconds(3f));
        }
        else if (collision.gameObject.name == "Player" && levelCompleted)
        {
            FindObjectOfType<SoundManager>().PlaySoundEffect("NextLevel");
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
            this.levelCompleted = true;
        }
        if (bossDead)
        {
            this.noBoss = true;
        }
    }

    IEnumerator CloseMessageAfterSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        popUp.gameObject.SetActive(false);
    }
}
