using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject endPanel, playerRed, playerBlue;

    [SerializeField] TMP_Text PlayerScoreText, AIScoreText, WinText;

    int PlayerScore, AIScore;

    public static GameManager Instance;

    




    private void Awake()
    {
       if(Instance == null)
          Instance = this;
       else 
           Destroy(gameObject);

        Time.timeScale = 1f;
        PlayerScore = 0;
        AIScore = 0;
        PlayerScoreText.text = (PlayerScore > 9 ? "" : "0") + PlayerScore.ToString();
        AIScoreText.text = (AIScore > 9 ? "" : "0") + AIScore.ToString();
        //startButton.SetActive(true);
        //endPanel.SetActive(true);
        playerRed.GetComponent<Player>().canMove = false;
        playerBlue.GetComponent<Player>().canMove = false;
    }

    public void StartGame()
    {
      //  startButton.SetActive(false);
      //  playerRed.GetComponent<Player>().canMove = true;
      //  playerBlue.GetComponent<Player>().canMove = true;
    }
 

    

    public void UpdateScore(bool isPlayer)
    {
        if (isPlayer)
        {
            PlayerScore++;
            PlayerScoreText.text = (PlayerScore > 9 ? "" : "0") + PlayerScore.ToString();
            if (PlayerScore == 5)
            {
                //endPanel.SetActive(true);
                Debug.Log("Score is 5");
                GameFinished(isPlayer);
                endPanel.SetActive(true);

            }
        }
        else
        {
            AIScore++;
            AIScoreText.text = (AIScore > 9 ? "" : "0") + AIScore.ToString();
            if (AIScore == 5)
            {
                //endPanel.SetActive(true);
                GameFinished(isPlayer);
                endPanel.SetActive(true);

            }

        }
    }

    private void GameFinished(bool isPlayer)
    {
        WinText.text = (isPlayer ? "Blue" : "Red") + " Wins!";
        //endPanel.SetActive(true);
        playerRed.GetComponent<Player>().canMove = false;
        playerBlue.GetComponent<Player>().canMove = false;
        Time.timeScale = 0f;
    }
    
    public void GameQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    public void GameRestart()
    {
        SceneManager.LoadScene("SampleScene");
       
    }
}
