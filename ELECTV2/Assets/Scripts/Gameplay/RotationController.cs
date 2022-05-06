using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class RotationController : MonoBehaviour
{
    //Attaches to Shape
    [Range(0.5f,3.0f)]
    public float rotationSpeed;

    int id;
    int touchId;
    bool ObjectSelected;

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

        if (Input.touchCount > 0)
        {
            /*
            Touch touch = Input.GetTouch(0);
            int id = touch.fingerId;

            if (touch.phase == TouchPhase.Moved)
            {
                if (!EventSystem.current.IsPointerOverGameObject(id))
                {
                    transform.Rotate(0f, touch.deltaPosition.x * rotationSpeed, touch.deltaPosition.y * rotationSpeed, Space.World);
                }
            }
            */

            if (ObjectSelected)
            {
                Touch touch = Input.GetTouch(id);

                if (touch.phase == TouchPhase.Moved)
                {
                    transform.Rotate(0f, touch.deltaPosition.x * rotationSpeed, touch.deltaPosition.y * rotationSpeed, Space.World);
                }
                else if (touch.phase == TouchPhase.Ended)
                {
                    ObjectSelected = false;
                }
            }
            else
            {
                foreach (Touch touch in Input.touches)
                {
                    id = touch.fingerId;

                    if (!EventSystem.current.IsPointerOverGameObject(id))
                    {
                        ObjectSelected = true;
                        touchId = id;
                        break;
                    }
                }
            }
        }

    }
}
