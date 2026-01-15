using UnityEngine;

public class Player : MonoBehaviour
{
    private float xInput = 0;
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        xInput = Input.GetAxis("Horizontal");
        rb.linearVelocityX = xInput * moveSpeed;
    }
}
