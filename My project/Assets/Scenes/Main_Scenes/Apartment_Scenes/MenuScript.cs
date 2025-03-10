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
    public GameObject OptionsPanel;
    public GameObject StartPanel;

    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        optionsButton.onClick.AddListener(OpenOptions);
        quitButton.onClick.AddListener(QuitGame);
        backButton.onClick.AddListener(BackButton);
        OptionsPanel.SetActive(false);
        StartPanel.SetActive(true);
    }

    void StartGame()
    {
        Debug.Log("Start Game clicked!");
        SceneManager.LoadScene("Assets/Scenes/Missions/Tutorial/TutorialMission.unity"); // Byt ut med din spelscen
    }

    void OpenOptions()
    {
        Debug.Log("Options clicked!");
        OptionsPanel.SetActive(true);
        StartPanel.SetActive(false);
        Debug.Log("test");
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
    }
}
