using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushObj : MonoBehaviour
{
    //Object beign pushed need to have a rigidbody or it wont do anything!

    //Change this to be a formula using the speed the player has
    private float pushPower = 1;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;

        //check if object did not have rigid body or is Kinematic
        if (body == null || body.isKinematic)
        {
            return;
        }
        if(hit.moveDirection.y < -0.3f)
        {
            return;
        }

        //Logic for when collision happens
        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        //Pushes the object based on the point of collision. Remove to only push in x,y,z
        Vector3 collisionPoint = hit.point;
        body.AddForceAtPosition(pushDir * pushPower, collisionPoint, ForceMode.Impulse);
    }
}
