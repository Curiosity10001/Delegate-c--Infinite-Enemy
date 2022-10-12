using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInstantiate : MonoBehaviour
{
    [SerializeField] int maxEnemiesLvl;
    [SerializeField] GameObject enemy;

    public int nbEnemiesLvl = 0;
    float timer = 0;

    void Start()
    {
        Instantiate(enemy, new Vector2 (35f,23f), Quaternion.identity, transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (nbEnemiesLvl>=0  && nbEnemiesLvl < 30 )
        {
            if (timer <= 1.5f)
            {
                timer += Time.deltaTime;
            }
            else if (timer > 1.5f)
            {
                timer = 0;
                Spawn();
            }

        }
        if (nbEnemiesLvl >= 30 && nbEnemiesLvl < 60)
        {
            if (timer <= 1.3f)
            {
                timer += Time.deltaTime;
            }
            else if (timer > 1.3f)
            {
                timer = 0;
                Spawn();
            }

        }
        if (nbEnemiesLvl >= 60 && nbEnemiesLvl < 95)
        {
            if (timer <= 1f)
            {
                timer += Time.deltaTime;
            }
            else if (timer > 1f)
            {
                timer = 0;
                Spawn();
            }

        }
        if (nbEnemiesLvl >= 95 && nbEnemiesLvl < 200)
        {
            if (timer <= 0.8f)
            {
                timer += Time.deltaTime;
            }
            else if (timer > 0.8f)
            {
                timer = 0;
                Spawn();
            }

        }
        if (nbEnemiesLvl >= 200 && nbEnemiesLvl < 450)
        {
            if (timer <= 0.6f)
            {
                timer += Time.deltaTime;
            }
            else if (timer > 0.6f)
            {
                timer = 0;
                Spawn();
            }

        }
        if (nbEnemiesLvl >= 450 && nbEnemiesLvl < 800)
        {
            if (timer <= 0.3f)
            {
                timer += Time.deltaTime;
            }
            else if (timer > 0.3f)
            {
                timer = 0;
                Spawn();
            }

        }
        if (nbEnemiesLvl >= 800)
        {
            if (timer <= 0.1f)
            {
                timer += Time.deltaTime;
            }
            else if (timer > 0.1f)
            {
                timer = 0;
                Spawn();
            }

        }
    }

    public void Spawn()
    {

        if (nbEnemiesLvl < maxEnemiesLvl)
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
            nbEnemiesLvl++;
        }
    }
}
