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

    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        optionsButton.onClick.AddListener(OpenOptions);
        quitButton.onClick.AddListener(QuitGame);
        backButton.onClick.AddListener(BackButton);
        OptionsPanel = GameObject.Find("OptionsPanel");
        OptionsPanel.SetActive(false);
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
        // L�gg till kod f�r att �ppna alternativmenyn
    }
}
