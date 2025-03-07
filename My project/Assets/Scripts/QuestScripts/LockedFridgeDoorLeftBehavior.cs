using System;
using System.Collections;
using System.Collections.Generic;
using SojaExiles;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class LockedFridgeDoorLeftBehavior : opencloseDoor
{
    // Start is called before the first frame update 
    public List<Keylock> keylocks;

    protected void OnMouseOver()
    {

        for (int i = 0; i < keylocks.Count; i++){
            if (keylocks[i] == null){
                continue;
            }

            if (keylocks[i].getLocked()){
                Debug.Log("Lock "+ (i + 1) + " is locked");
                return;
            }
            Debug.Log("Lock "+ (i + 1) + " is unlocked");
        }
        base.OnMouseOver();
    }
}
