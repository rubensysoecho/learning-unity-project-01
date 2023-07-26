using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Without the speed, the vehicle moves 1 meter/second, now it moves 20 meters/second
        /* The method Update() does execute every frame, but that depends on the power of the computer
           so Time.deltaTime makes it executable every real time second. 
        */
        int speed = 20;
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
