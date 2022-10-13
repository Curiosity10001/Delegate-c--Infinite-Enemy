using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
    [SerializeField] SpriteRenderer player;
    [SerializeField] GameObject playerGObject;
    [SerializeField] GameObject projectile;
    [SerializeField] int BulletsLvlAtTimeX;
    [SerializeField] int MAXBulletsForEvo;
    [SerializeField] float timeX;
    [SerializeField] AnimationCurve spawninEvolutionOnTimeBullets;


    private float DeltaX1X2;
    private float lastSpawn;
    private float X;
    Vector2 playerPos;
    GameObject bullet;
    


    private void Awake()
    {
     
    }
    void Start()
    {
        Debug.Log("game start");
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = playerGObject.transform.position;
  
        X = (BulletsLvlAtTimeX * Time.timeSinceLevelLoad) / timeX;
 
        DeltaX1X2 = spawninEvolutionOnTimeBullets.Evaluate(X / timeX);
        if (Time.time > lastSpawn + DeltaX1X2)
        {
            Spawn();
        }



    }

    public void Spawn()
    {
        for (int i = 0; i < 360; i += 45)
        {
            Instantiate(projectile, playerPos, Quaternion.Euler(0f,0f, (1 * i)), transform);
            player.color = Color.green;
          
        }
        BulletsLvlAtTimeX += 4;
        lastSpawn = Time.time;
        player.color = Color.white;
    }

    
}


