using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public float currentHealth;
    public HealthBar healthBar;
    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
       
    }
    void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    private void OnTriggerEnter(Collider other)
    {
      
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("DeadZone"))
        {
            TakeDamage(0.01f);
        }
    }
}
