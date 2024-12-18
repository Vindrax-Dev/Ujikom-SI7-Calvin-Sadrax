using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> enemyprefab;

    private float spawntimer;

    public float spawninterval;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
        spawntimer = spawninterval;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawntimer < 0f)
        {
            SpawnEnemy();
            spawntimer = spawninterval;
        }
        if (spawntimer > 0f)
        {
            spawntimer -= Time.deltaTime;
        }
        
    }
    public void SpawnEnemy()
    {
            //Milih acak
            GameObject Enemies = enemyprefab[Random.Range(0, enemyprefab.Count)];
            //Spawn Musuh
            Instantiate(Enemies, transform.position, transform.rotation);
    }
}
