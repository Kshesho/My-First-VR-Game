using UnityEngine;

public class TERMINATE : MonoBehaviour
{
    public void QuitApp()
    {
        Application.Quit();
        // If running in the editor, stop playing the scene
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; 
#endif
    }
}
