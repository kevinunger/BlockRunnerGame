using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 2f;

    public GameObject WinPanelUI;
    public Score score;


    public void EndGame ()
    {


        if (gameHasEnded == false)
        {

            gameHasEnded = true;
            Debug.Log("Game over");
            Invoke("Restart", restartDelay);
            //score.countScore = false;
            FindObjectOfType<Score>().countScore = false;

        }


    }




    public void CompleteLevel()
    {

        WinPanelUI.SetActive(true);
        Debug.Log("1");
        FindObjectOfType<Score>().countScore = false;

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);





    }



}
