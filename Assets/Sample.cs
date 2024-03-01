using UnityEngine;
using UnityEngine.SceneManagement;

public class Sample : MonoBehaviour
{
    public SceneObject sceneObject;

    private void Update()
    {
        if (sceneObject != null)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(sceneObject.Path);
            }
        }
    }

    private void OnGUI()
    {
        GUILayout.Label("Path : " + sceneObject.Path);
    }
}