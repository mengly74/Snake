using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2 (moveSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = new Vector2 (0, moveSpeed);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = new Vector2 (0, -moveSpeed);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2 (moveSpeed, 0);
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector2 (-moveSpeed, 0);
        }
    }
}
