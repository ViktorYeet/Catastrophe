using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    [SerializeField] private Transform PlayerCameraTransform;
    [SerializeField] private Transform objectGrabPointTransform;
    [SerializeField] private LayerMask pickUpLayerMask;
    private ObjectGrabbable objectGrabbable;
    private float throwPower = 5f;


    // updates constantly
    private void Update()
    {
        //Detects if E is pressed down
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (objectGrabbable == null){


                //Checks if player is in range of pickup
                float pickupdistance = 2f;
                if (Physics.Raycast(PlayerCameraTransform.position, PlayerCameraTransform.forward, out RaycastHit raycasthit, pickupdistance))
                {
                    Debug.Log(raycasthit.transform);
                    //If object has the ObjectGrabbable script grab it, and turn of collision and gravity
                    if (raycasthit.transform.TryGetComponent(out objectGrabbable))
                    {
                        objectGrabbable.Grab(objectGrabPointTransform);
                    }
                }
            }
            else if(Input.GetKeyDown(KeyCode.Mouse0)) {
                //Throw item if something is carried
                Vector3 throwDirection = PlayerCameraTransform.forward;
                objectGrabbable.Throw(throwDirection, throwPower);
                objectGrabbable = null;
            }
            else
            {
                //Drop item if something is carried
                objectGrabbable.Drop();
                objectGrabbable = null;
            }
        }
    }
}