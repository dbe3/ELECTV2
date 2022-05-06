using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public float gravityStrength;
    float currentGravityStrength;
    private Vector3 grav;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentGravityStrength != gravityStrength)
        {
            currentGravityStrength = gravityStrength;
            //grav = new Vector3(0, -gravityStrength, 0);
        }
    }

    private void FixedUpdate()
    {
        this.gameObject.transform.Translate(0, -gravityStrength, 0);
    }
}
