using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;
    private Rigidbody2D rb;
    private float move;
    public float jumpHight = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        jump();
    }

    private void FixedUpdate()
    {
        walk();
        jump();
    }

    private void walk()
    {
        Vector3 movement = new Vector3(move, 0f, 0f);
        transform.position += movement * Time.deltaTime * movementSpeed;
    }
    private void jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHight), ForceMode2D.Impulse);
        }
    }
}
