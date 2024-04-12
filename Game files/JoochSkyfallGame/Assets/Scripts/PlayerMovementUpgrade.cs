using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementUpgrade : MonoBehaviour
{
    public Animator animatorPlayer;
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 12f;
    private bool isFacingRight = true;
    private bool canDash = true;
    private bool isDashing;
    private float dashingPower = 30f;
    private float dashingTime = 0.2f;
    private float dashingCooldown = 1f;
    private bool isGrounded;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private TrailRenderer tr;

    private void Update(){
        if (isDashing){
            return;
        }

        horizontal = Input.GetAxisRaw("Horizontal");
        animatorPlayer.SetFloat("Speed", Mathf.Abs(horizontal));

        if (Input.GetButtonDown("Jump") && isGrounded){
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            animatorPlayer.SetBool("IsJumping", true);
        }
        if (isGrounded && animatorPlayer.GetBool("IsJumping")){
            animatorPlayer.SetBool("IsJumping", false);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f){
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash){
            StartCoroutine(Dash());
        }

        Flip();
    }

    private void FixedUpdate(){
        if (isDashing){
            return;
        }
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Ground")){
            isGrounded = true;
        }
    }
    private void Flip(){
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            Vector3 localScale = transform.localScale;
            isFacingRight = !isFacingRight;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }

    }
    private IEnumerator Dash(){
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);
        tr.emitting = true;
        yield return new WaitForSeconds(dashingTime);
        tr.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;

    }

}
