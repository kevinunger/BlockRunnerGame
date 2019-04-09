using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public Text finalScoreText;
    public float finalScore;
  

    public void Start()
    {
        Score();
    }

    public void Score()
    {
        finalScore = PlayerPrefs.GetFloat("FinalScore");
        finalScoreText.text = finalScore.ToString("0");
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
