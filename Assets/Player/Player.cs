using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool isGrounded = false;

    private bool isJumping = false;
    private float jumpCounter = 0f;

    [SerializeField] Transform groundChecker;
    [SerializeField] LayerMask groundLayer;

    [SerializeField] Rigidbody2D body_rb;

    [SerializeField] float jumpHeight = 5f;
    [SerializeField] float jumpTime = 2f;

    [SerializeField] int gravity = 1;
    [SerializeField] int fallGravity = 3;

    [SerializeField] GameObject retryMenu;
    [SerializeField] GameObject CoinPanel;


    void Update()
    {
        // When we have to take Input we take it in Update.

        JumpPlayer();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            Time.timeScale = 0;
            retryMenu.SetActive(true);
            CoinPanel.SetActive(false);
        }
    }

    // fix variable height function in this function.
    void JumpPlayer()
    {
        CheckIfGrounded();

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            body_rb.velocity = new Vector2(body_rb.velocity.x, jumpHeight);
            jumpCounter = 0;
            isJumping = true;
        }

        if (Input.GetKey(KeyCode.Space) && isJumping)
        {
            if (jumpCounter <= jumpTime)
            {
                body_rb.velocity = new Vector2(body_rb.velocity.x, jumpHeight);
                jumpCounter += Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }

        IncreaseGravityAtDescent();
    }

    void CheckIfGrounded()
    {
        Collider2D collider = Physics2D.OverlapCircle(groundChecker.position, 0.05f, groundLayer);

        if (collider != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }

    void IncreaseGravityAtDescent()
    {
        // to apply greater gravity at the point of descent.
        if (body_rb.velocity.y >= 0)
        {
            body_rb.gravityScale = gravity;
        }
        else if (body_rb.velocity.y < 0)
        {
            body_rb.gravityScale = fallGravity;
        }
    }

}
