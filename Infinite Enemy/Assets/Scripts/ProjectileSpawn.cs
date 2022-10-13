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
        

        if (BulletsLvlAtTimeX % MAXBulletsForEvo == 0)
        {
            X = (BulletsLvlAtTimeX * Time.timeSinceLevelLoad) / timeX;
        }
        DeltaX1X2 = spawninEvolutionOnTimeBullets.Evaluate(X / timeX);
        if (Time.time > lastSpawn + DeltaX1X2)
        {
            Spawn();
            Debug.Log("spawn initiated");
        }



    }

    public void Spawn()
    {
        for (int i = 0; i < 4; i++)
        {
            Instantiate(projectile, playerPos, Quaternion.Euler(0f,0f, (90f * i)), transform);
            player.color = Color.green;
            Debug.Log(i);
        }
        BulletsLvlAtTimeX += 4;
        lastSpawn = Time.time;
        player.color = Color.white;
    }

    
}


