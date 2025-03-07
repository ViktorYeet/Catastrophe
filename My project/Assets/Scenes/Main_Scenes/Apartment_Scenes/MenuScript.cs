using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class ButtonHandler : MonoBehaviour
{
    public Button startButton;
    public Button optionsButton;
    public Button quitButton;
    public Button backButton;
    public static GameObject OptionsPanel;
    public static GameObject StartPanel;

    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        optionsButton.onClick.AddListener(OpenOptions);
        quitButton.onClick.AddListener(QuitGame);
        backButton.onClick.AddListener(BackButton);
        OptionsPanel = GameObject.Find("OptionsPanel");
        OptionsPanel.SetActive(false);
        StartPanel = GameObject.Find("StartMenu");
        StartPanel.SetActive(true);
    }

    void StartGame()
    {
        Debug.Log("Start Game clicked!");
        SceneManager.LoadScene("Assets/Scenes/Main_Scenes/OutDoors/Outdoors.unity"); // Byt ut med din spelscen
        SceneManager.LoadSceneAsync("Assets/Scenes/Main_Scenes/Apartment_Scenes/Apartment.unity", LoadSceneMode.Additive);
    }

    void OpenOptions()
    {
        Debug.Log("Options clicked!");
        OptionsPanel.SetActive(true);
        StartPanel.SetActive(false);
    // L�gg till kod f�r att �ppna alternativmenyn
}

    void QuitGame()
    {
        Debug.Log("Quit clicked!");
        Application.Quit();
    }

    void BackButton()
    {
        Debug.Log("Back clicked!");
        OptionsPanel.SetActive(false);
        StartPanel.SetActive(true);
        // L�gg till kod f�r att �ppna alternativmenyn
    }
}
