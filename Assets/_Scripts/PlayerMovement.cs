using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{

    [field: SerializeField]
    private float Speed { get; set; } = 10.0f;

    [SerializeField]
    private Rigidbody2D rb;

    public float forceAmount = 100f;

    Vector2 move = new Vector2();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Ensure the camera follows the player
        Camera.main.GetComponent<CameraFollow>().playerTransform = this.transform;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Monster")
            this.gameObject.SetActive(false);
        {
            Debug.Log("Collision: " + collision.gameObject.name);
        }
    }
        //her skal det ske noget når jeg rammer player

        // Update is called once per frame
    private void FixedUpdate()
    {

        move = Vector2.zero;

        if (Input.GetKey(KeyCode.W))

        {

            move.y += Speed;

        }

        if (Input.GetKey(KeyCode.A))

        {

            move.x -= Speed;

        }

        if (Input.GetKey(KeyCode.D))

        {

            move.x += Speed;

        }

        if (Input.GetKey(KeyCode.S))

        {

            move.y -= Speed;

        }


        rb.MovePosition(rb.position + (move * Time.deltaTime));

    }

}
