using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DestroyWineGlassTrigger : MonoBehaviour
{
    // This is a skeleton that can be used for whatever we would like in the future!
    public GameObject triggeringObject;
    public GameObject originalObject;
    public GameObject destroyedObject;
    void OnTriggerEnter(Collider Other)
    {
        if(Other.tag == triggeringObject.tag)
        {
            originalObject.SetActive(false);
            destroyedObject.SetActive(true);
        }
    }
}
