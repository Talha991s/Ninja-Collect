using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PickUp : MonoBehaviour
{
    [SerializeField] private int TotalFruits =15;
    [SerializeField] private int CollectedF =1;

    [SerializeField] private TMP_Text totalFtext;
    [SerializeField] private TMP_Text collect_text;

    private PlayerHealth playerHealth;
    //[SerializeField] private GameObject collect;
    // Start is called before the first frame update
    private void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
    }
    private void Update()
    {
        totalFtext.text = TotalFruits.ToString();
        collect_text.text = CollectedF.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            Destroy(other.gameObject);
            CollectedF += 1;
            playerHealth.currentHealth += 3;
        }
    }
}
