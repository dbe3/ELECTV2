using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slider : MonoBehaviour
{
    public GameObject CameraRotator;
    public float cameraSpeed;

    int id;
    int touchId;
    bool sliderSelected;

    void Update()
    {
        if (sliderSelected)
        {
            Touch camTouch = Input.GetTouch(id);

            if (camTouch.phase == TouchPhase.Moved)
            {
                CameraRotator.transform.Rotate(0, camTouch.deltaPosition.x * cameraSpeed * Time.deltaTime, 0, Space.World);
            }
            else if (camTouch.phase == TouchPhase.Ended)
            {
                sliderSelected = false;
            }
        }
        else
        {
            foreach (Touch touch in Input.touches)
            {
                id = touch.fingerId;

                if (EventSystem.current.IsPointerOverGameObject(id))
                {
                    sliderSelected = true;
                    touchId = id;
                    break;
                }
            }
        }
    }


}
