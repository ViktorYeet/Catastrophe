using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    public HashSet<AvailableItems> _inventoryItems = new HashSet<AvailableItems>(); // items currently in the inventory

    public void addItem(AvailableItems item) {
        _inventoryItems.Add(item);
    }

    public void removerItem(AvailableItems item) {
        _inventoryItems.Remove(item);
    }

    private void Awake() {
        Instance = this;
    }

    public enum AvailableItems {
        Key
    }
}
