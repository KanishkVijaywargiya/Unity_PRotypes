using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightWheelRotation : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        leftRightWheelRot();
    }

    public void leftRightWheelRot()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput > 0f)
        {
            transform.Rotate(turnSpeed, 0, 0);
        }
        if (horizontalInput < 0f)
        {
            transform.Rotate(turnSpeed, 0, 0);
        }
    }
}
