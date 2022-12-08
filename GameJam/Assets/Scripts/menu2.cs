using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu2 : MonoBehaviour
{
    public GameObject Heracl;
   
    public GameObject RestartMenu;
    public static bool isRestart=false;
    public GameObject cursor;
    
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Menu");
        Time.timeScale = 1;
        attackEnemy.animWalkcount = 0;
    }
    public void Restart()
    {
        cursor.SetActive(true);
        isRestart=true;        
        RestartMenu.SetActive(false);
        Debug.Log("Restart");
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }

    public void Appquit()
    {
        Application.Quit();
    }
}
