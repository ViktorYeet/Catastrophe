using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;

public class MissonTxt : MonoBehaviour
{
    public TextMeshProUGUI Text;

    // Start is called before the first frame update
    void Start()
    {
        Text = FindObjectOfType<TextMeshProUGUI>();
        Text.text = "Your mission is to destroy Dave's pesky apartment.";
        Thread.Sleep(300000);
        Text.text = "Throw something at the big glass vase.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}