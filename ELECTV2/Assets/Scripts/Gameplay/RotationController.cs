using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    //Attaches to Shape
    [Range(0.5f,3.0f)]
    public float rotationSpeed;

    float rotX;
    float rotY;
    float rotZ;
    // Update is called once per frame
    void Update()
    {
        //control block rotation
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0, rotationSpeed, 0, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Rotate(0, 0, -rotationSpeed, Space.World);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0, -rotationSpeed, 0, Space.World);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Rotate(0, 0, rotationSpeed, Space.World);
        }

        
         if (Input.acceleration.x != 0) {
             transform.Rotate(Input.acceleration.x * rotationSpeed, 0, 0, Space.World);
         }
         
         if (Input.acceleration.y != 0)
         {
             transform.Rotate(0, Input.acceleration.y * rotationSpeed, 0, Space.World);
         }

         if (Input.acceleration.z != 0)
         {
             transform.Rotate(0, 0, Input.acceleration.z * rotationSpeed, Space.World);
         }

        Debug.Log(Input.acceleration.x + " " + Input.acceleration.y + " " + Input.acceleration.z);
        

    }
}
