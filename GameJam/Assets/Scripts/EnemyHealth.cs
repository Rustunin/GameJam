using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public GameObject HealthBarUI;
    public Slider slider;

    private void Start()
    {
        health = maxHealth;
        slider.value = CalculateHealth();
    }
    private void Update()
    {
        slider.value =CalculateHealth();
        if (health<maxHealth)
        {
            HealthBarUI.SetActive(true);
        }

        if (health<=0)
        {
            Destroy(gameObject);
        }
        if (health>maxHealth)
        {
            health = maxHealth;
        }
    }

    float CalculateHealth()
    {
        return health/ maxHealth;
    }

    public void ApplyDamage(float damage)
    {
        health -= damage;
        print(damage);
    }
}
