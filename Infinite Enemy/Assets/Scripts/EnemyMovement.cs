using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    
  
    public float speed = 5f;
    float timer = 0;
    Vector2 randomPos;
    float timer2 = 0f;

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {

        randomPos = new Vector2(Random.Range(-10f, 10f), Random.Range(-3.4f, 3.4f));
    }

    // Update is called once per frame
    void Update()
    {
        timer2++;

        if (timer < 2f)
        {
            timer += Time.deltaTime;
        }
        else if (timer > 2f)
        {
            timer = 0f;
            randomPos = new Vector2(Random.Range(-45f,45f), Random.Range(-24f, 24f) * speed);
        }
        
       
            

    }

    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, randomPos , speed * Time.deltaTime);    
    }

    void increaseSpeed()
    {
        int random = Random.Range(0, 2);
        if(random == 1) { if (speed >= 3 && speed <= 22f) speed += 1.5f; }
        if (random == 1) { if (speed >= 3 && speed <= 15f) speed -= 2f; }


    }
}
