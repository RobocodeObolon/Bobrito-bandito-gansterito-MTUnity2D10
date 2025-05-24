using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveV, moveH;
    public float moveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveH = Input.GetAxis("Horizontal");   
        moveV = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(moveH, moveV) * moveSpeed;

        Vector2 direction = new Vector2(moveH, moveV);
        FindObjectOfType<PlayerAnimation>().SetDirection(direction);
    }
}
