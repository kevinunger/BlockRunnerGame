using UnityEngine;



public class followPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset ;      //3 Floats

    void Update()
    {

        //Debug.Log(player.position);

        transform.position = player.position + offset;


    }
}
