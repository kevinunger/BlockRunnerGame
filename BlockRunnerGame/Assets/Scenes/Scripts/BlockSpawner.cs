using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{



    public Transform player;
    public playerMovement playerMovement;
    
   // public GameObject Ramp;
    public GameObject Obstacle;
    private GameObject clone = null;
    public int obstacleCount = 0;


    public float spawnDistance = 20;

    public float spawnX;
    public float spawnY;
    public float spawnZ;

    public float difficulty;
    public float spawnIntervall = 2;

    public float b;
    


    //float spawnDistance = 10;




    public Transform[] spawnPoints;
    private bool spawned = false;

    void Start()
    {
        //Invoke("SpawnObstacle", 1);
        //StartCoroutine(DestroyDelayed());
        spawnIntervall = 5F;
        StartCoroutine(SpawnObstacle());


    }

    void Update()
    {
        difficulty = player.transform.position.z;

        //spawnIntervall = Mathf.Pow(difficulty, -0.45f);
        //spawnIntervall = Mathf.Pow((difficulty*30F), (-0.45F));
        //spawnIntervall = Mathf.Pow(16, 2);
        //spawnIntervall = Mathf.Pow((difficulty), (-0.45F));
        if (difficulty > 100)
        {
            b = Mathf.Pow(difficulty, -0.525F);
            spawnIntervall = b * 33.87F;
        }
        

        Debug.Log("Difficulty: " + difficulty.ToString("0"));
        Debug.Log("spawnIntervall: "+ spawnIntervall.ToString("0"));
    }

    void SSpawnObstacle()
    {

        Vector3 playerPos = player.transform.position;
        Vector3 playerDirection = player.transform.forward;
        Quaternion playerRotation = player.transform.rotation;
        Quaternion rotZero = Quaternion.identity;


        Vector3 spawnPos = playerPos + playerDirection * spawnDistance;

        spawned = true;


    }



    IEnumerator SpawnObstacle()
    {
        while (true)
        {

            Debug.Log("Spawn");

            yield return new WaitForSeconds(spawnIntervall);


            Vector3 playerPos = player.transform.position;
            Vector3 playerDirection = player.transform.forward;
            Quaternion playerRotation = player.transform.rotation;
            Quaternion rotZero = Quaternion.identity;


            spawnZ = player.transform.position.z + 350f;

            spawnX = Random.Range(-7, 7);

            Vector3 spawnPos = new Vector3(spawnX, 1, spawnZ);


            clone = Instantiate(Obstacle, spawnPos, rotZero);

            obstacleCount++;

            Destroy(clone, 12);

        }
    }

/*

    IEnumerator DestroyDelayed()

    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            
            if (clone != null && obstacleCount > 3)
            {
                Destroy(clone);
                obstacleCount--;
            }

            clone = null;
           

            Debug.Log("Destroy");
        }
        
    }


    */

}
