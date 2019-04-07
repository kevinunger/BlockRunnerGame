using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;      //3 Floats
    public playerMovement playerMovement;

    int zoom = 15;
    int normal = 35;
    float smooth = 5;


    private void Start()
    {
        offset = new Vector3(0f, 3f, -10f);
    }

    void Update()
    {

        GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, normal, Time.deltaTime * smooth);

        transform.position = player.position + offset;
       

        if (FindObjectOfType<playerMovement>().gettingBack == true)
        {

            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * smooth);

            Invoke("resetZoom", 1);

        }
    }








void resetZoom()
{

       
    GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, normal, Time.deltaTime * smooth);
    FindObjectOfType<playerMovement>().gettingBack = false;
}





}
