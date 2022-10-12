using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
    public SpriteRenderer player;
    public GameObject playerGObject;
    [SerializeField] GameObject projectile;
    float timer = 0;
    int numOfProjectiles = 0;
    Vector2 spawnpos;
    GameObject projectile1;
    GameObject projectile2;
    GameObject projectile3;
    GameObject projectile4;
    Vector2 playerPos;
    float spawnspeed = 1.5f;


    private void Awake()
    {
     
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
       
        Spawn();
        
        if (timer >= spawnspeed)
        {
            numOfProjectiles = 0;
            timer = 0;
        }
        playerPos = playerGObject.transform.position;
       

    }

    public void Spawn()
    {
        
        if (numOfProjectiles == 0)
            {
            player.color = Color.green;
            spawnpos = playerPos + new Vector2(0,4f);
            projectile1 = Instantiate(projectile,spawnpos, Quaternion.identity, transform);
            numOfProjectiles++;
             }
            else if (numOfProjectiles == 1)
            {
            player.color = Color.green;
            spawnpos = playerPos + new Vector2(4f, 0);
            projectile2 = Instantiate(projectile, spawnpos, Quaternion.identity, transform);
            numOfProjectiles++;
             }
            else if (numOfProjectiles == 2)
            {
            player.color = Color.green;
            spawnpos = playerPos + new Vector2(0, -4f);
            projectile3 = Instantiate(projectile, spawnpos, Quaternion.identity, transform);
            numOfProjectiles++;
              }
            else if (numOfProjectiles == 3)
            {
            player.color = Color.green;
            spawnpos = playerPos + new Vector2(-4f, 0);
            projectile4 = Instantiate(projectile, spawnpos, Quaternion.identity, transform);
            numOfProjectiles++;
        } else if ( numOfProjectiles == 4) player.color = Color.white;

       

    }

    private void FixedUpdate()
    {
        if (projectile1) projectile1.transform.Translate(projectile.transform.up);
        if(projectile2) projectile2.transform.Translate(projectile.transform.right);
        if(projectile3) projectile3.transform.Translate((projectile.transform.up) * -1);
        if(projectile4) projectile4.transform.Translate((projectile.transform.right) * -1);
    }
}


