using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SceneSwitcher : MonoBehaviour
{
    public void moveHome()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - currentSceneIndex);
    }

    // Scene name is set in Unity3D
    public void MoveToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // For QC purposes
    public void btnTest()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
    }

    // Function only works in HoloLens 2, in unity3d can be checked using debug.log
    public void ExitApp()
    {
        Application.Quit();
    }
}
