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
    int maxRicochet = 0;
    int vRicochetcalled = 0;


    public GameObject strayBullet;
    ProjectileBehavior enemy;
   

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

    public void Ricochet()
    {
        
        enemy = FindObjectOfType<ProjectileBehavior>();

        vRicochetcalled++;

        if (vRicochetcalled <= 3)
        {
            if (maxRicochet <= 3)
            {
                Instantiate(strayBullet, enemy.enemyDeadPos , Quaternion.identity, transform);
                maxRicochet++;
            }
        }
        Time.timeScale = 1;
        event10Kill.SetActive(false);
        

    }
    public void DoubleHit()
    {
        event10Kill.SetActive(false);
        Time.timeScale = 1;
    }
}

        
           

       

   
