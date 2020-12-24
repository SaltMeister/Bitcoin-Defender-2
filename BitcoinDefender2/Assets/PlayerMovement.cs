using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed;
    bool isTouch;
    Rigidbody2D rb2d;

    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        isTouch = false;
        rb2d.freezeRotation = true;
    }
    // Update is called once per frame
    void Update()
    {
    	if(Input.GetKey(KeyCode.A))
    	{
    		Move();
    	}

		 if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) ||
         Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W))
        {
            Move();
        }

    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
    	Debug.Log("colliding");
    	Stop();
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
    	Debug.Log("collision");
    	Stop();
    }



    void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

		transform.position = transform.position + new Vector3(moveHorizontal * speed * Time.deltaTime, moveVertical * speed * Time.deltaTime, 0);
        
    }
    void Stop()
    {

    }
}
