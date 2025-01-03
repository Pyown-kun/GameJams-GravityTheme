using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private int restartScene;
    [SerializeField] private int nextScene;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Restart()
    {
        SceneManager.LoadScene(restartScene);
    }
    
    public void ChangeScene()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
