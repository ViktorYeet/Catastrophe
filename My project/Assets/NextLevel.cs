using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string nextSceneName;
    public GameObject triggerObject;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag != triggerObject.tag){
            return;
        }

        SceneManager.LoadScene(nextSceneName, LoadSceneMode.Single);
    }

}
