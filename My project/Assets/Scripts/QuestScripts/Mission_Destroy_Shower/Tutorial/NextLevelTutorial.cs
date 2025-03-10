using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelTutorial : MonoBehaviour
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
