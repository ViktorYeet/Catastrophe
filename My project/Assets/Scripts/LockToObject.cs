using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LockToObject : MonoBehaviour
{
    public Transform lockObject;

    // Update is called once per frame
    void Update()
    {
        transform.position = lockObject.transform.position;
        transform.rotation = lockObject.transform.rotation;
    }
}
