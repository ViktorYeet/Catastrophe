using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    [SerializeField] private Transform PlayerCameraTransform;
    [SerializeField] private Transform objectGrabPointTransform;
    [SerializeField] private LayerMask pickUpLayerMask;


    // updates constantly
    private void Update()
    {
        //Detects if E is pressed down
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Checks if player is in range of pickup
            float pickupdistance = 2f;
            if (Physics.Raycast(PlayerCameraTransform.position, PlayerCameraTransform.forward, out RaycastHit raycasthit, pickupdistance)) 
            {
                Debug.Log(raycasthit.transform);
                //If object has the ObjectGrabbable script grab it, and turn of collision and gravity
                if (raycasthit.transform.TryGetComponent(out ObjectGrabbable objectGrabbable))
                    objectGrabbable.GetComponent<CapsuleCollider>().enabled = false;
                    objectGrabbable.GetComponent<Rigidbody>().useGravity = false;
                    objectGrabbable.Grab(objectGrabPointTransform);
                {
                    Debug.Log(objectGrabbable);
                }
            }
        }
    }
}