using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MissionTextFoodInFridge : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public GameObject Vase;
    public GameObject WineBottels;
    public GameObject Toaster;
    public GameObject Shower;
    public GameObject BathroomLamp;
    public string nextSceneName;

    // Start is called before the first frame update
    void Start()
    {
        Text = FindObjectOfType<TextMeshProUGUI>();
        StartCoroutine(UpdateMissionText());
    }

    // Coroutine to change the text after a delay
    IEnumerator UpdateMissionText()
    {
        Text.text = "Dave has hid the food in the fridge and locked it with five locks. I got to find them!";
        yield return new WaitForSeconds(7); // Wait for 5 seconds
        Text.text = "";
    }

  
}