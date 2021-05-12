using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelsRotate : MonoBehaviour
{
    private float speed = 12.0f;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationEffect();
    }

    public void rotationEffect()
    {
        forwardInput = Input.GetAxis("Vertical");
        if (forwardInput > 0f)
        {
            transform.RotateAroundLocal(Vector3.left, speed);
            print("forward");
        }
        if (forwardInput < 0f)
        {
            transform.RotateAroundLocal(Vector3.right, speed);
            print("backward");
        }
    }
}
