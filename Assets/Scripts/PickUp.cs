using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PickUp : MonoBehaviour
{
    [SerializeField] private int TotalFruits =20;
    [SerializeField] public int CollectedF =1;

    [SerializeField] private TMP_Text totalFtext;
    [SerializeField] private TMP_Text collect_text;

    public AudioSource collect;

    private PlayerHealth playerHealth;
    //public Timer timer;
    [SerializeField] private GameObject Winscene;
    //[SerializeField] private GameObject collect;
    // Start is called before the first frame update
    private void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
        //timer = GetComponent<Timer>();
    }
    private void Update()
    {
        totalFtext.text = TotalFruits.ToString();
        collect_text.text = CollectedF.ToString();

        if(CollectedF >= 20)
        {
            Winscene.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            Destroy(other.gameObject);
            CollectedF += 1;
            playerHealth.currentHealth += 3;
            collect.Play();
        }
   
    }
    
}
