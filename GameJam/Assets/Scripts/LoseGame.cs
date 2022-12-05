using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseGame : MonoBehaviour
{
    public string MyScene;
    void RestartGame()
    {
        SceneManager.LoadScene(MyScene);
    }
}
