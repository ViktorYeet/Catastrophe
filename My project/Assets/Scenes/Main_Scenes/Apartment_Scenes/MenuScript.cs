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
        SceneManager.LoadScene("Assets/Scenes/Main_Scenes/Apartment_Scenes/Apartment.unity"); // Byt ut med din spelscen
        //AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("Assets/Scenes/Main_Scenes/OutDoors/Outdoors.unity", SceneManager.Additive);
    }

    void OpenOptions()
    {
        Debug.Log("Options clicked!");
        // Lägg till kod för att öppna alternativmenyn
    }

    void QuitGame()
    {
        Debug.Log("Quit clicked!");
        Application.Quit();
    }
}
