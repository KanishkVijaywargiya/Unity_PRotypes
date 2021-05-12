using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    private float xRange = 8.0f;
    private float zRange = 192.0f;
    private float zRangeBack = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // controlling horizontal/vertical movement of car
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // We'll move the vehicle forward
        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * Time.maximumDeltaTime * speed * forwardInput);

        if (forwardInput > 0f || forwardInput < 0f)
        {
            if (horizontalInput > 0f || horizontalInput < 0f)
            {
                transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
            }
        }

        inBounds();
    }

    public void inBounds()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        if (transform.position.z < -zRangeBack)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRangeBack);
        }
    }
}
