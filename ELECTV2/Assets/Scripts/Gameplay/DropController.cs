using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropController : MonoBehaviour
{

    GameObject objectHolder;
    // Start is called before the first frame update
    void Start()
    {
        objectHolder = this.gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(objectHolder.GetComponent<Gravity>());
        this.gameObject.GetComponentInParent<Rigidbody>().useGravity = true;
        Destroy(this);
    }
}
