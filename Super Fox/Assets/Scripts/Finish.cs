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
    private Collider2D trigger;
    private SpriteRenderer rend;
    //Start is called before the first frame update
    void Start()
    {
        trigger = GetComponent<Collider2D>();
        rend = GetComponent<SpriteRenderer>();
        finishPublisher = GetComponent<FinishPublisher>();
        trigger.enabled = true;
        rend.enabled = true;
        finishPublisher.InitializeFinish(UpdateFinish);
        if (GameObject.FindGameObjectsWithTag("Boss").Length != 0)
        {
            this.noBoss = false;
        }
        popUp.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !levelCompleted)
        {
            if(GameObject.FindGameObjectsWithTag("Cherry").Length == 0)
            {
                levelCompleted = true;
                Invoke("FinishLevel", 1f);
            }
            else
            {
                //Debug.Log("Player has hit the finish line");
                popUp.text = "Collect all the items to finish the level!";
                popUp.gameObject.SetActive(true);
                StartCoroutine(CloseMessageAfterSeconds(3f)); // close the message after 3 seconds
            }
            
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
