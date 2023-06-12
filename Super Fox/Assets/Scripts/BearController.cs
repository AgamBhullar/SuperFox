using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BearController : MonoBehaviour
{
    public GameObject waypoint1;
    public GameObject waypoint2;
    private Rigidbody2D rb2D;
    private Collider2D[] colliders;
    private Animator anim;
    private Transform currentPoint;
    private SpriteRenderer rend;
    private StompManager stompManager;
    private FinishPublisher finishPublisher;
    public float speed;
    private int hitCounter = 0;
    private bool hitState = false;
    private Vector2 oldVelocity;
    [SerializeField] private float hitDelay;
    private float currentDelay;
    private float flashDelay;
    private float currentFlash;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
        colliders = GetComponents<Collider2D>();
        this.stompManager = GameObject.FindGameObjectWithTag("Player").GetComponent<StompManager>();
        this.finishPublisher = GameObject.FindGameObjectWithTag("Finish").GetComponent<FinishPublisher>();
        currentPoint = waypoint1.transform;
        this.flashDelay = this.hitDelay/8;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (this.hitState)
        {
            rb2D.velocity = new Vector2(0, 0);
            this.currentDelay += Time.deltaTime;
            this.currentFlash += Time.deltaTime;

            if (this.currentFlash >= this.flashDelay)
            {
                rend.enabled = !rend.enabled;
                this.currentFlash = 0;
            }

            if (this.currentDelay >= this.hitDelay)
            {
                this.hitState = false;
                rend.enabled = true;
                anim.enabled = true;
                rb2D.velocity = this.oldVelocity;
                foreach (Collider2D bearCollider in this.colliders)
                {
                    bearCollider.enabled = true;
                }
            }

            return;
        }
        if (currentPoint == waypoint1.transform)
        {
            rb2D.velocity = new Vector2(-speed, 0);
        }
        else
        {
            rb2D.velocity = new Vector2(speed, 0);
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == waypoint1.transform)
        {
            flip();
            currentPoint = waypoint2.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == waypoint2.transform)
        {
            flip();
            currentPoint = waypoint1.transform;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("PlayerFoot"))
        {
            stompManager.ExecuteStomp();
            if (this.hitCounter == 2)
            {
                Die();
            }
            else
            {
                this.hitCounter++;
                this.hitState = true;
                this.currentDelay = 0;
                this.currentFlash = 0;
                this.oldVelocity = rb2D.velocity;
                rb2D.velocity = new Vector2(0, 0);
                anim.enabled = false;
                foreach (Collider2D bearCollider in this.colliders)
                {
                    bearCollider.enabled = false;
                }
            }
        }
    }

    private void flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    public void Die()
    {
        // Destroy the enemy
        Destroy(gameObject);
        FindObjectOfType<SoundManager>().PlaySoundEffect("BearRoar");
        this.finishPublisher.UpdateFinish(true);
    }
}
