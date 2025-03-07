using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Keylock : MonoBehaviour
{
    public bool locked = true;
    public GameObject requiredObject;
    public GameObject lockedModel;
    public GameObject unlockedModel;
    public bool getLocked(){
        return locked;
    }
    public void setLocked(bool newLocked){
        locked = newLocked;
        if (locked){
            lockedModel.SetActive(true);
            unlockedModel.SetActive(false);
        } else{
            lockedModel.SetActive(false);
            unlockedModel.SetActive(true);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(String.Format("something moved inside the zone: {0}", other.tag));
        
        if(other.gameObject.CompareTag(requiredObject.tag) && locked ){
            setLocked(false);
            Destroy(other.gameObject);
        }
    }
}
