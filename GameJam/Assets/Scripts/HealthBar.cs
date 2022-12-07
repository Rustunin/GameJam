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
        SetHealth(currentHealth);
        if (heatltake)
        {
            TakeDAMAGE(20);
            heatltake = false;
        } 

    }
}
