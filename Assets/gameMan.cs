using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameMan : MonoBehaviour {

    void Update()
    {
        text.text = PlayerPrefs.GetInt("score").ToString(); 

    } 

    public Text text; 
	
    public void Replay()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}
