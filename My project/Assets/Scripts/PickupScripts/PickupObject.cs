using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    [SerializeField] private Transform PlayerCameraTransform;
    [SerializeField] private Transform objectGrabPointTransform;
    [SerializeField] private LayerMask pickUpLayerMask;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float pickupdistance = 2f;
            if (Physics.Raycast(PlayerCameraTransform.position, PlayerCameraTransform.forward, out RaycastHit raycasthit, pickupdistance)) 
            {
                Debug.Log(raycasthit.transform);
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