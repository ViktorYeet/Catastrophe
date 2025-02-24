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
    public KeyCode pickupKey;
    public KeyCode dropKey;
    public KeyCode throwKey;
    private float throwPower = 5f;


    // updates constantly
    private void Update()
    {
        // dont do anything unless we pressed one of the keys
        if( !(Input.GetKeyDown(pickupKey) || Input.GetKeyDown(throwKey) || Input.GetKeyDown(dropKey))) return;
        
        //Detects if pickup key is pressed down
        if (Input.GetKeyDown(pickupKey))
        {
            //if we were not holding anything before
            if (objectGrabbable == null)
            {
                pickup();
                return;
            }
        }
        if(Input.GetKeyDown(throwKey))
        {
            //Throw item if something is carried
            throwObject();
        }
        else
        {
            //Drop item if something is carried
            objectGrabbable.Drop();
            objectGrabbable = null;
        }
    }

    private void throwObject()
    {
        Vector3 throwDirection = PlayerCameraTransform.forward;
        objectGrabbable.Throw(throwDirection, throwPower);
        objectGrabbable = null;
    }

    private void pickup()
    {
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
}