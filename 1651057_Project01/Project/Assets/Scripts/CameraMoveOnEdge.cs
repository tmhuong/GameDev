using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveOnEdge : MonoBehaviour
{
    int width;
    int height;
    public float speed = 7.0f;
    Vector3 cameraPos;
    public Vector2 minmaxX;
    public Vector2 minmaxY;

    // Start is called before the first frame update
    void Start()
    {
        width = Screen.width;
        height = Screen.height;
        cameraPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mousePosition.x >= width && transform.position.x < minmaxX.y)
            cameraPos.x += speed * Time.deltaTime;
        if (Input.mousePosition.x <= 0 && transform.position.x > minmaxX.x)
            cameraPos.x -= speed * Time.deltaTime;
        if (Input.mousePosition.y >= height && transform.position.y < minmaxY.y)
            cameraPos.y += speed * Time.deltaTime;
        if (Input.mousePosition.y <= 0 && transform.position.y > minmaxY.x)
            cameraPos.y -= speed * Time.deltaTime;
        cameraPos.z = -10f;
        transform.position = cameraPos;
    }
}
