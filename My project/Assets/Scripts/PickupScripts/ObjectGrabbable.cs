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
    }

    //Makes it so it moves with the GrabPointTransform
    private void FixedUpdate()
    {
        if (objectGrabPointTransform != null) {
            objectRigidbody.MovePosition(objectGrabPointTransform.position);
        }
    }
}
