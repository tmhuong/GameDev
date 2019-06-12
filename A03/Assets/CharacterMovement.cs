using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 1.0f;
    public float jumpSpeed = 300f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0));
            GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<Animator>().SetTrigger("StoneWalk");
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Animator>().SetTrigger("StoneWalk");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpSpeed));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroy(collision.gameObject);
        Debug.Log(collision.gameObject.name);
    }
}
