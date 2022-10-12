using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.UI;

public class DeadEnemy60Reward : MonoBehaviour
{
    
    public static UnityEvent Onclicked1;
    public static UnityEvent Onclicked2;

    Button RandomRicochetButton;
    Button DoubleAttackButton;
    GameObject event10Kill;

    // Start is called before the first frame update

    private void Awake()
    {
        RandomRicochetButton = GameObject.Find("Projectile Ricochet").GetComponent<Button>();
        DoubleAttackButton = GameObject.Find("Projectile Ricochet").GetComponent<Button>();
        event10Kill = GameObject.Find("Event10Kill");
    }
    void Start()
    {
        event10Kill.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        
       
      
    }
}

        
           

       

   
