using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProjectileBehavior : MonoBehaviour
{
    [SerializeField] float speed = 0.5f;
    KilCountDisplay deadEnemy;
    float timer = 0;
    public float timeOfDeath;
    KilCountDisplay killtoreward;
    public Vector2 enemyDeadPos;

    // Start is called before the first frame update
    void Start()
    {
        deadEnemy = FindObjectOfType<KilCountDisplay>();
        killtoreward = FindObjectOfType<KilCountDisplay>();
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
            if(deadEnemy.killCount % killtoreward.killToreward == 0)
            {
                timeOfDeath = Time.time;
                enemyDeadPos = collision.gameObject.transform.position;
            }
               
        }
    }
    private void FixedUpdate()
    {
        transform.Translate(transform.right * speed);
    }
}
