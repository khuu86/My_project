using UnityEngine;

public class AutoMovement : MonoBehaviour
{
    [field: SerializeField]
    private float speed { get; set; } = 2.0f;

    private Rigidbody2D rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        //rb.MovePosition(rb.position + ( moveDirection * Time.deltaTime));
        rb.linearVelocity = new Vector2(0, speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall1")
            speed = -speed ;
        //her skal det ske noget når jeg rammer player

    }
}