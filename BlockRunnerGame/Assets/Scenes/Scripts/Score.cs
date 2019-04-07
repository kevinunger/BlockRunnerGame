using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public bool countScore = true;
   
    

    void Update ()
    {

        if (countScore == false)
        {
            Debug.Log("Stop Score!");



        }

        else {


            scoreText.text = player.position.z.ToString("0");


        }


    }

}

