using UnityEngine;

public class ManuelMovement : MonoBehaviour
{
    [field: SerializeField]
    public float speed { get; set; } = 2.0f;
    private Rigidbody2D rb;
    private Animator animator;

    Vector2 move = new Vector2();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = rb.GetComponentInChildren<Animator>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Vector2 manuelMovement = new Vector2(speed, 0);
        //rb.MovePosition(rb.position + (manuelMovement * Time.deltaTime));

        move = Vector2.zero;
        animator.SetBool("run", false);

        if (Input.GetKey(KeyCode.W))
        {
            move.y += speed;
            animator.SetBool("run", true);
        }

        if (Input.GetKey(KeyCode.A))
        {
            move.x -= speed;
            animator.SetBool("run", true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            move.x += speed;
            animator.SetBool("run", true);
        }

        if (Input.GetKey(KeyCode.S))
        {
            move.y -= speed;
            animator.SetBool("run", true);
        }


        rb.MovePosition(rb.position + (move * Time.deltaTime));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy1")
        { 
            
        }
        //her skal det ske noget når jeg rammer player


    }











}
