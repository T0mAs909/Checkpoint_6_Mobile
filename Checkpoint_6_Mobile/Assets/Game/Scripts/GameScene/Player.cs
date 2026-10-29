using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    Vector2 move;
    bool isJump;
    bool onGround;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
    }

    public void Jump()
    {
        if (onGround && Time.timeScale > 0)
        {
            isJump = true;
        }
    }

    void FixedUpdate()
    {
        OnMove();
        OnJump();
    }

    void OnMove()
    {
        rb.linearVelocity = new Vector3(move.x * speed, rb.linearVelocity.y, move.y * speed);
    }

    void OnJump()
    {
        if (isJump)
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpForce, 0);
            isJump = false;
            onGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            onGround = true;
        }
    }
}
