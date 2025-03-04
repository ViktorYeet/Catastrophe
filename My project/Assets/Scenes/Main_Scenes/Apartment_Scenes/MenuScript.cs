using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public Button startButton;
    public Button optionsButton;
    public Button quitButton;

    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        optionsButton.onClick.AddListener(OpenOptions);
        quitButton.onClick.AddListener(QuitGame);
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
        // L�gg till kod f�r att �ppna alternativmenyn
    }

    void QuitGame()
    {
        Debug.Log("Quit clicked!");
        Application.Quit();
    }
}
