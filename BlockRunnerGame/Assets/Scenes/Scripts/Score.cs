using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    public float score = 0;
    public float coinScore = 0;
    public bool countScore = true;
    public bool gotCoin;

    public float distance;

    void Update ()
    {



        if (gotCoin)
        {

            coinScore += 100;
            gotCoin = false;

        }



        if (countScore == false)
        {
            Debug.Log("Stop Score!");
            PlayerPrefs.SetFloat("FinalScore", score);

            

        }

        else {
            
            score = player.position.z + coinScore;

            Debug.Log(score);
            Debug.Log(player.position.z);
            scoreText.text = score.ToString("0");




        }




    }

}

