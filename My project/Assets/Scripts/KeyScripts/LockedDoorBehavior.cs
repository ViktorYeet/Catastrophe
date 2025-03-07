using System;
using System.Collections;
using System.Collections.Generic;
using SojaExiles;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class DoorBehavior : opencloseDoor
{
    // Start is called before the first frame update
    public bool locked; 
    public GameObject requiredObject;
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(String.Format("something moved inside the zone: {0}", other.tag));
        if(other.gameObject.CompareTag(requiredObject.tag)) {
            locked = false;
            Destroy(other.gameObject);
        }
    }

    protected void OnMouseOver()
    {
        if (locked) return;
        base.OnMouseOver();
    }
}
