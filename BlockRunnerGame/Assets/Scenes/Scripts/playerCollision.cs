﻿using UnityEngine;

public class playerCollision : MonoBehaviour
    

{

    public playerMovement movement;


    private void OnCollisionEnter(Collision collisionInfo)
    {


        if (collisionInfo.collider.tag == "Obstacle") {


            movement.enabled = false;
            FindObjectOfType<gameManager>().CompleteLevel();
            }
        if (collisionInfo.collider.tag == "Coin")
            {
            
            Destroy(collisionInfo.gameObject);
            FindObjectOfType<Score>().gotCoin = true;

            }
            
        



       



    }




}
