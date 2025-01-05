using UnityEngine;

//allows us to access the UI elements in the scene (aka the text component we use for the score)
using UnityEngine.UI;

//restart game, need to use SceneManagement
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    //we do not need start and update in this script
    public int playerScore;
    bool isGameOver = false;

    // referenece to game scene objects
    public Text scoreText;
    public Text highScoreText;
    public GameObject GameOverScreen;

    //allow us to run this in unity 
    [ContextMenu("Add Score")]

    //public since we are running from other scripts 
    public void addScore(int scoreToAdd) 
    {
        // check to make sure the game is not over and add the score. if game is over, do nothing
        if (!isGameOver)
        {
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        //set isGameOver to true so point stops incremeneting.
        isGameOver = true;
        //show game over canvas screen when the bird hits something
        if (playerScore > PlayerPrefs.GetInt("Highscore")) {
            PlayerPrefs.SetInt("Highscore", playerScore);
            highScoreText.text = "High Score: " + PlayerPrefs.GetInt("Highscore").ToString();
            PlayerPrefs.Save();
        }
        GameOverScreen.SetActive(true); 
    }
}
