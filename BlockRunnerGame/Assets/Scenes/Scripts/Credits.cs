using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public Text finalScoreText;
    public float finalScore;

    public void Score()
    {
        finalScore = PlayerPrefs.GetFloat("Player Score");
        //finalScoreText.text = finalScore.ToString("0");
        finalScoreText.text = "100";
    }



    public void Quit()
    {
        //Debug.Log(FindObjectOfType<Score>().scoreText);
        Debug.Log("Quit");
        Application.Quit();

    }


    public void RestartGame()
    {

        Debug.Log("Restart");
        SceneManager.LoadScene("Scene1");
        




    }




    
        
    
}
