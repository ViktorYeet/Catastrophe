using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushObj : MonoBehaviour
{

    private float pushPower = 4;
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
        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        //
        Vector3 collisionPoint = hit.point;
        body.AddForceAtPosition(pushDir * pushPower, collisionPoint, ForceMode.Impulse);
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
