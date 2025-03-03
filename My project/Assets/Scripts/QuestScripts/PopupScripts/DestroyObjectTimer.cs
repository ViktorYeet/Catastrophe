using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class PopUpText : MonoBehaviour
{
    //Modify value here tp decide when it is destroyed
    public float DestroyTIme;
    void Start()
    {
        Destroy(gameObject, DestroyTIme);
    }
}
