using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public void SwitchScene()
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
}
