using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDrag : MonoBehaviour
{
    public float speed = 2.0f;
    Vector2 clickPos;
    Vector2 dragPos;
    Vector2 targetPos;
    Vector2 cameraPos;
    bool isDrag = false;

    // Start is called before the first frame update
    void Start()
    {
        clickPos = Vector2.zero;
        dragPos = Vector2.zero;
        targetPos = Vector2.zero;
        cameraPos = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            clickPos = Input.mousePosition;
            cameraPos = transform.position;
        }
        if (Input.GetMouseButton(0))
        {
            dragPos = Input.mousePosition;
            Vector2 direction = Camera.main.ScreenToWorldPoint(dragPos) - Camera.main.ScreenToWorldPoint(clickPos);
            direction *= -1;
            //transform.Translate(direction, Space.World);
            targetPos = cameraPos + direction;
            isDrag = true;
        }

        if (isDrag)
        {
            transform.position = Vector2.Lerp(transform.position, targetPos, Time.deltaTime * speed);
            Vector3 temp = transform.position;
            temp.z = -10f;
            transform.position = temp;
            if (transform.position.x == targetPos.x && transform.position.y == targetPos.y)
                isDrag = false;
        }
    }
}
