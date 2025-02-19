using System.Collections;
using System.Collections.Generic;
using SojaExiles;
using Unity.VisualScripting;
using UnityEngine;

public class DoorBehavior : opencloseDoor
{
    // Start is called before the first frame update
    public bool locked; 
    [SerializeField] InventoryManager.AvailableItems requiredItem;
    protected void OnMouseOver() {
        if(!locked || InventoryManager.Instance._inventoryItems.Contains(requiredItem)) {
            base.OnMouseOver();
        }
        else if (Input.GetMouseButtonDown(0)){
            print("the door is locked");
        }
    }
}
