using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public int maxHealth = 100;
    public  int currentHealth;
    public HealthBar healthBar;
    public static bool heatltake;
    int takehealth;

    //canvas
    public GameObject RestartMenu;
    public GameObject swordObj;
    public GameObject ghidorahCanvas;
    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
    }
    public void SetHealth(int health)
    {
        slider.value = health;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
    public void TakeDAMAGE(int damagge)
    {
        currentHealth -= damagge;
    }
    
    private void Update()
    {
        if (menu2.isRestart)
        {
            currentHealth = maxHealth;
            menu2.isRestart = false;
        }
        SetHealth(currentHealth);
        if (heatltake)
        {
            TakeDAMAGE(20);
            heatltake = false;
        }
        if (currentHealth<=0)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;           
            ghidorahCanvas.SetActive(false);
            RestartMenu.SetActive(true);
            swordObj.SetActive(false);         
            currentHealth = 100;
            
        }

    }
}
