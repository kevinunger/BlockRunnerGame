using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public float scorePos = 0;
    public float score = 0;
    public bool countScore = true;
    public bool gotCoin;
    

    void Update ()
    {

        if (gotCoin)
        {
            score += 100;
            gotCoin = false;

        }



        if (countScore == false)
        {
            Debug.Log("Stop Score!");
            PlayerPrefs.SetFloat("FinalScore", score);

            

        }

        else {

            scorePos = player.position.z;
            Debug.Log(score);
            Debug.Log(player.position.z);
            scoreText.text = score.ToString("0");




        }




    }

}

