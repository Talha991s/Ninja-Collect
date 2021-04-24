using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public float currentHealth;
    public HealthBar healthBar;
    public GameObject gameOver;
    
    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
       if(currentHealth <= 0)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

  
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("DeadZone"))
        {
            TakeDamage(0.01f);
        }
    }
}
