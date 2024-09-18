using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{     
    public float speed = 5.0f;
    public float turnspeed = 50.0f;
    float horizontalInput;
    float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical"); 
       // Move vechile forward
       transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
       transform.Rotate(Vector3.up * Time.deltaTime * turnspeed * horizontalInput);
    }
}
