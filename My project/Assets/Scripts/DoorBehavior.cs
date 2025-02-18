using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public void open() {
        Destroy(gameObject);
    }
}
