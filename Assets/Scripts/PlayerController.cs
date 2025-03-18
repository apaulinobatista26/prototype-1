using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{     
    public float turnspeed = 50.0f;
    public float speed = 5.0f;
    public float horizontalInput;
    float forwardInput;
    public GameObject thirdPersonCamera;
    public GameObject firstPersonCamera;
    private bool isFirstPerson = false;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        thirdPersonCamera.SetActive(true);
        firstPersonCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical"); 
       // Move vechile forward
       transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
       transform.Rotate(Vector3.up * Time.deltaTime * turnspeed * horizontalInput);


        if (Input.GetKeyDown(KeyCode.C)) 
        {
           isFirstPerson = !isFirstPerson; 
           thirdPersonCamera.SetActive(!isFirstPerson); 
           firstPersonCamera.SetActive(isFirstPerson);
        }
        if (Input.GetKeyDown(KeyCode.Space))
         {
            // Launch a projectile from player 
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
         }
    }
}
