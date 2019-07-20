using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    Vector2 targetPos;
    // Start is called before the first frame update
    void Start()
    {
        targetPos = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = new Vector2(targetPos.x - transform.position.x, targetPos.y - transform.position.y);
        transform.up = direction;
    }
}
