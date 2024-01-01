using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Snake : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;
    private List<Transform> _snakeSpawn;
    public Transform snakePrefab;
    private bool collideWithWall=false;
    private Vector2 currentdirection=Vector2.right;//snake start from right

    


    // Start is called before the first frame update
    public Game_over_Screen gameOver;
    int Maxplatform=0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(moveSpeed, 0);

        _snakeSpawn = new List<Transform>();
        _snakeSpawn.Add(this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (!collideWithWall)
        {
            handleInput();
        }
    }
    void handleInput()
    {
        if (Input.GetKeyDown(KeyCode.W) && currentdirection != Vector2.down)
        {
            currentdirection = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.S) && currentdirection != Vector2.up)
        {
            currentdirection = Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.A) && currentdirection != Vector2.right)
        {
            currentdirection = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.D) && currentdirection != Vector2.left)
        {
            currentdirection = Vector2.right;
        }
        rb.velocity = currentdirection * moveSpeed;
    }
    private void FixedUpdate()
    {
        for (int i = _snakeSpawn.Count - 1; i > 0; i--)
        {
            _snakeSpawn[i].position = _snakeSpawn[i - 1].position;
        }
    }
    private void grow()
    {
        Transform snakeSpawn = Instantiate(snakePrefab);
        snakeSpawn.position = _snakeSpawn[_snakeSpawn.Count - 1].position;

        _snakeSpawn.Add(snakeSpawn);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "food")
        {
            grow();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            stopMovement();
        }
    }

    public void stopMovement(){
        collideWithWall=true;
        rb.velocity=Vector2.zero;

    
        collideWithWall = true;
        rb.velocity = Vector2.zero;
        Debug.Log("game over.");
        gameObject.SetActive(false);
        if(gameOver!=null){
            gameOver.Setup(Maxplatform);
            gameOver.gameObject.SetActive(true);
        }
        gameObject.SetActive(false);
        
    }
}
