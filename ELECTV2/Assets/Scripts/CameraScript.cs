using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float cameraSpeed;

    // Update is called once per frame
    void Update()
    {
        //this.transform.LookAt(target.transform.position);

        /*
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(0, cameraSpeed * Time.deltaTime, 0, Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(0, -cameraSpeed * Time.deltaTime, 0, Space.World);
        }
        */
    }
}
