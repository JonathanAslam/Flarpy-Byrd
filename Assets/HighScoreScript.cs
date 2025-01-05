using UnityEngine;

//allows us to use TEXT UI elements 
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Text highScoreText;
    
    void Start()
    {
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("Highscore").ToString();
    }
}
