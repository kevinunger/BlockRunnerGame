using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{



    public Transform player;
    public playerMovement playerMovement;
    
   // public GameObject Ramp;
    public GameObject Obstacle;
    public GameObject Coin;
    public GameObject cloneCoin;
    private GameObject clone = null;
    private GameObject cloneGround;
    public GameObject Ground; 


    public int obstacleCount = 0;


    public float spawnDistance = 20;

    public float spawnX;
    public float spawnY;
    public float spawnZ;

    public float difficulty;
    public float spawnObstacleIntervall = 2;
    public float spawnCoinIntervall = 2;

    public float b;



    public float spawnIntervallGround;
    public float cloneGroundPosZ;
    public int groundSizeOffset;
    //float spawnDistance = 10;




    public Transform[] spawnPoints;
    private bool spawned = false;

    void Start()
    {
        //Invoke("SpawnObstacle", 1);
        //StartCoroutine(DestroyDelayed());
        spawnObstacleIntervall = 5F;
        spawnCoinIntervall = 1F;
        groundSizeOffset = 400;
        cloneGroundPosZ = 0;
        StartCoroutine(SpawnObstacle());
        StartCoroutine(SpawnGround());
        StartCoroutine(SpawnCoin());


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
            spawnObstacleIntervall = b * 33.87F;
        }

        spawnCoinIntervall = Random.Range(-0.1F, 2);

        //Debug.Log("Difficulty: " + difficulty.ToString("0"));
        //Debug.Log("spawnIntervall: "+ spawnIntervall.ToString("0"));







    }

    IEnumerator SpawnGround()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            
            Quaternion rotZero = Quaternion.identity;



            float spawnZGround = player.transform.position.z + groundSizeOffset;




            Vector3 spawnPosGround = new Vector3(0, 0, spawnZGround);
            
            if ((spawnZGround -  cloneGroundPosZ) > groundSizeOffset)
            {
                //Debug.Log("SpawnGROUND");
                
                cloneGround = Instantiate(Ground, spawnPosGround, rotZero);
                cloneGroundPosZ = spawnZGround;
                
            }

            //Debug.Log(cloneGround.transform.position.z);
            if (((cloneGround.transform.position.z-200) - player.transform.position.z) < 0)
            {
                Destroy(cloneGround,15);
            }

        }


    }


    IEnumerator SpawnObstacle()
    {
        while (true)
        {

          //  Debug.Log("Spawn");

            yield return new WaitForSeconds(spawnObstacleIntervall);


            Vector3 playerPos = player.transform.position;
            //Vector3 playerDirection = player.transform.forward;
            Quaternion playerRotation = player.transform.rotation;
            Quaternion rotZero = Quaternion.identity;


            spawnZ = player.transform.position.z + 350f;

            spawnX = Random.Range(-7, 7);

            Vector3 spawnPos = new Vector3(spawnX, 1, spawnZ);


            clone = Instantiate(Obstacle, spawnPos, rotZero);

            obstacleCount++;

            Destroy(clone,15);

        }
    }



    IEnumerator SpawnCoin()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnCoinIntervall);

            Vector3 playerPos = player.transform.position;
            //Vector3 playerDirection = player.transform.forward;
           // Quaternion playerRotation = player.transform.rotation;
           Quaternion coinRot = new Quaternion(0,-90,0,0);

            //transform.rotation = Quaternion.Euler(transform.rotation.x + xRotation, transform.rotation.y, transform.rotation.z);

            Vector3 spawnPos = new Vector3(Random.Range(-7, 7), 1.25F, player.transform.position.z + 300f);

            Quaternion rotZero = Quaternion.identity;
            coinRot.eulerAngles = new Vector3(90, 0, 0);

            cloneCoin = Instantiate(Coin, spawnPos, coinRot);

            //Debug.Log("COIN SPAWNED");

            Destroy(cloneCoin, 15);




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
