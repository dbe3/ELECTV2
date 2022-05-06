using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    //Attaches to Shapes

    GameObject objectHolder;
    MoveController moveController;
    RotationController rotationController;
    Gravity gravity;

    void Start()
    {
        objectHolder = this.gameObject.transform.parent.gameObject;
        gravity = objectHolder.GetComponent<Gravity>();
        moveController = objectHolder.GetComponent<MoveController>();
        rotationController = this.gameObject.GetComponent<RotationController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gravity);
        Destroy(moveController);
        Destroy(rotationController);
        this.gameObject.GetComponentInParent<Rigidbody>().useGravity = true;
        Destroy(this);
    }
}
