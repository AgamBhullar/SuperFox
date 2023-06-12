using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private BoxCollider2D cont;
    private Animator anim;
    private SpriteRenderer sprite;
    private StompManager stompManager;

    private float moveX = 0f;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;
    [SerializeField] private LayerMask jumpGround;

    private enum CharMovement { idle, running, jumping, falling }
    //private CharMovement state = CharMovement.idle;


    // Start is called before the first frame update
    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        cont = GetComponent<BoxCollider2D>();
        stompManager = GetComponent<StompManager>();
        if (stompManager != null)
        {
            stompManager.InitializeJump(Jump);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        if (rb2D.bodyType == RigidbodyType2D.Static)
        {
            return;
        }
        rb2D.velocity = new Vector2(moveX * moveSpeed, rb2D.velocity.y);
        // rb2D.velocity = new Vector3(moveX * moveSpeed, rb2D.velocity.y, 0);
        // GameObject.transform.rotation = new Vector3(0,0,0);

        if (Input.GetButtonDown("Jump") && StayOnGround())
        {
            Jump();
            // rb2D.velocity = new Vector3(moveX * moveSpeed, rb2D.velocity.y, 0);

        }

        AnimationUpdate();
    }

    public void Jump()
    {
        if (rb2D.bodyType == RigidbodyType2D.Static)
        {
            return;
        }
        rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce);
    }

    private void AnimationUpdate()
    {
        CharMovement state; 
        if (moveX > 0f)
        {
            state = CharMovement.running;
            sprite.flipX = false; 
        }
        else if (moveX < 0f)
        {
            state = CharMovement.running;
            sprite.flipX = true;
        }
        else
        {
            state = CharMovement.idle;
        }

        if (rb2D.velocity.y > 0.1f)
        {
            state = CharMovement.jumping;
        }
        else if (rb2D.velocity.y < -0.1f)
        {
            state = CharMovement.falling;
            // state = CharMovement.jumping;
        }

        anim.SetInteger("state", (int)state);
    }

    private bool StayOnGround()
    {
        return Physics2D.BoxCast(cont.bounds.center, cont.bounds.size, 0f, Vector2.down, 0.1f, jumpGround);
    }
}
