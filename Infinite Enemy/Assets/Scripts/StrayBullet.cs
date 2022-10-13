using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrayBullet : MonoBehaviour
{
    public float strayBuletSpeed = 5f;
    Vector2 randomRicochet;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 4f)
        {
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        randomRicochet = new Vector2(Random.Range(-45f, 45f), Random.Range(-24f, 24f) *strayBuletSpeed);
        transform.position = Vector2.MoveTowards(transform.position, randomRicochet , strayBuletSpeed * Time.deltaTime);
    }
}
