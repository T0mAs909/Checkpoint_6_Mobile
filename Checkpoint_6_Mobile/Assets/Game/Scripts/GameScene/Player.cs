using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    Vector2 move;
    bool isJump;
    bool onGround;
    Rigidbody rb;
    public int score;
    public event Action<int> OnAddScore;

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

        if (collision.gameObject.tag == "Enemy")
        {
            if (!onGround)
            {
                Destroy(collision.gameObject);
                AddScore(score);
            }
            else
            {
                SceneManager.LoadScene("MenuScene");
            }
        }
    }

    void AddScore(int add)
    {
        add = 1;
        score += add;
        OnAddScore?.Invoke(score);
    }
}
