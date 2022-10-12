using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProjectileBehavior : MonoBehaviour
{

    KilCountDisplay deadEnemy;
    float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        deadEnemy = FindObjectOfType<KilCountDisplay>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2.5f)
        {
            Destroy(gameObject);
        }
       
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            deadEnemy.killCount++;
        }
    }
    
}
