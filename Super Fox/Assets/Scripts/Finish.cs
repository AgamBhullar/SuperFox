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
            levelCompleted = true;
            Invoke("FinishLevel", 1f);
        }
    }

    private void FinishLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
