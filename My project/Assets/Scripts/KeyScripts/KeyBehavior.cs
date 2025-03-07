using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] InventoryManager.AvailableItems itemType;
    void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.CompareTag("Player")) {
            InventoryManager.Instance.addItem(itemType);
            Destroy(gameObject);
        }
    }
}
