using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    private PlayerHealth PlayerHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerHealth = GetComponent<PlayerHealth>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemies"))
        {
            if(PlayerHealth.currentHealth >= 75)
            {
                Destroy(other.gameObject);
            }
            else if( PlayerHealth.currentHealth < 75)
            {
                PlayerHealth.TakeDamage(5);
            }
        }
    }
}
