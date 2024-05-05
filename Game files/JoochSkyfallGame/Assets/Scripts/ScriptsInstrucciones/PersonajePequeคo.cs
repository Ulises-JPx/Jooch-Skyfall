/*Código escrito por el equipo JOOCH SKYFALL 2024
    Sebastián Espinoza Farías--------A01750311
    Julio César Vivas Medina---------A01749879
    Melissa Mireles Rendón-----------A01379736
    Ulises Jaramillo Portilla--------A01798380
    Alberto Cebreros González--------A01798671
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Clase para el movimiento del personaje pequeño
public class PersonajePequeño : MonoBehaviour
{
    //Referencias a los componentes del personaje
    public Animator animator;
    private float horizontal;
    private float speed = 3f;
    private float jumpingPower = 8f;
    private bool isFacingRight = true;

    private bool canDash = true;
    private bool isDashing;
    private float dashingPower = 30f;
    private float dashingTime = 0.2f;
    private float dashingCooldown = 1f;


    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private TrailRenderer tr;

    //Funcion que se llama cada frame del juego
    private void Update()
    {
        if (isDashing)
        {
            return;
        }

        horizontal = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(horizontal));

        if (Input.GetButtonDown("Jump") && IsGrounded()){
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            animator.SetBool("IsJumping", true);   
        }else if (IsGrounded())
        {
            animator.SetBool("IsJumping", false);
        }
        

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);

        }
        

        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash)
        {
            StartCoroutine(Dash());
        }

        Flip();
    }
    //Funcion que se llama cada cierto tiempo para el movimiento del personaje
    private void FixedUpdate()
    {
        if (isDashing)
        {
            return;
        }

        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    //Funcion que se llama cuando el peersonaje esta tocando el suelo
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
        
    }

    //Funcion que se llama cuando el personaje cambia de dirección
    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            Vector3 localScale = transform.localScale;
            isFacingRight = !isFacingRight;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    //Funcion que se llama cuando el personaje realiza un dash
    private IEnumerator Dash()
    {
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