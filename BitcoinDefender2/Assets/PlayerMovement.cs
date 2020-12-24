using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed;
    bool isHit;
    Rigidbody2D rb2d;

    [Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;  // How much to smooth out the movement
    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        isHit = false;
        rb2d.freezeRotation = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) ||
         Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.W))
        {
            Stop();
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) ||
         Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
        {
            Move();
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
    	Debug.Log("colliding");
    	Stop();
    }


    void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

		transform.position = transform.position + new Vector3(moveHorizontal * speed * Time.deltaTime, moveVertical * speed * Time.deltaTime, 0);
        
        //Vector3 targetVelocity = new Vector2(moveHorizontal * 2f, moveVertical * 2f);
        //rb2d.velocity = Vector3.SmoothDamp(rb2d.velocity, targetVelocity, ref velocity, m_MovementSmoothing);
    }
    void Stop()
    {
        Vector3 targetVelocity = new Vector2(0f, 0f);

        //rb2d.velocity = Vector3.SmoothDamp(rb2d.velocity, targetVelocity, ref velocity, m_MovementSmoothing);

    }
}
