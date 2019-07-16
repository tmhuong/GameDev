using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToMove : MonoBehaviour
{
    public float speed = 1.0f;
    Vector2 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        targetPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if((Vector2)transform.position != targetPos)
        {
            if (transform.position.x < targetPos.x)
                GetComponent<SpriteRenderer>().flipX = false;
            else
                GetComponent<SpriteRenderer>().flipX = true;
            transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        }
    }
}
