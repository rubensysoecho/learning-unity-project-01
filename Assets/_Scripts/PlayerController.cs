using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float turnSpeed;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        // Without the speed, the vehicle moves 1 meter/second, now it moves 20 meters/second
        /* The method Update() does execute every frame, but that depends on the power of the computer
           so Time.deltaTime makes it executable every real time second. 
        */
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * turnSpeed);
    }
}
