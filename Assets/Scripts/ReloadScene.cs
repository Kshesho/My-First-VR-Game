using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadScene : MonoBehaviour
{
    string _sceneName;

    private void Start()
    {
        _sceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
    }

    /// <summary>
    /// Reloads the current scene.
    /// </summary>
    public void Reset()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneName);
    }
}
