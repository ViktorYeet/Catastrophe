using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ObjectGrabbable : MonoBehaviour
{
    private Rigidbody objectRigidbody;
    private Transform objectGrabPointTransform;

    // Makes it so it only works for Rigidbody
    private void Awake()
    {
        objectRigidbody = GetComponent<Rigidbody>();
    }
    // Moves the object to the GrabpointTransforms
    public void Grab(Transform objectGrabPointTransform)
    {
        this.objectGrabPointTransform = objectGrabPointTransform;
        this.GetComponent<Rigidbody>().useGravity = false;
        this.GetComponent<CapsuleCollider>().enabled = false;
    }
    //Drops item
    public void Drop()
    {
        //Drops object and turns on collision and gravity
        this.objectGrabPointTransform = null;
        this.GetComponent<Rigidbody>().useGravity = true;
        this.GetComponent<Collider>().enabled = true;
    }

    public void Throw(Vector3 throwDirection, float throwForce)
    {
        //Throws object and turns on collision and gravity
        this.objectGrabPointTransform = null;
        this.GetComponent<Rigidbody>().useGravity = true;
        this.GetComponent<Collider>().enabled = true;
        objectRigidbody.velocity = throwDirection.normalized * throwForce;
    }

    //Makes it so it moves with the GrabPointTransform
    private void FixedUpdate()
    {
        if (objectGrabPointTransform != null) {
            objectRigidbody.MovePosition(objectGrabPointTransform.position);
        }
    }
}
