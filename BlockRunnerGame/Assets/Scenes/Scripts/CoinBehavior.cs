﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class CoinBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(new Vector3(0, 0, 350) * Time.deltaTime);


       


    }


    private void OnCollisionEnter(Collision collisionInfo)
    {


        if (collisionInfo.collider.tag == "Player")
        {

            Destroy(FindObjectOfType<BlockSpawner>().cloneCoin);
            
            

        }







    }



}
