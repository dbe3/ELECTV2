using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    //Attaches to Holders
    [Range(0.0f,0.5f)]
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            this.transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.J))
        {
            this.transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.K))
        {
            this.transform.Translate(movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.L))
        {
            this.transform.Translate(0, 0, movementSpeed);
        }
    }
}
