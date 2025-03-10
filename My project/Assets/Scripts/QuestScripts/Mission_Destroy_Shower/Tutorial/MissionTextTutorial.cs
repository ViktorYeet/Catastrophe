using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using TMPro;

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
        Text.text = "POG";
        yield return new WaitForSeconds(5); // Wait for 5 seconds
        Text.text = "Try to throw something at the big glass vase.";
    }

    void UpdateWineBottlesText()
    {
        Text.text = "You HATE the wine bottles in the living room.";
    }

    void UpdateToasterText()
    {
        Text.text = "The toaster has never been your friend.";
    }

    void UpdateShowerText()
    {
        Text.text = "Forget the shower, never be wet again.";
    }

    void UpdateBathroomLampText()
    {
        Text.text = "You don't reach the bathroom lamp switch, just take the lamp out.";
    }

    // Update is called once per frame
    void Update()
    {
        Vase = GameObject.Find("Vase_apt_01");
        WineBottels = GameObject.Find("WineBottle8");
        Toaster = GameObject.Find("Toaster_Apt_01 1");
        Shower = GameObject.Find("Bathroom_apt_02");
        BathroomLamp = GameObject.Find("CeilingLampObject");

        if (Vase == null)
        {
            UpdateWineBottlesText();
            if (WineBottels == null)
            {
                UpdateToasterText();
                if (Toaster == null)
                {
                    UpdateShowerText();
                    if (Shower == null)
                    {
                        UpdateBathroomLampText();
                        if (BathroomLamp == null)
                        {
                            Text.text = "You have successfully damaged Dave's life.";
                        }
                    }
                }
            }
        }
    }
}