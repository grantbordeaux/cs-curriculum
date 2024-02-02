using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
      
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 0.1f, groundLayer);

  
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    void Jump()
    {

        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}
