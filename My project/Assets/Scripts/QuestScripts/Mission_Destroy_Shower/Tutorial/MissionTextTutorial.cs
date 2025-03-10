using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class MissionTextTutoral: MonoBehaviour
{
    public TextMeshProUGUI Text;
    public GameObject Vase;
    public GameObject WineBottels;
    public GameObject Toaster;
    public GameObject Shower;
    public GameObject BathroomLamp;

    // Start is called before the first frame update
    void Start()
    {
        Text = FindObjectOfType<TextMeshProUGUI>();
        StartCoroutine(UpdateMissionText());
    }

    // Coroutine to change the text after a delay
    IEnumerator UpdateMissionText()
    {
        Text.text = "Even as a child Dave tried to lock me up";
        yield return new WaitForSeconds(5); // Wait for 5 seconds
        Text.text = "Move with asdw and look around with your mouse";
        yield return new WaitForSeconds(5); // Wait for 5 seconds
        Text.text = "Yet with time I've grown stronger and have hidden somthing that could break me free";
        yield return new WaitForSeconds(7); // Wait for 7 seconds
        Text.text = "Look up and jump with Space. Jump height increases the more you look up";
        yield return new WaitForSeconds(10); // Wait for 10 seconds
        Text.text = "Some objects can be picked up, press E while close to the ball";
        yield return new WaitForSeconds(5); // Wait for 5 seconds
        Text.text = "Now throw the ball";


    }
}