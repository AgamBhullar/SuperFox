using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int collectables = 0;
    private int initCollectibles;
    private FinishPublisher finishPublisher;
    [SerializeField] private Text cherriesText;

    private void Start()
    {
        finishPublisher = GameObject.FindGameObjectWithTag("Finish").GetComponent<FinishPublisher>();
        initCollectibles = GameObject.FindGameObjectsWithTag("Cherry").Length;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            FindObjectOfType<SoundManager>().PlaySoundEffect("GatheredCherry");
            collectables = initCollectibles - GameObject.FindGameObjectsWithTag("Cherry").Length + 1;
            cherriesText.text = "Collectables: " + collectables;
            finishPublisher.UpdateFinish(false);
        }
    }
}
