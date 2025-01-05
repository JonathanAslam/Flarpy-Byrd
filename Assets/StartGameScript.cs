using UnityEngine;

//used to load new scene
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("StartGameScript is running");
    }
    public void LoadGameScene()
    {
        Debug.Log("sceneName to load: " + "Game Scene");
        SceneManager.LoadScene("Game Scene");
    }
}
