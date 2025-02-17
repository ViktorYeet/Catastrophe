using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] DoorBehavior doorBehavior;
    void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.CompareTag("Player")) {
            doorBehavior.open();
            Destroy(gameObject);
        }
    }
}
