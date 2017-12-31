using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

    private void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void SceneChange(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
