using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    [field: SerializeField]
    private float speed { get; set; } = 2.0f;

    [field: SerializeField]
    private bool move { get; set; } = false;


    Vector2 moveDirection = new Vector2();

    private Rigidbody2D rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Set a random initial direction
        int randomDirection = Random.Range(0, 4);
        switch (randomDirection)
        {
            case 0:
                moveDirection = Vector2.up;
                break;
            case 1:
                moveDirection = Vector2.down;
                break;
            case 2:
                moveDirection = Vector2.left;
                break;
            case 3:
                moveDirection = Vector2.right;
                break;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (move)
        {
            rb.MovePosition(rb.position + (moveDirection * speed * Time.deltaTime));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            // Reverse the direction when hitting a wall
            moveDirection = -moveDirection;
        }

        if (collision.gameObject.tag == "Player")
            this.gameObject.SetActive(false);
        //her skal det ske noget når jeg rammer player
    }
}