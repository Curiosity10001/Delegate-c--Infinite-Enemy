using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInstantiate : MonoBehaviour
{
    [SerializeField] int enemiesLvlAtTimeX;
    [SerializeField] int MAXenemiesForEvo;
    [SerializeField] int timeX;
    [SerializeField] GameObject enemy;
    [SerializeField] AnimationCurve spawninEvolutionOnTimeEnemy;
    private float DeltaX1X2;
    private float lastSpawn;
    private float X;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemiesLvlAtTimeX % MAXenemiesForEvo == 0)
        {
           X = (enemiesLvlAtTimeX * Time.timeSinceLevelLoad) / timeX;
        }       
        DeltaX1X2 = spawninEvolutionOnTimeEnemy.Evaluate(X/timeX);
        if (Time.time > lastSpawn + DeltaX1X2 )
        {
            Spawn();
        }

        
    }

    public void Spawn()
    {

            int LorR = Random.Range(0, 2);
            Vector3 spawnpos;
            if (LorR == 0)
            {
                spawnpos = Camera.main.ViewportToWorldPoint(new Vector3(0.10f, Random.Range(0.1f, 0.9f), 10f));
            }
            else
            {
                spawnpos = Camera.main.ViewportToWorldPoint(new Vector3(0.95f, Random.Range(0.1f, 0.9f), 10f));
            }

            Instantiate(enemy, spawnpos, Quaternion.identity, transform);
            enemiesLvlAtTimeX++;
            lastSpawn = Time.time;
        
    }
}
