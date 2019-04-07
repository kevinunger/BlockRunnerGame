using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    
    int zoom = 20;
    int normal = 60;
    float smooth = 5;



    public playerMovement playerMovement;


    /*

    void Update()
    {

        /* if (Input.GetKey("s")) {
             isZoomed = !isZoomed;
         }

        if (FindObjectOfType<playerMovement>().gettingBack == true)
        {

            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * smooth);

            Debug.Log("Zoom in");

            Invoke("resetZoom", 2);

        }



    }

        void resetZoom()
        {


            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, normal, Time.deltaTime * smooth);
            FindObjectOfType<playerMovement>().gettingBack = false;
        }

*/
    }

