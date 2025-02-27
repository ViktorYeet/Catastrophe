using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    // This is a skeleton that can be used for whatever we would like in the future!
    void OnTriggerEnter(Collider Other)
    {
        if(Other.tag == "Player")
        {
            Debug.Log("Object Entered the trigger");
        }
    }
    /*
    private void OnTriggerStay(Collider Other)
    {
        Debug.Log("Object is whitin the trigger");
    }
    */
    private void OnTriggerExit(Collider Other)
    {
        if (Other.tag == "Player")
        {
            Debug.Log("Object Exited the trigger");
        }
    }
}
